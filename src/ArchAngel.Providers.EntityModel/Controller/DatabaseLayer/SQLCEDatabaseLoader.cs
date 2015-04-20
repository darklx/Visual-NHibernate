using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using ArchAngel.Providers.EntityModel.Helper;
using ArchAngel.Providers.EntityModel.Model.DatabaseLayer;
using log4net;

namespace ArchAngel.Providers.EntityModel.Controller.DatabaseLayer
{
	public class SQLCEDatabaseLoader : IDatabaseLoader
	{
		private readonly static ILog log = LogManager.GetLogger(typeof(SQLCEDatabaseLoader));
		private ISQLCEDatabaseConnector connector;
		public event PropertyChangedEventHandler PropertyChanged;

		public SQLCEDatabaseLoader(ISQLCEDatabaseConnector connector)
		{
			this.connector = connector;
		}

		public List<SchemaData> DatabaseObjectsToFetch { get; set; }

		public void TestConnection()
		{
			try
			{
				connector.TestConnection();
			}
			catch (Exception e)
			{
				throw new DatabaseLoaderException("Could not open database connection. See inner exception for details.", e);
			}
		}

		public List<SchemaData> GetSchemaObjects()
		{
			try
			{
				connector.Open();
			}
			catch (Exception e)
			{
				throw new DatabaseLoaderException("Error opening database connection. See inner exception.", e);
			}
			HashSet<string> schemaNames = new HashSet<string>();
			List<string> fullTableNames = connector.GetTableNames();
			List<string> fullViewNames = connector.GetViewNames();

			foreach (string fullName in fullTableNames)
				schemaNames.Add(fullName.Split('|')[1]);

			foreach (string fullName in fullViewNames)
				schemaNames.Add(fullName.Split('|')[1]);

			List<SchemaData> schemaDatas = new List<SchemaData>();

			foreach (var schema in schemaNames)
			{
				List<string> tableNames = new List<string>();
				List<string> viewNames = new List<string>();

				foreach (string tableName in fullTableNames.Where(f => f.EndsWith("|" + schema)))
					tableNames.Add(tableName.Split('|')[0]);

				foreach (string viewName in fullViewNames.Where(f => f.EndsWith("|" + schema)))
					viewNames.Add(viewName.Split('|')[0]);

				schemaDatas.Add(new SchemaData(schema, tableNames, viewNames));
			}
			connector.Close();
			return schemaDatas;
		}

		/// <summary>
		/// Attempts to read the Database Schema from the database represented by the DatabaseConnector.
		/// </summary>
		/// <returns>The Database that has been read.</returns>
		/// <exception cref="DatabaseLoaderException">Thrown if there was an issue in the exection of this request.</exception>
		public Database LoadDatabase(List<SchemaData> databaseObjectsToFetch, List<string> allowedSchemas)
		{
			try
			{
				connector.Open();
			}
			catch (Exception e)
			{
				throw new DatabaseLoaderException("Error opening database connection. See inner exception.", e);
			}
			try
			{
				var name = Path.GetFileNameWithoutExtension(connector.DatabaseName);
				var db = new Database(name, DatabaseTypes.SQLCE) { Loader = this };
				db.ConnectionInformation = DatabaseConnector.ConnectionInformation;
				SetSchemaFilter(databaseObjectsToFetch);

				foreach (var table in GetTables(databaseObjectsToFetch))
					db.AddTable(table);

				foreach (var view in GetViews(databaseObjectsToFetch))
					db.AddView(view);

				GetForeignKeys(db);
				return db;
			}
			catch (Exception e)
			{
				throw new DatabaseLoaderException("Error loading database. See inner exception.", e);
			}
			finally
			{
				connector.Close();
			}
		}

		private void SetSchemaFilter(List<SchemaData> databaseObjectsToFetch)
		{
			connector.SchemaFilterCSV = "";

			if (databaseObjectsToFetch != null)
				foreach (SchemaData data in databaseObjectsToFetch)
					connector.SchemaFilterCSV += string.Format("'{0}',", data.Name);

			if (!string.IsNullOrEmpty(connector.SchemaFilterCSV))
				connector.SchemaFilterCSV = connector.SchemaFilterCSV.TrimEnd(',');
		}

		public IDatabaseConnector DatabaseConnector
		{
			get { return connector; }
			set
			{
				if (value is SQLCEDatabaseConnector == false)
					throw new ArgumentException("Cannot use a " + value.GetType() +
												" as a connector for a SQLCEDatabaseLoader");
				connector = (SQLCEDatabaseConnector)value;
			}
		}

		public List<Table> GetTables(List<SchemaData> tablesToFetch)
		{
			log.DebugFormat("GetTables() called");
			List<string> tableNames = connector.GetTableNames();

			List<Table> tables = new List<Table>();
			foreach (string tableNameEx in tableNames)
			{
				//string schema = "";

				//if (tablesToFetch == null || 
				//    tablesToFetch.Exists(t => t.Name == schema && t.TableNames.Contains(tableName)))
				//{
				//    Table table = GetNewTable(tableName);
				//    tables.Add(table);
				//}
				string[] parts = tableNameEx.Split('|');
				string tableName = parts[0];
				string schema = parts[1];

				if (tablesToFetch == null ||
					tablesToFetch.Exists(t => t.Name == schema && t.TableNames.Contains(tableName)))
				{
					Table table = GetNewTable(tableName, schema);
					tables.Add(table);
				}
			}

			return tables;
		}

		private Table GetNewTable(string tableName, string schema)
		{
			Interfaces.Events.RaiseObjectBeingProcessedEvent(tableName, "Table");
			Table table = new Table { Name = tableName, Schema = schema, IsUserDefined = false, IsView = false };

			GetColumns(table);
			GetIndexes(table);
			GetKeys(table);

			table.ResetDefaults();

			return table;
		}

		public List<Table> GetViews(List<SchemaData> viewsToFetch)
		{
			log.DebugFormat("GetViews() called");

			List<string> viewNames = connector.GetViewNames();

			List<Table> views = new List<Table>();
			foreach (string viewNameEx in viewNames)
			{
				string[] parts = viewNameEx.Split('|');
				string viewName = parts[0];
				string schema = parts[1];

				if (viewsToFetch == null ||
					viewsToFetch.Exists(t => t.Name == schema && t.ViewNames.Contains(viewName)))
				{
					Table view = GetNewView(viewName, schema);
					views.Add(view);
				}
			}
			return views;
		}

		private Table GetNewView(string viewName, string schema)
		{
			Interfaces.Events.RaiseObjectBeingProcessedEvent(viewName, "View");
			Table table = new Table { Name = viewName, Schema = schema, IsUserDefined = false, IsView = true };

			GetColumns(table);
			//GetIndexes(table);
			//GetKeys(table);

			table.ResetDefaults();
			return table;
		}

		private void GetKeys(ITable table)
		{
			DataRow[] keyRows = connector.Indexes.Select(string.Format("TABLE_NAME = '{0}'", table.Name.Replace("'", "''")));

			for (int i = 0; i < keyRows.Length; i++)
			{
				DataRow keyRow = keyRows[i];
				DatabaseKeyType keyType;
				string indexKeyType = keyRow["CONSTRAINT_TYPE"].ToString();

				if (indexKeyType == "PRIMARY KEY")
				{
					keyType = DatabaseKeyType.Primary;
				}
				else if (indexKeyType == "UNIQUE")
				{
					keyType = DatabaseKeyType.Unique;
				}
				else
				{
					continue;
				}

				Key key = new Key
							{
								Name = keyRow["INDEX_NAME"].ToString(),
								IsUserDefined = false,
								Keytype = keyType,
								Parent = table,
								IsUnique = true
							};

				// Fill Columns
				List<DataRow> keyColumnRows = new List<DataRow>();
				keyColumnRows.AddRange(connector.Columns.Select(string.Format("TABLE_NAME = '{0}' AND COLUMN_NAME  = '{1}'", table.Name.Replace("'", "''"), keyRow["COLUMN_NAME"])));

				while ((i < keyRows.Length - 1) && (string)keyRows[i + 1]["TABLE_NAME"] == table.Name && (string)keyRows[i + 1]["INDEX_NAME"] == (string)keyRow["INDEX_NAME"])
				{
					i++;
					keyRow = keyRows[i];
					keyColumnRows.AddRange(connector.Columns.Select(string.Format("TABLE_NAME = '{0}' AND COLUMN_NAME  = '{1}'", table.Name.Replace("'", "''"), keyRow["COLUMN_NAME"])));
				}

				// Fill Columns
				foreach (DataRow keyColumnRow in keyColumnRows)
					key.AddColumn((string)keyColumnRow["COLUMN_NAME"]);

				key.ResetDefaults();
				table.AddKey(key);
			}
		}

		private void GetForeignKeys(IDatabase db)
		{
			DataTable keysTable = connector.GetForeignKeyConstraints();

			foreach (DataRow keyRow in keysTable.Rows)
			{
				ITable parentTable = db.GetTable((string)keyRow["PrimaryTable"], "");
				ITable foreignTable = db.GetTable((string)keyRow["ForeignTable"], "");

				// Don't process keys of tables that the user hasn't selected
				if (parentTable == null || foreignTable == null)
					continue;

				Key key = new Key
							{
								Name = keyRow["PrimaryKeyName"].ToString(),
								IsUserDefined = false,
								Keytype = DatabaseKeyType.Foreign,
								Parent = parentTable
							};
				//////////////////
				key.IsUnique = connector.GetUniqueIndexes().Select(string.Format("INDEX_NAME = '{0}'", key.Name)).Length > 0;
				//foreignTable.AddKey(key);
				//////////////////

				// Get Foreign Key columns
				DataRow[] foreignKeyColumns = connector.GetForeignKeyColumns().Select(string.Format("CONSTRAINT_NAME = '{0}' AND TABLE_NAME = '{1}'", key.Name.Replace("'", "''"), foreignTable.Name));

				foreach (DataRow row in foreignKeyColumns)
					key.AddColumn((string)row["COLUMN_NAME"]);

				DataRow[] keyReferencedColumnRows =
					connector.IndexReferencedColumns.Select(string.Format("ForeignKey = '{0}'", keyRow["CONSTRAINT_NAME"]));
				DataRow firstKeyReferencedColumnRow = keyReferencedColumnRows[0];
				// Fill References
				key.ReferencedKey = foreignTable.GetKey((string)firstKeyReferencedColumnRow["ReferencedKey"]);

				parentTable.AddKey(key);
			}

			return;
		}

		private void GetIndexes(Table table)
		{
			GetTableConstraintIndexes(table);
			GetUniqueIndexes(table);
		}

		private void GetUniqueIndexes(Table table)
		{
			DataRow[] indexRows = connector.GetUniqueIndexes().Select(string.Format("TABLE_NAME = '{0}'", table.Name.Replace("'", "''")));

			for (int i = 0; i < indexRows.Length; i++)
			{
				DataRow indexRow = indexRows[i];

				Index index = new Index
								{
									Name = (string)indexRow["INDEX_NAME"],
									IsUserDefined = false,
									IsUnique = true,
									IsClustered = (bool)indexRow["ISCLUSTERED"],
									IndexType = DatabaseIndexType.Unique,
									Parent = table
								};

				List<DataRow> indexColumnRows = new List<DataRow>();

				indexColumnRows.AddRange(connector.Columns.Select(string.Format("TABLE_NAME = '{0}' AND COLUMN_NAME  = '{1}'", table.Name.Replace("'", "''"), indexRow["COLUMN_NAME"])));

				while ((i < indexRows.Length - 1) && (string)indexRows[i + 1]["TABLE_NAME"] == table.Name && (string)indexRows[i + 1]["INDEX_NAME"] == (string)indexRow["INDEX_NAME"])
				{
					i++;
					indexRow = indexRows[i];
					indexColumnRows.AddRange(connector.Columns.Select(string.Format("TABLE_NAME = '{0}' AND COLUMN_NAME  = '{1}'", table.Name.Replace("'", "''"), indexRow["COLUMN_NAME"])));
				}

				// Fill Columns
				foreach (DataRow indexColumnRow in indexColumnRows)
				{
					var column = index.AddColumn((string)indexColumnRow["COLUMN_NAME"]);

					if (index.IsUnique && indexColumnRows.Count == 1)
					{
						// Columns are only unique if the index has one column
						column.IsUnique = true;
					}
				}

				index.ResetDefaults();
				table.AddIndex(index);
			}
		}

		internal void GetTableConstraintIndexes(Table table)
		{
			DataRow[] indexRows = connector.Indexes.Select(string.Format("TABLE_NAME = '{0}'", table.Name.Replace("'", "''")));
			//foreach (DataRow indexRow in indexRows)
			for (int i = 0; i < indexRows.Length; i++)
			{
				DataRow indexRow = indexRows[i];
				DatabaseIndexType indexType = GetIndexType(indexRow["CONSTRAINT_TYPE"].ToString());

				var indexColumnRows = new List<DataRow>();

				indexColumnRows.AddRange(connector.Columns.Select(string.Format("TABLE_NAME = '{0}' AND COLUMN_NAME  = '{1}'", table.Name.Replace("'", "''"), indexRow["COLUMN_NAME"])));

				while ((i < indexRows.Length - 1) && (string)indexRows[i + 1]["TABLE_NAME"] == table.Name && (string)indexRows[i + 1]["INDEX_NAME"] == (string)indexRow["INDEX_NAME"])
				{
					i++;
					indexRow = indexRows[i];
					indexColumnRows.AddRange(connector.Columns.Select(string.Format("TABLE_NAME = '{0}' AND COLUMN_NAME  = '{1}'", table.Name.Replace("'", "''"), indexRow["COLUMN_NAME"])));
				}
				bool isUnique = (bool)indexRow["ISUNIQUE"];
				bool isClustered = (bool)indexRow["ISCLUSTERED"];
				Index index = new Index
								{
									Name = indexRow["INDEX_NAME"].ToString(),
									IsUserDefined = false,
									IndexType = indexType,
									Parent = table,
									IsUnique = isUnique,
									IsClustered = isClustered
								};

				// Fill Columns
				foreach (DataRow indexColumnRow in indexColumnRows)
				{
					var column = index.AddColumn((string)indexColumnRow["COLUMN_NAME"]);

					if (index.IsUnique && indexColumnRows.Count == 1)
					{
						// Columns are only unique if the index has one column
						column.IsUnique = true;
					}
				}
				index.ResetDefaults();
				table.AddIndex(index);
			}
		}

		private DatabaseIndexType GetIndexType(string indexKeyType)
		{
			DatabaseIndexType indexType;
			switch (indexKeyType)
			{
				case "PRIMARY KEY":
					indexType = DatabaseIndexType.PrimaryKey;
					break;
				case "UNIQUE":
					indexType = DatabaseIndexType.Unique;
					break;
				case "CHECK":
					throw new InvalidOperationException("The SQLCE Database Loader does not support Check indexes.");
				case "NONE":
					indexType = DatabaseIndexType.None;
					break;
				default:
					throw new Exception("IndexType " + indexKeyType + " Not Defined");
			}
			return indexType;
		}

		private void GetColumns(ITable table)
		{
			Type uniDBType = typeof(SQLServer.UniDbTypes);
			DataRow[] columnRows = connector.Columns.Select(string.Format("TABLE_NAME = '{0}'", table.Name.Replace("'", "''")));

			foreach (DataRow columnRow in columnRows)
			{
				bool isReadOnly = false;

				if (Slyce.Common.Utility.StringsAreEqual((string)columnRow["DATA_TYPE"], "timestamp", false))
				{
					isReadOnly = true;
				}
				Column column = new Column();
				column.Name = (string)columnRow["COLUMN_NAME"];
				column.IsUserDefined = false;
				column.Parent = table;
				column.IsIdentity = "TRUE".Equals((string)columnRow["IS_IDENTITY"], StringComparison.OrdinalIgnoreCase);
				column.OrdinalPosition = (int)columnRow["ORDINAL_POSITION"];
				column.IsNullable = Slyce.Common.Utility.StringsAreEqual((string)columnRow["IS_NULLABLE"], "YES", false);
				column.OriginalDataType = (string)columnRow["DATA_TYPE"];
				column.Size = columnRow.IsNull("CHARACTER_MAXIMUM_LENGTH")
								? 0
								: Convert.ToInt64(columnRow["CHARACTER_MAXIMUM_LENGTH"]);
				column.InPrimaryKey = connector.DoesColumnHaveConstraint(column, "PRIMARY KEY");
				column.IsUnique = connector.DoesColumnHaveConstraint(column, "UNIQUE");
				column.Default = columnRow.IsNull("COLUMN_DEFAULT") ? "" : (string)columnRow["COLUMN_DEFAULT"];
				column.IsReadOnly = isReadOnly;
				column.Precision = columnRow.IsNull("NUMERIC_PRECISION") ? 0 : Convert.ToInt32(columnRow["NUMERIC_PRECISION"]);
				column.Scale = columnRow.IsNull("NUMERIC_SCALE") ? 0 : Convert.ToInt32(columnRow["NUMERIC_SCALE"]);

				column.ResetDefaults();

				table.AddColumn(column);
			}
		}
	}
}
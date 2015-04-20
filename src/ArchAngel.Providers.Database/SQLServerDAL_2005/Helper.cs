using System;
using ArchAngel.Providers.Database.Model;
using ArchAngel.Providers.Database.IDAL;
using ArchAngel.Providers.Database.Helper;

namespace ArchAngel.Providers.Database.SQLServerDAL_2005
{
    public class Helper : IHelper
    {
    	public Key GetPrimaryKey(Model.Table table)
        {
            foreach (Key key in table.Keys)
            {
                if (key.Type == DatabaseConstant.KeyType.Primary)
                {
                    return key;
                }
            }

            throw new Exception("Cannont find primary key for table " + table.Alias);
        }

        public bool IsDataTypeText(Column column)
        {
            switch (column.DataType)
            {
                case "char":
                    return true;

                case "nchar":
                    return true;

                case "ntext":
                    return true;

                case "nvarchar":
                    return true;

                case "text":
                    return true;

                case "varchar":
                    return true;

                default:
                    return false;
            }
        }

        public string[] GetDataTypes()
        {
            return Providers.Database.Helper.SQLServer.DataTypes;
        }
    }
}
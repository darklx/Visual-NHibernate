﻿namespace ArchAngel.Providers.EntityModel.UI.Editors.UserControls
{
	partial class DatabaseSynchroEditor
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.databaseChanges1 = new ArchAngel.Providers.EntityModel.UI.Editors.UserControls.DatabaseChanges();
			this.SuspendLayout();
			// 
			// databaseChanges1
			// 
			this.databaseChanges1.Location = new System.Drawing.Point(12, 12);
			this.databaseChanges1.Name = "databaseChanges1";
			this.databaseChanges1.Size = new System.Drawing.Size(664, 430);
			this.databaseChanges1.TabIndex = 0;
			// 
			// DatabaseSynchroEditor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(695, 490);
			this.Controls.Add(this.databaseChanges1);
			this.Name = "DatabaseSynchroEditor";
			this.ResumeLayout(false);

		}

		#endregion

		private DatabaseChanges databaseChanges1;

	}
}

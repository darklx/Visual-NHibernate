namespace ArchAngel.Designer.Wizards.TemplateSync
{
    partial class ScreenUserOptions
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScreenUserOptions));
            this.treeListBoth = new DevExpress.XtraTreeList.TreeList();
            this.treeListColumn1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn2 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn3 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.treeListColumn5 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.repositoryItemPictureEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonApplyAll = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonImportAll = new System.Windows.Forms.Button();
            this.buttonImportSelected = new System.Windows.Forms.Button();
            this.treeListTheirs = new DevExpress.XtraTreeList.TreeList();
            this.treeListColumn4 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.repositoryItemPictureEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.repositoryItemButtonEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.imageListTreeNodeStates = new System.Windows.Forms.ImageList(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.buttonRemoveAll = new System.Windows.Forms.Button();
            this.buttonRemoveSelected = new System.Windows.Forms.Button();
            this.treeListMine = new DevExpress.XtraTreeList.TreeList();
            this.treeListColumn11 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.repositoryItemPictureEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.repositoryItemButtonEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.treeListBoth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeListTheirs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeListMine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit3)).BeginInit();
            this.SuspendLayout();
            // 
            // treeListBoth
            // 
            this.treeListBoth.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.treeListBoth.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeListColumn1,
            this.treeListColumn2,
            this.treeListColumn3,
            this.treeListColumn5});
            this.treeListBoth.Location = new System.Drawing.Point(0, 16);
            this.treeListBoth.Name = "treeListBoth";
            this.treeListBoth.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.treeListBoth.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemPictureEdit1,
            this.repositoryItemButtonEdit1});
            this.treeListBoth.Size = new System.Drawing.Size(692, 163);
            this.treeListBoth.TabIndex = 1;
            this.treeListBoth.ShowingEditor += new System.ComponentModel.CancelEventHandler(this.treeList1_ShowingEditor);
            this.treeListBoth.CustomNodeCellEdit += new DevExpress.XtraTreeList.GetCustomNodeCellEditEventHandler(this.treeList1_CustomNodeCellEdit);
            // 
            // treeListColumn1
            // 
            this.treeListColumn1.Caption = "Name";
            this.treeListColumn1.FieldName = "Name";
            this.treeListColumn1.Name = "treeListColumn1";
            this.treeListColumn1.OptionsColumn.AllowEdit = false;
            this.treeListColumn1.Visible = true;
            this.treeListColumn1.VisibleIndex = 0;
            this.treeListColumn1.Width = 184;
            // 
            // treeListColumn2
            // 
            this.treeListColumn2.Caption = "Their Value";
            this.treeListColumn2.FieldName = "Their Value";
            this.treeListColumn2.Name = "treeListColumn2";
            this.treeListColumn2.OptionsColumn.AllowEdit = false;
            this.treeListColumn2.Visible = true;
            this.treeListColumn2.VisibleIndex = 1;
            this.treeListColumn2.Width = 183;
            // 
            // treeListColumn3
            // 
            this.treeListColumn3.ColumnEdit = this.repositoryItemButtonEdit1;
            this.treeListColumn3.FieldName = "Action";
            this.treeListColumn3.Name = "treeListColumn3";
            this.treeListColumn3.Visible = true;
            this.treeListColumn3.VisibleIndex = 2;
            this.treeListColumn3.Width = 91;
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("repositoryItemButtonEdit1.Appearance.Image")));
            this.repositoryItemButtonEdit1.Appearance.Options.UseImage = true;
            this.repositoryItemButtonEdit1.AutoHeight = false;
            this.repositoryItemButtonEdit1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", 30, true, true, false, DevExpress.Utils.HorzAlignment.Center, ((System.Drawing.Image)(resources.GetObject("repositoryItemButtonEdit1.Buttons"))))});
            this.repositoryItemButtonEdit1.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.repositoryItemButtonEdit1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            this.repositoryItemButtonEdit1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.repositoryItemButtonEdit1.LookAndFeel.UseWindowsXPTheme = true;
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            this.repositoryItemButtonEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // treeListColumn5
            // 
            this.treeListColumn5.Caption = "My Value";
            this.treeListColumn5.FieldName = "My Value";
            this.treeListColumn5.Name = "treeListColumn5";
            this.treeListColumn5.Visible = true;
            this.treeListColumn5.VisibleIndex = 3;
            this.treeListColumn5.Width = 207;
            // 
            // repositoryItemPictureEdit1
            // 
            this.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.buttonApplyAll);
            this.splitContainer1.Panel1.Controls.Add(this.treeListBoth);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(839, 542);
            this.splitContainer1.SplitterDistance = 182;
            this.splitContainer1.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(698, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 123);
            this.label4.TabIndex = 9;
            this.label4.Text = "Individual settings can be imported by clicking the green arrow in the grid.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 14);
            this.label1.TabIndex = 8;
            this.label1.Text = "Modified UserOptions found in both templates:";
            // 
            // buttonApplyAll
            // 
            this.buttonApplyAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonApplyAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonApplyAll.ImageIndex = 0;
            this.buttonApplyAll.ImageList = this.imageList1;
            this.buttonApplyAll.Location = new System.Drawing.Point(698, 16);
            this.buttonApplyAll.Name = "buttonApplyAll";
            this.buttonApplyAll.Size = new System.Drawing.Size(130, 25);
            this.buttonApplyAll.TabIndex = 7;
            this.buttonApplyAll.Text = "      Apply All Changes";
            this.buttonApplyAll.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonApplyAll.UseVisualStyleBackColor = true;
            this.buttonApplyAll.Click += new System.EventHandler(this.buttonApplyAll_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Magenta;
            this.imageList1.Images.SetKeyName(0, "Input.bmp");
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.label2);
            this.splitContainer2.Panel1.Controls.Add(this.buttonImportAll);
            this.splitContainer2.Panel1.Controls.Add(this.buttonImportSelected);
            this.splitContainer2.Panel1.Controls.Add(this.treeListTheirs);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.label3);
            this.splitContainer2.Panel2.Controls.Add(this.buttonRemoveAll);
            this.splitContainer2.Panel2.Controls.Add(this.buttonRemoveSelected);
            this.splitContainer2.Panel2.Controls.Add(this.treeListMine);
            this.splitContainer2.Size = new System.Drawing.Size(839, 356);
            this.splitContainer2.SplitterDistance = 181;
            this.splitContainer2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 14);
            this.label2.TabIndex = 9;
            this.label2.Text = "UserOptions in \'their\' template only:";
            // 
            // buttonImportAll
            // 
            this.buttonImportAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonImportAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonImportAll.ImageIndex = 0;
            this.buttonImportAll.ImageList = this.imageList1;
            this.buttonImportAll.Location = new System.Drawing.Point(735, 48);
            this.buttonImportAll.Name = "buttonImportAll";
            this.buttonImportAll.Size = new System.Drawing.Size(93, 25);
            this.buttonImportAll.TabIndex = 6;
            this.buttonImportAll.Text = "      Import All";
            this.buttonImportAll.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonImportAll.UseVisualStyleBackColor = true;
            this.buttonImportAll.Click += new System.EventHandler(this.buttonImportAll_Click);
            // 
            // buttonImportSelected
            // 
            this.buttonImportSelected.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonImportSelected.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonImportSelected.ImageIndex = 0;
            this.buttonImportSelected.ImageList = this.imageList1;
            this.buttonImportSelected.Location = new System.Drawing.Point(697, 17);
            this.buttonImportSelected.Name = "buttonImportSelected";
            this.buttonImportSelected.Size = new System.Drawing.Size(131, 25);
            this.buttonImportSelected.TabIndex = 5;
            this.buttonImportSelected.Text = "      Import Selected";
            this.buttonImportSelected.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonImportSelected.UseVisualStyleBackColor = true;
            this.buttonImportSelected.Click += new System.EventHandler(this.buttonImportSelected_Click);
            // 
            // treeListTheirs
            // 
            this.treeListTheirs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.treeListTheirs.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeListColumn4});
            this.treeListTheirs.Location = new System.Drawing.Point(0, 17);
            this.treeListTheirs.Name = "treeListTheirs";
            this.treeListTheirs.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.treeListTheirs.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemPictureEdit2,
            this.repositoryItemButtonEdit2});
            this.treeListTheirs.Size = new System.Drawing.Size(692, 162);
            this.treeListTheirs.StateImageList = this.imageListTreeNodeStates;
            this.treeListTheirs.TabIndex = 2;
            this.treeListTheirs.StateImageClick += new DevExpress.XtraTreeList.NodeClickEventHandler(this.treeListTheirs_StateImageClick);
            // 
            // treeListColumn4
            // 
            this.treeListColumn4.Caption = "Name";
            this.treeListColumn4.FieldName = "Name";
            this.treeListColumn4.MinWidth = 27;
            this.treeListColumn4.Name = "treeListColumn4";
            this.treeListColumn4.OptionsColumn.AllowEdit = false;
            this.treeListColumn4.Visible = true;
            this.treeListColumn4.VisibleIndex = 0;
            this.treeListColumn4.Width = 184;
            // 
            // repositoryItemPictureEdit2
            // 
            this.repositoryItemPictureEdit2.Name = "repositoryItemPictureEdit2";
            // 
            // repositoryItemButtonEdit2
            // 
            this.repositoryItemButtonEdit2.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("repositoryItemButtonEdit2.Appearance.Image")));
            this.repositoryItemButtonEdit2.Appearance.Options.UseImage = true;
            this.repositoryItemButtonEdit2.AutoHeight = false;
            this.repositoryItemButtonEdit2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.repositoryItemButtonEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", 30, true, true, false, DevExpress.Utils.HorzAlignment.Center, ((System.Drawing.Image)(resources.GetObject("repositoryItemButtonEdit2.Buttons"))))});
            this.repositoryItemButtonEdit2.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.repositoryItemButtonEdit2.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            this.repositoryItemButtonEdit2.LookAndFeel.UseDefaultLookAndFeel = false;
            this.repositoryItemButtonEdit2.LookAndFeel.UseWindowsXPTheme = true;
            this.repositoryItemButtonEdit2.Name = "repositoryItemButtonEdit2";
            this.repositoryItemButtonEdit2.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // imageListTreeNodeStates
            // 
            this.imageListTreeNodeStates.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListTreeNodeStates.ImageStream")));
            this.imageListTreeNodeStates.TransparentColor = System.Drawing.Color.Magenta;
            this.imageListTreeNodeStates.Images.SetKeyName(0, "");
            this.imageListTreeNodeStates.Images.SetKeyName(1, "");
            this.imageListTreeNodeStates.Images.SetKeyName(2, "");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 14);
            this.label3.TabIndex = 10;
            this.label3.Text = "UserOptions in \'my\' template only:";
            // 
            // buttonRemoveAll
            // 
            this.buttonRemoveAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRemoveAll.Image = ((System.Drawing.Image)(resources.GetObject("buttonRemoveAll.Image")));
            this.buttonRemoveAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRemoveAll.Location = new System.Drawing.Point(735, 48);
            this.buttonRemoveAll.Name = "buttonRemoveAll";
            this.buttonRemoveAll.Size = new System.Drawing.Size(93, 25);
            this.buttonRemoveAll.TabIndex = 4;
            this.buttonRemoveAll.Text = "     Remove All";
            this.buttonRemoveAll.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRemoveAll.UseVisualStyleBackColor = true;
            this.buttonRemoveAll.Click += new System.EventHandler(this.buttonRemoveAll_Click);
            // 
            // buttonRemoveSelected
            // 
            this.buttonRemoveSelected.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRemoveSelected.Image = ((System.Drawing.Image)(resources.GetObject("buttonRemoveSelected.Image")));
            this.buttonRemoveSelected.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRemoveSelected.Location = new System.Drawing.Point(697, 17);
            this.buttonRemoveSelected.Name = "buttonRemoveSelected";
            this.buttonRemoveSelected.Size = new System.Drawing.Size(131, 25);
            this.buttonRemoveSelected.TabIndex = 3;
            this.buttonRemoveSelected.Text = "     Remove Selected";
            this.buttonRemoveSelected.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRemoveSelected.UseVisualStyleBackColor = true;
            this.buttonRemoveSelected.Click += new System.EventHandler(this.buttonRemoveSelected_Click);
            // 
            // treeListMine
            // 
            this.treeListMine.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.treeListMine.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeListColumn11});
            this.treeListMine.Location = new System.Drawing.Point(0, 17);
            this.treeListMine.Name = "treeListMine";
            this.treeListMine.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.treeListMine.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemPictureEdit3,
            this.repositoryItemButtonEdit3});
            this.treeListMine.Size = new System.Drawing.Size(692, 154);
            this.treeListMine.StateImageList = this.imageListTreeNodeStates;
            this.treeListMine.TabIndex = 2;
            this.treeListMine.StateImageClick += new DevExpress.XtraTreeList.NodeClickEventHandler(this.treeListMine_StateImageClick);
            // 
            // treeListColumn11
            // 
            this.treeListColumn11.Caption = "Name";
            this.treeListColumn11.FieldName = "Name";
            this.treeListColumn11.MinWidth = 27;
            this.treeListColumn11.Name = "treeListColumn11";
            this.treeListColumn11.OptionsColumn.AllowEdit = false;
            this.treeListColumn11.Visible = true;
            this.treeListColumn11.VisibleIndex = 0;
            this.treeListColumn11.Width = 715;
            // 
            // repositoryItemPictureEdit3
            // 
            this.repositoryItemPictureEdit3.Name = "repositoryItemPictureEdit3";
            // 
            // repositoryItemButtonEdit3
            // 
            this.repositoryItemButtonEdit3.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("repositoryItemButtonEdit3.Appearance.Image")));
            this.repositoryItemButtonEdit3.Appearance.Options.UseImage = true;
            this.repositoryItemButtonEdit3.AutoHeight = false;
            this.repositoryItemButtonEdit3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.repositoryItemButtonEdit3.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", 30, true, true, false, DevExpress.Utils.HorzAlignment.Center, ((System.Drawing.Image)(resources.GetObject("repositoryItemButtonEdit3.Buttons"))))});
            this.repositoryItemButtonEdit3.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.repositoryItemButtonEdit3.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            this.repositoryItemButtonEdit3.LookAndFeel.UseDefaultLookAndFeel = false;
            this.repositoryItemButtonEdit3.LookAndFeel.UseWindowsXPTheme = true;
            this.repositoryItemButtonEdit3.Name = "repositoryItemButtonEdit3";
            this.repositoryItemButtonEdit3.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // ScreenUserOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "ScreenUserOptions";
            this.Size = new System.Drawing.Size(839, 542);
            ((System.ComponentModel.ISupportInitialize)(this.treeListBoth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treeListTheirs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeListMine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTreeList.TreeList treeListBoth;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn2;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn3;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn5;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private DevExpress.XtraTreeList.TreeList treeListTheirs;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn4;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit2;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit2;
        private DevExpress.XtraTreeList.TreeList treeListMine;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn11;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit3;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit3;
        private System.Windows.Forms.ImageList imageListTreeNodeStates;
        private System.Windows.Forms.Button buttonRemoveAll;
        private System.Windows.Forms.Button buttonRemoveSelected;
        private System.Windows.Forms.Button buttonImportAll;
        private System.Windows.Forms.Button buttonImportSelected;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button buttonApplyAll;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

namespace DatabaseManager
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            toolStrip1 = new ToolStrip();
            toolStripDropDownButton1 = new ToolStripDropDownButton();
            createToolStripMenuItem = new ToolStripMenuItem();
            btnCreateDatabase = new ToolStripMenuItem();
            btnCreateTable = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            btnDataBaseDelete = new ToolStripMenuItem();
            btnTableDelete = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            btnRenameDB = new ToolStripMenuItem();
            TabHost = new TabControl();
            contextMenuDelete = new ContextMenuStrip(components);
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripDropDownButton1 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 25);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            toolStripDropDownButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripDropDownButton1.DropDownItems.AddRange(new ToolStripItem[] { createToolStripMenuItem, deleteToolStripMenuItem, saveToolStripMenuItem, editToolStripMenuItem });
            toolStripDropDownButton1.Image = (Image)resources.GetObject("toolStripDropDownButton1.Image");
            toolStripDropDownButton1.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            toolStripDropDownButton1.Size = new Size(40, 22);
            toolStripDropDownButton1.Text = "Edit";
            // 
            // createToolStripMenuItem
            // 
            createToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { btnCreateDatabase, btnCreateTable });
            createToolStripMenuItem.Name = "createToolStripMenuItem";
            createToolStripMenuItem.Size = new Size(180, 22);
            createToolStripMenuItem.Text = "Create ";
            // 
            // btnCreateDatabase
            // 
            btnCreateDatabase.Name = "btnCreateDatabase";
            btnCreateDatabase.Size = new Size(122, 22);
            btnCreateDatabase.Text = "Database";
            btnCreateDatabase.Click += btnCreateDatabase_Click;
            // 
            // btnCreateTable
            // 
            btnCreateTable.Name = "btnCreateTable";
            btnCreateTable.Size = new Size(122, 22);
            btnCreateTable.Text = "Table";
            btnCreateTable.Click += btnCreateTable_Click;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { btnDataBaseDelete, btnTableDelete });
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(180, 22);
            deleteToolStripMenuItem.Text = "Delete";
            // 
            // btnDataBaseDelete
            // 
            btnDataBaseDelete.Name = "btnDataBaseDelete";
            btnDataBaseDelete.Size = new Size(122, 22);
            btnDataBaseDelete.Text = "Database";
            btnDataBaseDelete.Click += btnDataBaseDelete_Click;
            // 
            // btnTableDelete
            // 
            btnTableDelete.Name = "btnTableDelete";
            btnTableDelete.Size = new Size(122, 22);
            btnTableDelete.Text = "Table";
            btnTableDelete.Click += btnTableDelete_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(180, 22);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { btnRenameDB });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(180, 22);
            editToolStripMenuItem.Text = "Edit";
            // 
            // btnRenameDB
            // 
            btnRenameDB.Name = "btnRenameDB";
            btnRenameDB.Size = new Size(180, 22);
            btnRenameDB.Text = "RenameDB";
            btnRenameDB.Click += btnRenameDB_Click;
            // 
            // TabHost
            // 
            TabHost.Dock = DockStyle.Fill;
            TabHost.Location = new Point(0, 25);
            TabHost.Name = "TabHost";
            TabHost.SelectedIndex = 0;
            TabHost.Size = new Size(800, 425);
            TabHost.TabIndex = 1;
            // 
            // contextMenuDelete
            // 
            contextMenuDelete.Name = "contextMenuDelete";
            contextMenuDelete.Size = new Size(61, 4);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TabHost);
            Controls.Add(toolStrip1);
            Name = "Form1";
            Text = "Form1";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripMenuItem createToolStripMenuItem;
        private ToolStripMenuItem btnCreateDatabase;
        private ToolStripMenuItem btnCreateTable;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private TabControl TabHost;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ContextMenuStrip contextMenuDelete;
        private ToolStripMenuItem btnDataBaseDelete;
        private ToolStripMenuItem btnTableDelete;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem btnRenameDB;
        private ToolStripMenuItem editTableToolStripMenuItem;
    }
}

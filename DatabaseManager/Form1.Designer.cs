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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            toolStrip1 = new ToolStrip();
            toolStripDropDownButton1 = new ToolStripDropDownButton();
            createToolStripMenuItem = new ToolStripMenuItem();
            btnCreateDatabase = new ToolStripMenuItem();
            btnCreateTable = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            TabHost = new TabControl();
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
            toolStripDropDownButton1.DropDownItems.AddRange(new ToolStripItem[] { createToolStripMenuItem, deleteToolStripMenuItem });
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
            // 
            // btnCreateTable
            // 
            btnCreateTable.Name = "btnCreateTable";
            btnCreateTable.Size = new Size(122, 22);
            btnCreateTable.Text = "Table";
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(180, 22);
            deleteToolStripMenuItem.Text = "Delete";
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
    }
}

namespace DatabaseManager.Forms
{
    partial class CreateNewTable
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            parent = new TableLayoutPanel();
            btnAddNewColumn = new Button();
            ColumnParent = new FlowLayoutPanel();
            label1 = new Label();
            txtBoxTableName = new TextBox();
            btnCreateTable = new Button();
            parent.SuspendLayout();
            SuspendLayout();
            // 
            // parent
            // 
            parent.ColumnCount = 2;
            parent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            parent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            parent.Controls.Add(btnAddNewColumn, 0, 2);
            parent.Controls.Add(ColumnParent, 0, 1);
            parent.Controls.Add(label1, 0, 0);
            parent.Controls.Add(txtBoxTableName, 1, 0);
            parent.Controls.Add(btnCreateTable, 0, 3);
            parent.Dock = DockStyle.Fill;
            parent.Location = new Point(0, 0);
            parent.Name = "parent";
            parent.RowCount = 4;
            parent.RowStyles.Add(new RowStyle(SizeType.Percent, 9.777778F));
            parent.RowStyles.Add(new RowStyle(SizeType.Percent, 70.22222F));
            parent.RowStyles.Add(new RowStyle(SizeType.Percent, 9.777778F));
            parent.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            parent.Size = new Size(800, 450);
            parent.TabIndex = 0;
            // 
            // btnAddNewColumn
            // 
            parent.SetColumnSpan(btnAddNewColumn, 2);
            btnAddNewColumn.Dock = DockStyle.Fill;
            btnAddNewColumn.Location = new Point(3, 363);
            btnAddNewColumn.Name = "btnAddNewColumn";
            btnAddNewColumn.Size = new Size(794, 38);
            btnAddNewColumn.TabIndex = 1;
            btnAddNewColumn.Text = "New Column";
            btnAddNewColumn.UseVisualStyleBackColor = true;
            btnAddNewColumn.Click += btnAddNewColumn_Click;
            // 
            // ColumnParent
            // 
            ColumnParent.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            parent.SetColumnSpan(ColumnParent, 2);
            ColumnParent.Dock = DockStyle.Fill;
            ColumnParent.Location = new Point(3, 47);
            ColumnParent.Name = "ColumnParent";
            ColumnParent.Size = new Size(794, 310);
            ColumnParent.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(394, 44);
            label1.TabIndex = 3;
            label1.Text = "Tablename:";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtBoxTableName
            // 
            txtBoxTableName.Dock = DockStyle.Fill;
            txtBoxTableName.Location = new Point(403, 3);
            txtBoxTableName.Name = "txtBoxTableName";
            txtBoxTableName.Size = new Size(394, 23);
            txtBoxTableName.TabIndex = 4;
            // 
            // btnCreateTable
            // 
            parent.SetColumnSpan(btnCreateTable, 2);
            btnCreateTable.Dock = DockStyle.Fill;
            btnCreateTable.Location = new Point(3, 407);
            btnCreateTable.Name = "btnCreateTable";
            btnCreateTable.Size = new Size(794, 40);
            btnCreateTable.TabIndex = 5;
            btnCreateTable.Text = "Create Table";
            btnCreateTable.UseVisualStyleBackColor = true;
            btnCreateTable.Click += btnCreateTable_Click;
            // 
            // CreateNewTable
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(parent);
            Name = "CreateNewTable";
            Text = "CreateNewTable";
            parent.ResumeLayout(false);
            parent.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel parent;
        private Button btnAddNewColumn;
        private DataGridView dataGridView1;
        private FlowLayoutPanel ColumnParent;
        private Label label1;
        private TextBox txtBoxTableName;
        private Button btnCreateTable;
    }
}
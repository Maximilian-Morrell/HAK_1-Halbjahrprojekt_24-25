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
            btnCreateTable = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            label2 = new Label();
            txtBoxTableName = new TextBox();
            label1 = new Label();
            comboBoxDataBase = new ComboBox();
            parent.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // parent
            // 
            parent.ColumnCount = 2;
            parent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            parent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            parent.Controls.Add(btnAddNewColumn, 0, 2);
            parent.Controls.Add(ColumnParent, 0, 1);
            parent.Controls.Add(btnCreateTable, 0, 3);
            parent.Controls.Add(tableLayoutPanel1, 0, 0);
            parent.Dock = DockStyle.Fill;
            parent.Location = new Point(0, 0);
            parent.Name = "parent";
            parent.RowCount = 4;
            parent.RowStyles.Add(new RowStyle(SizeType.Percent, 14F));
            parent.RowStyles.Add(new RowStyle(SizeType.Percent, 66F));
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
            ColumnParent.Location = new Point(3, 66);
            ColumnParent.Name = "ColumnParent";
            ColumnParent.Size = new Size(794, 291);
            ColumnParent.TabIndex = 2;
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
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            parent.SetColumnSpan(tableLayoutPanel1, 2);
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Controls.Add(txtBoxTableName, 1, 1);
            tableLayoutPanel1.Controls.Add(label1, 0, 1);
            tableLayoutPanel1.Controls.Add(comboBoxDataBase, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(794, 57);
            tableLayoutPanel1.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(391, 28);
            label2.TabIndex = 8;
            label2.Text = "Database:";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtBoxTableName
            // 
            txtBoxTableName.Dock = DockStyle.Fill;
            txtBoxTableName.Location = new Point(400, 31);
            txtBoxTableName.Name = "txtBoxTableName";
            txtBoxTableName.Size = new Size(391, 23);
            txtBoxTableName.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(3, 28);
            label1.Name = "label1";
            label1.Size = new Size(391, 29);
            label1.TabIndex = 5;
            label1.Text = "Tablename:";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // comboBoxDataBase
            // 
            comboBoxDataBase.Dock = DockStyle.Fill;
            comboBoxDataBase.FormattingEnabled = true;
            comboBoxDataBase.Location = new Point(400, 3);
            comboBoxDataBase.Name = "comboBoxDataBase";
            comboBoxDataBase.Size = new Size(391, 23);
            comboBoxDataBase.TabIndex = 9;
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
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel parent;
        private Button btnAddNewColumn;
        private DataGridView dataGridView1;
        private FlowLayoutPanel ColumnParent;
        public Button btnCreateTable;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label2;
        public TextBox txtBoxTableName;
        private Label label1;
        public ComboBox comboBoxDataBase;
    }
}
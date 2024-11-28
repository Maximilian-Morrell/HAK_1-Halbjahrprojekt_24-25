namespace DatabaseManager.Forms
{
    partial class DeleteTable
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
            tableLayoutPanel1 = new TableLayoutPanel();
            comboBoxDataBase = new ComboBox();
            comboBoxTable = new ComboBox();
            btnDeleteTable = new Button();
            label1 = new Label();
            label2 = new Label();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(comboBoxDataBase, 1, 0);
            tableLayoutPanel1.Controls.Add(comboBoxTable, 1, 1);
            tableLayoutPanel1.Controls.Add(btnDeleteTable, 0, 2);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.Size = new Size(585, 88);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // comboBoxDataBase
            // 
            comboBoxDataBase.Dock = DockStyle.Fill;
            comboBoxDataBase.FormattingEnabled = true;
            comboBoxDataBase.Location = new Point(295, 3);
            comboBoxDataBase.Name = "comboBoxDataBase";
            comboBoxDataBase.Size = new Size(287, 23);
            comboBoxDataBase.TabIndex = 0;
            comboBoxDataBase.SelectedIndexChanged += comboBoxDataBase_SelectedIndexChanged;
            // 
            // comboBoxTable
            // 
            comboBoxTable.Dock = DockStyle.Fill;
            comboBoxTable.FormattingEnabled = true;
            comboBoxTable.Location = new Point(295, 32);
            comboBoxTable.Name = "comboBoxTable";
            comboBoxTable.Size = new Size(287, 23);
            comboBoxTable.TabIndex = 1;
            // 
            // btnDeleteTable
            // 
            tableLayoutPanel1.SetColumnSpan(btnDeleteTable, 2);
            btnDeleteTable.Dock = DockStyle.Fill;
            btnDeleteTable.Location = new Point(3, 61);
            btnDeleteTable.Name = "btnDeleteTable";
            btnDeleteTable.Size = new Size(579, 24);
            btnDeleteTable.TabIndex = 2;
            btnDeleteTable.Text = "DeleteTable";
            btnDeleteTable.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(286, 29);
            label1.TabIndex = 3;
            label1.Text = "Database:";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(3, 29);
            label2.Name = "label2";
            label2.Size = new Size(286, 29);
            label2.TabIndex = 4;
            label2.Text = "Table:";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // DeleteTable
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(585, 88);
            Controls.Add(tableLayoutPanel1);
            Name = "DeleteTable";
            Text = "DeleteTable";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        public Button btnDeleteTable;
        public ComboBox comboBoxDataBase;
        public ComboBox comboBoxTable;
        private Button button1;
        private Label label2;
        private Label label1;
    }
}
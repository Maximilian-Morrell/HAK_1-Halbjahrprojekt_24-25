namespace DatabaseManager.Forms
{
    partial class DeleteDB
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
            DataBase = new Label();
            comboBoxDataBase = new ComboBox();
            btnDelete = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 26.5086212F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 73.49138F));
            tableLayoutPanel1.Controls.Add(DataBase, 0, 0);
            tableLayoutPanel1.Controls.Add(comboBoxDataBase, 1, 0);
            tableLayoutPanel1.Controls.Add(btnDelete, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 43.8356171F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 56.1643829F));
            tableLayoutPanel1.Size = new Size(464, 73);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // DataBase
            // 
            DataBase.AutoSize = true;
            DataBase.Dock = DockStyle.Fill;
            DataBase.Location = new Point(3, 0);
            DataBase.Name = "DataBase";
            DataBase.Size = new Size(117, 32);
            DataBase.TabIndex = 0;
            DataBase.Text = "Database:";
            DataBase.TextAlign = ContentAlignment.MiddleRight;
            // 
            // comboBoxDataBase
            // 
            comboBoxDataBase.Dock = DockStyle.Fill;
            comboBoxDataBase.FormattingEnabled = true;
            comboBoxDataBase.Location = new Point(126, 3);
            comboBoxDataBase.Name = "comboBoxDataBase";
            comboBoxDataBase.Size = new Size(335, 23);
            comboBoxDataBase.TabIndex = 1;
            // 
            // btnDelete
            // 
            tableLayoutPanel1.SetColumnSpan(btnDelete, 2);
            btnDelete.Dock = DockStyle.Fill;
            btnDelete.Location = new Point(3, 35);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(458, 35);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // DeleteDB
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(464, 73);
            Controls.Add(tableLayoutPanel1);
            Name = "DeleteDB";
            Text = "DeleteDB";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label DataBase;
        public ComboBox comboBoxDataBase;
        public Button btnDelete;
    }
}
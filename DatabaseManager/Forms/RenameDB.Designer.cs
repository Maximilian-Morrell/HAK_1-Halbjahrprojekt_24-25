namespace DatabaseManager.Forms
{
    partial class RenameDB
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
            label2 = new Label();
            comboBoxDataBase = new ComboBox();
            btnRenameDB = new Button();
            label1 = new Label();
            txtBoxNewName = new TextBox();
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
            tableLayoutPanel1.Controls.Add(btnRenameDB, 0, 2);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(txtBoxNewName, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.Size = new Size(346, 93);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(3, 31);
            label2.Name = "label2";
            label2.Size = new Size(167, 31);
            label2.TabIndex = 4;
            label2.Text = "New Name:";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // comboBoxDataBase
            // 
            comboBoxDataBase.Dock = DockStyle.Fill;
            comboBoxDataBase.FormattingEnabled = true;
            comboBoxDataBase.Location = new Point(176, 3);
            comboBoxDataBase.Name = "comboBoxDataBase";
            comboBoxDataBase.Size = new Size(167, 23);
            comboBoxDataBase.TabIndex = 0;
            // 
            // btnRenameDB
            // 
            tableLayoutPanel1.SetColumnSpan(btnRenameDB, 2);
            btnRenameDB.Dock = DockStyle.Fill;
            btnRenameDB.Location = new Point(3, 65);
            btnRenameDB.Name = "btnRenameDB";
            btnRenameDB.Size = new Size(340, 25);
            btnRenameDB.TabIndex = 2;
            btnRenameDB.Text = "Rename Database";
            btnRenameDB.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(167, 31);
            label1.TabIndex = 3;
            label1.Text = "Database:";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtBoxNewName
            // 
            txtBoxNewName.Dock = DockStyle.Fill;
            txtBoxNewName.Location = new Point(176, 34);
            txtBoxNewName.Name = "txtBoxNewName";
            txtBoxNewName.Size = new Size(167, 23);
            txtBoxNewName.TabIndex = 5;
            // 
            // RenameDB
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(346, 93);
            Controls.Add(tableLayoutPanel1);
            Name = "RenameDB";
            Text = "RenameDB";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label2;
        public ComboBox comboBoxDataBase;
        public Button btnRenameDB;
        private Label label1;
        public TextBox txtBoxNewName;
    }
}
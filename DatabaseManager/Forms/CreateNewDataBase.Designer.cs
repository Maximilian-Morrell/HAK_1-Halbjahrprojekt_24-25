namespace DatabaseManager.Forms
{
    partial class CreateNewDataBase
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
            label1 = new Label();
            txtBoxDBName = new TextBox();
            btnCreateDB = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(txtBoxDBName, 1, 0);
            tableLayoutPanel1.Controls.Add(btnCreateDB, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 79.48718F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20.5128212F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            tableLayoutPanel1.Size = new Size(275, 71);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(131, 31);
            label1.TabIndex = 0;
            label1.Text = "Name:";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtBoxDBName
            // 
            txtBoxDBName.Dock = DockStyle.Fill;
            txtBoxDBName.Location = new Point(140, 3);
            txtBoxDBName.Name = "txtBoxDBName";
            txtBoxDBName.Size = new Size(132, 23);
            txtBoxDBName.TabIndex = 1;
            // 
            // btnCreateDB
            // 
            tableLayoutPanel1.SetColumnSpan(btnCreateDB, 2);
            btnCreateDB.Dock = DockStyle.Fill;
            btnCreateDB.Location = new Point(3, 42);
            btnCreateDB.Name = "btnCreateDB";
            btnCreateDB.Size = new Size(269, 26);
            btnCreateDB.TabIndex = 2;
            btnCreateDB.Text = "Create";
            btnCreateDB.UseVisualStyleBackColor = true;
            // 
            // CreateNewDataBase
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(275, 71);
            Controls.Add(tableLayoutPanel1);
            Name = "CreateNewDataBase";
            Text = "CreateNewDataBase";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        public TextBox txtBoxDBName;
        public Button btnCreateDB;
    }
}
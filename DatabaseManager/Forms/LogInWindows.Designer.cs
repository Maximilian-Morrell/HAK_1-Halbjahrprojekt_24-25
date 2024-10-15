namespace DatabaseManager
{
    partial class LogInWindows
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
            Layout = new TableLayoutPanel();
            lblLogIn = new Label();
            groupBox1 = new GroupBox();
            txtBoxIPAdress = new TextBox();
            groupBox2 = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            lblUsername = new Label();
            lblPassword = new Label();
            txtBoxUsername = new TextBox();
            txtBoxPassword = new TextBox();
            checkSSIS = new CheckBox();
            lblSSIS = new Label();
            btnLogIn = new Button();
            Layout.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // Layout
            // 
            Layout.ColumnCount = 1;
            Layout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            Layout.Controls.Add(lblLogIn, 0, 0);
            Layout.Controls.Add(groupBox1, 0, 1);
            Layout.Controls.Add(groupBox2, 0, 2);
            Layout.Controls.Add(btnLogIn, 0, 3);
            Layout.Dock = DockStyle.Fill;
            Layout.Location = new Point(0, 0);
            Layout.Name = "Layout";
            Layout.RowCount = 4;
            Layout.RowStyles.Add(new RowStyle(SizeType.Percent, 22F));
            Layout.RowStyles.Add(new RowStyle(SizeType.Percent, 20.4F));
            Layout.RowStyles.Add(new RowStyle(SizeType.Percent, 42F));
            Layout.RowStyles.Add(new RowStyle(SizeType.Percent, 16.4F));
            Layout.Size = new Size(250, 274);
            Layout.TabIndex = 0;
            // 
            // lblLogIn
            // 
            lblLogIn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblLogIn.AutoSize = true;
            lblLogIn.Font = new Font("Segoe UI", 30F);
            lblLogIn.Location = new Point(3, 0);
            lblLogIn.Name = "lblLogIn";
            lblLogIn.Size = new Size(244, 59);
            lblLogIn.TabIndex = 0;
            lblLogIn.Text = "Log In";
            lblLogIn.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtBoxIPAdress);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(3, 62);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(244, 49);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "IP Adress";
            // 
            // txtBoxIPAdress
            // 
            txtBoxIPAdress.Dock = DockStyle.Fill;
            txtBoxIPAdress.Location = new Point(3, 19);
            txtBoxIPAdress.Name = "txtBoxIPAdress";
            txtBoxIPAdress.Size = new Size(238, 23);
            txtBoxIPAdress.TabIndex = 0;
            txtBoxIPAdress.Text = "(localdb)\\MSSQLLocalDB";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(tableLayoutPanel1);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(3, 117);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(244, 108);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Credentials";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30.2521F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 69.7479F));
            tableLayoutPanel1.Controls.Add(lblUsername, 0, 0);
            tableLayoutPanel1.Controls.Add(lblPassword, 0, 1);
            tableLayoutPanel1.Controls.Add(txtBoxUsername, 1, 0);
            tableLayoutPanel1.Controls.Add(txtBoxPassword, 1, 1);
            tableLayoutPanel1.Controls.Add(checkSSIS, 1, 2);
            tableLayoutPanel1.Controls.Add(lblSSIS, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 19);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(238, 86);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Dock = DockStyle.Fill;
            lblUsername.Enabled = false;
            lblUsername.Location = new Point(3, 0);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(66, 28);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Username";
            lblUsername.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Dock = DockStyle.Fill;
            lblPassword.Enabled = false;
            lblPassword.Location = new Point(3, 28);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(66, 28);
            lblPassword.TabIndex = 1;
            lblPassword.Text = "Password";
            lblPassword.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtBoxUsername
            // 
            txtBoxUsername.Dock = DockStyle.Fill;
            txtBoxUsername.Enabled = false;
            txtBoxUsername.Location = new Point(75, 3);
            txtBoxUsername.Name = "txtBoxUsername";
            txtBoxUsername.Size = new Size(160, 23);
            txtBoxUsername.TabIndex = 3;
            // 
            // txtBoxPassword
            // 
            txtBoxPassword.Dock = DockStyle.Fill;
            txtBoxPassword.Enabled = false;
            txtBoxPassword.Location = new Point(75, 31);
            txtBoxPassword.Name = "txtBoxPassword";
            txtBoxPassword.PasswordChar = '*';
            txtBoxPassword.Size = new Size(160, 23);
            txtBoxPassword.TabIndex = 4;
            txtBoxPassword.UseSystemPasswordChar = true;
            // 
            // checkSSIS
            // 
            checkSSIS.AutoSize = true;
            checkSSIS.Checked = true;
            checkSSIS.CheckState = CheckState.Checked;
            checkSSIS.Dock = DockStyle.Fill;
            checkSSIS.Location = new Point(75, 59);
            checkSSIS.Name = "checkSSIS";
            checkSSIS.RightToLeft = RightToLeft.No;
            checkSSIS.Size = new Size(160, 24);
            checkSSIS.TabIndex = 5;
            checkSSIS.TextAlign = ContentAlignment.MiddleCenter;
            checkSSIS.UseVisualStyleBackColor = true;
            checkSSIS.CheckedChanged += checkSSIS_CheckedChanged;
            // 
            // lblSSIS
            // 
            lblSSIS.AutoSize = true;
            lblSSIS.Dock = DockStyle.Fill;
            lblSSIS.Location = new Point(3, 56);
            lblSSIS.Name = "lblSSIS";
            lblSSIS.Size = new Size(66, 30);
            lblSSIS.TabIndex = 6;
            lblSSIS.Text = "SSIS";
            lblSSIS.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnLogIn
            // 
            btnLogIn.Dock = DockStyle.Fill;
            btnLogIn.Location = new Point(3, 231);
            btnLogIn.Name = "btnLogIn";
            btnLogIn.Size = new Size(244, 40);
            btnLogIn.TabIndex = 4;
            btnLogIn.Text = "Log In";
            btnLogIn.UseVisualStyleBackColor = true;
            // 
            // LogInWindows
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(250, 274);
            Controls.Add(Layout);
            Name = "LogInWindows";
            Text = "LogInWindows";
            Layout.ResumeLayout(false);
            Layout.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel Layout;
        private Label lblLogIn;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TableLayoutPanel tableLayoutPanel1;
        public TextBox txtBoxIPAdress;
        public Label lblUsername;
        public Label lblPassword;
        public TextBox txtBoxUsername;
        public TextBox txtBoxPassword;
        public CheckBox checkSSIS;
        public Label lblSSIS;
        public Button btnLogIn;
    }
}
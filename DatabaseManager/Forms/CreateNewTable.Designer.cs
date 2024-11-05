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
            parent.Dock = DockStyle.Fill;
            parent.Location = new Point(0, 0);
            parent.Name = "parent";
            parent.RowCount = 4;
            parent.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            parent.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            parent.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            parent.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            parent.Size = new Size(800, 450);
            parent.TabIndex = 0;
            // 
            // btnAddNewColumn
            // 
            parent.SetColumnSpan(btnAddNewColumn, 2);
            btnAddNewColumn.Dock = DockStyle.Fill;
            btnAddNewColumn.Location = new Point(3, 227);
            btnAddNewColumn.Name = "btnAddNewColumn";
            btnAddNewColumn.Size = new Size(794, 106);
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
            ColumnParent.Location = new Point(3, 115);
            ColumnParent.Name = "ColumnParent";
            ColumnParent.Size = new Size(794, 106);
            ColumnParent.TabIndex = 2;
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
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel parent;
        private Button btnAddNewColumn;
        private DataGridView dataGridView1;
        private FlowLayoutPanel ColumnParent;
    }
}
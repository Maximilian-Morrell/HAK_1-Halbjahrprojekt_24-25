using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseManager.Forms
{
    public partial class CreateNewTable : Form
    {
        List<TableLayoutPanel> tableLayoutPanels = new List<TableLayoutPanel>();
        string[] datatypes = Enum.GetNames<SqlDbType>();

        public CreateNewTable()
        {
            InitializeComponent();
            // 
            ColumnParent.MaximumSize = new Size(this.Width, ColumnParent.Height);

        }

        private void btnAddNewColumn_Click(object sender, EventArgs e)
        {
            CreateNewColumn();
        }

        private void CreateNewColumn()
        {
            int ColumnWidth = this.Width - 60;
            TableLayoutPanel tableLayoutPanel = new TableLayoutPanel();
            tableLayoutPanel.ColumnCount = 3;
            tableLayoutPanel.RowCount = 2;
            tableLayoutPanel.Width = this.Width;

            Label lblName = new Label();
            lblName.Text = "Column Name:";
            lblName.Width = ColumnWidth / 3;
            tableLayoutPanel.Controls.Add(lblName, 0, 0);

            Label lblIsNull = new Label();
            lblIsNull.Text = "Can be Null:";
            lblIsNull.Width = ColumnWidth / 3;
            tableLayoutPanel.Controls.Add(lblIsNull, 1, 0);

            Label lblType = new Label();
            lblType.Text = "Type:";
            lblType.Width = ColumnWidth / 3;
            tableLayoutPanel.Controls.Add(lblType, 2, 0);

            TextBox txtBoxName = new TextBox();
            txtBoxName.PlaceholderText = "Name";
            txtBoxName.Width = ColumnWidth / 3;
            tableLayoutPanel.Controls.Add(txtBoxName, 0, 1);

            CheckBox checkBoxIsNull = new CheckBox();
            checkBoxIsNull.Width = ColumnWidth / 3;
            tableLayoutPanel.Controls.Add(checkBoxIsNull, 1, 1);

            ComboBox comboBoxDataType = new ComboBox();
            comboBoxDataType.Width = ColumnWidth / 3;
            foreach(string DataType in datatypes)
            {
                comboBoxDataType.Items.Add(DataType);
            }
            tableLayoutPanel.Controls.Add(comboBoxDataType, 2, 1);
            ColumnParent.Controls.Add(tableLayoutPanel);
        }
    }
}

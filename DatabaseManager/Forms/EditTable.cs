using DatabaseManager.Classes;
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
    public partial class EditTable : Form
    {
        public List<TableLayoutPanel> tableLayoutPanels = new List<TableLayoutPanel>();
        string[] datatypes = Enum.GetNames<SqlDbType>();
        Dictionary<string, List<TableObject>> DB_Tables;
        TableObject table;

        public EditTable()
        {
            InitializeComponent();
        }

        public EditTable(Dictionary<string, List<TableObject>> Database_Tables)
        {
            InitializeComponent();
            ColumnParent.AutoScroll = true;
            DB_Tables = Database_Tables;
            foreach (string database in Database_Tables.Keys)
            {
                comboBoxDataBase.Items.Add(database);
            }
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
            tableLayoutPanel.Width = this.Width - 30;

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
            foreach (string DataType in datatypes)
            {
                comboBoxDataType.Items.Add(DataType);
            }

            tableLayoutPanel.Controls.Add(comboBoxDataType, 2, 1);
            ColumnParent.Controls.Add(tableLayoutPanel);
            tableLayoutPanels.Add(tableLayoutPanel);
        }

        private void CreateNewColumn(RowObject rowObject)
        {
            int ColumnWidth = this.Width - 60;
            TableLayoutPanel tableLayoutPanel = new TableLayoutPanel();
            tableLayoutPanel.ColumnCount = 3;
            tableLayoutPanel.RowCount = 2;
            tableLayoutPanel.Width = this.Width - 30;

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
            txtBoxName.Text = rowObject.Name;
            tableLayoutPanel.Controls.Add(txtBoxName, 0, 1);

            CheckBox checkBoxIsNull = new CheckBox();
            checkBoxIsNull.Width = ColumnWidth / 3;
            checkBoxIsNull.Checked = rowObject.CanBeNull;
            tableLayoutPanel.Controls.Add(checkBoxIsNull, 1, 1);

            ComboBox comboBoxDataType = new ComboBox();
            comboBoxDataType.Width = ColumnWidth / 3;
            foreach (string DataType in datatypes)
            {
                comboBoxDataType.Items.Add(DataType);
            }
            comboBoxDataType.SelectedItem = rowObject.Type;

            tableLayoutPanel.Controls.Add(comboBoxDataType, 2, 1);
            ColumnParent.Controls.Add(tableLayoutPanel);
            tableLayoutPanels.Add(tableLayoutPanel);
        }

        private void CreateIDColumn(RowObject rowObject)
        {
            int ColumnWidth = this.Width - 60;
            TableLayoutPanel tableLayoutPanel = new TableLayoutPanel();
            tableLayoutPanel.ColumnCount = 3;
            tableLayoutPanel.RowCount = 2;
            tableLayoutPanel.Width = this.Width - 30;

            Label lblName = new Label();
            lblName.Text = "ID Column Name:";
            lblName.Width = ColumnWidth / 3;
            tableLayoutPanel.Controls.Add(lblName, 0, 0);

            Label lblIsNull = new Label();
            lblIsNull.Text = "Can be Null:";
            lblIsNull.Width = ColumnWidth / 3;
            lblIsNull.Hide();
            tableLayoutPanel.Controls.Add(lblIsNull, 1, 0);

            Label lblType = new Label();
            lblType.Text = "Type:";
            lblType.Width = ColumnWidth / 3;
            lblType.Hide();
            tableLayoutPanel.Controls.Add(lblType, 2, 0);

            TextBox txtBoxName = new TextBox();
            txtBoxName.PlaceholderText = "Name";
            txtBoxName.Width = ColumnWidth / 3;
            txtBoxName.Text = rowObject.Name;
            tableLayoutPanel.Controls.Add(txtBoxName, 0, 1);

            CheckBox checkBoxIsNull = new CheckBox();
            checkBoxIsNull.Width = ColumnWidth / 3;
            checkBoxIsNull.Hide();
            tableLayoutPanel.Controls.Add(checkBoxIsNull, 1, 1);

            ComboBox comboBoxDataType = new ComboBox();
            comboBoxDataType.Width = ColumnWidth / 3;
            comboBoxDataType.SelectedItem = "Int";
            comboBoxDataType.Hide();
            foreach (string DataType in datatypes)
            {
                comboBoxDataType.Items.Add(DataType);
            }
            tableLayoutPanel.Controls.Add(comboBoxDataType, 2, 1);
            ColumnParent.Controls.Add(tableLayoutPanel);
            tableLayoutPanels.Add(tableLayoutPanel);
        }

        private void comboBoxTableName_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Database = comboBoxDataBase.SelectedItem.ToString();
            int SelectIndex = comboBoxTableName.SelectedIndex;
            TableObject table_obj = DB_Tables[Database][SelectIndex];
            int ID = 0;
            foreach(RowObject rowObj in table_obj.Rows)
            {
                if(ID == 0)
                {
                    CreateIDColumn(rowObj);
                }
                else
                {
                    CreateNewColumn(rowObj);
                }
                ID++;
            }
        }

        private void comboBoxDataBase_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxTableName.Items.Clear();
            if (comboBoxDataBase.SelectedIndex != -1)
            {
                string Database = comboBoxDataBase.SelectedItem.ToString();
                foreach (TableObject Table in DB_Tables[Database])
                {
                    comboBoxTableName.Items.Add(Table.Name);
                }
            }
        }
    }
}

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
    public partial class DeleteTable : Form
    {
        List<string> DataBases;
        SQLController SQLController;
        public DeleteTable()
        {
            InitializeComponent();
        }
        public DeleteTable(List<string> DataBases, SQLController sQLController)
        {
            InitializeComponent();
            foreach (string Database in DataBases)
            {
                comboBoxDataBase.Items.Add(Database);
            }
            SQLController = sQLController;
        }

        private void comboBoxDataBase_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateTables();
        }

        public void UpdateTables()
        {
            List<string> Tables = SQLController.GetTables(comboBoxDataBase.SelectedItem as String);
            comboBoxTable.Items.Clear();
            foreach (string Database in Tables)
            {
                comboBoxTable.Items.Add(Database);
            }
            comboBoxTable.SelectedText = "";
        }
    }
}

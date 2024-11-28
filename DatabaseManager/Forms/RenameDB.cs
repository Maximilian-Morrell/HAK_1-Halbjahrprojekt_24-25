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
    public partial class RenameDB : Form
    {
        public RenameDB()
        {
            InitializeComponent();
        }

        public RenameDB(List<string> DBs)
        {
            InitializeComponent();
            UpdateDBs(DBs);
        }

        public void UpdateDBs(List<string> DBs)
        {
            comboBoxDataBase.Items.Clear();
            foreach(string DB in DBs)
            {
                comboBoxDataBase.Items.Add(DB);
            }
        }
    }
}

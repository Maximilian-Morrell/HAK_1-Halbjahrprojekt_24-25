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

        }

        private void btnAddNewColumn_Click(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseManager
{
    public partial class LogInWindows : Form
    {
        public LogInWindows()
        {
            InitializeComponent();
        }

        private void checkSSIS_CheckedChanged(object sender, EventArgs e)
        {
            lblUsername.Enabled = !checkSSIS.Checked;
            lblPassword.Enabled = !checkSSIS.Checked;
            txtBoxUsername.Enabled = !checkSSIS.Checked;
            txtBoxPassword.Enabled = !checkSSIS.Checked;
        }
    }
}

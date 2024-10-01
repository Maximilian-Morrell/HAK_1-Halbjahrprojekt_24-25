using Microsoft.Data.SqlClient;

namespace DatabaseManager
{
    public partial class Form1 : Form
    {
        SqlConnection con = null;
        public Form1()
        {
            InitializeComponent();
            con = LogInScreen();
            this.WindowState = FormWindowState.Minimized;
        }

        private SqlConnection LogInScreen()
        {
            LogInWindows LogIn = new LogInWindows();
            LogIn.Show();
            return new SqlConnection();
        }
    }
}

using Microsoft.Data.SqlClient;

namespace DatabaseManager
{
    public partial class Form1 : Form
    {
        SqlConnection con = null;
        LogInWindows LogInScreen = new LogInWindows();
        public Form1()
        {
            InitializeComponent();
            LogInScreen.Show();
            LogInScreen.Click += LogInScreen_Click;
            this.WindowState = FormWindowState.Minimized;
        }

        private void LogInScreen_Click(object? sender, EventArgs e)
        {
            try
            {
                if (LogInScreen.checkSSIS.Checked)
                {
                    con = new SqlConnection($"Server = '{LogInScreen.txtBoxIPAdress}'; Integrated Security=true;");
                    con.Open();
                    con.Close();
                }
                else
                {
                    con = new SqlConnection($"Server = '{LogInScreen.txtBoxIPAdress}'; UID = '{LogInScreen.txtBoxUsername}'; PWD = '{LogInScreen.txtBoxPassword}';");
                    con.Open();
                    con.Close();
                }

                MessageBox.Show("Successfully connected to: ", LogInScreen.txtBoxIPAdress.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

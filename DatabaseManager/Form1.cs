using DatabaseManager.Classes;
using Microsoft.Data.SqlClient;

namespace DatabaseManager
{
    public partial class Form1 : Form
    {
        SQLController SqlController;
        LogInWindows LogInScreen = new LogInWindows();
        List<string> Databases = new List<string>();
        readonly string[] HiddenDBs = {"master", "tempdb", "model", "msdb" };
        public Form1()
        {
            InitializeComponent();
            LogInScreen.Show();
            LogInScreen.btnLogIn.Click += LogInScreen_Click;
            this.WindowState = FormWindowState.Minimized;
        }

        private void LogInScreen_Click(object? sender, EventArgs e)
        {
            if (LogInScreen.checkSSIS.Checked)
            {
                SqlController = new SQLController($"Server = {LogInScreen.txtBoxIPAdress.Text}; Integrated Security=true;");
            }
            else
            {
                SqlController = new SQLController($"Server = '{LogInScreen.txtBoxIPAdress.Text}'; UID = '{LogInScreen.txtBoxUsername.Text}'; PWD = '{LogInScreen.txtBoxPassword.Text}';");
            }

            MessageBox.Show("Successfully connected to: " + LogInScreen.txtBoxIPAdress.Text, "Successfully Connected");
            LogInScreen.Close();
            WindowState = FormWindowState.Normal;
            Databases = SqlController.GetDatabases();

            foreach(string db in HiddenDBs)
            {
                Databases.Remove(db);
            }

            foreach(string database in Databases)
            {
                TabPage tabPage = new TabPage();
                tabPage.Text = database;
                
                TableLayoutPanel MainLayoutPanel = new TableLayoutPanel();
                MainLayoutPanel.ColumnCount = 2;
                MainLayoutPanel.RowCount = 1;

                ListView listview = new ListView();
                List<string> Tables = SqlController.GetTables(database);
                foreach(string Table in Tables)
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = Table;
                    lvi.Name = database + "_" + Table;
                    listview.Items.Add(lvi);
                }
                listview.ItemSelectionChanged += Listview_ItemSelectionChanged;

                MainLayoutPanel.Controls.Add(listview, 0, 0);

                DataGridView dataGridView = new DataGridView();
                MainLayoutPanel.Controls.Add(dataGridView, 1, 0);

                tabPage.Controls.Add(MainLayoutPanel);
                TabHost.TabPages.Add(tabPage);
            }
        }

        private void Listview_ItemSelectionChanged(object? sender, ListViewItemSelectionChangedEventArgs e)
        {
            string Itemname = e.Item.Name.ToString();
            string[] DBName = Itemname.Split("_");

            foreach( string DB in DBName)
            {
                MessageBox.Show(DB);
            }
        }
    }
}

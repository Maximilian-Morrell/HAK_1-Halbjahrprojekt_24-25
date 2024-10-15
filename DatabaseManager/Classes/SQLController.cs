using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseManager.Classes
{
    public class SQLController
    {
        private SqlConnection Con;
        private SqlCommand Cmd;
        private SqlDataReader Reader;

        public SQLController(string ConnectionString)
        {
            Con = new SqlConnection(ConnectionString);
            Cmd = new SqlCommand("", Con);
        }

        public List<string> GetDatabases()
        {
            List<string> list = new List<string>();
            try
            {
                Con.Open();
                Cmd.CommandText = "SELECT name FROM sys.databases";
                Reader = Cmd.ExecuteReader();
                while(Reader.Read())
                {
                    list.Add(Reader.GetString(0));
                }
                Con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            return list;
        }

        public List<string> GetTables(string DBName)
        {
            List<string> list = new List<string>();
            try
            {
                Con.Open();
                Con.ChangeDatabase(DBName);
                Cmd.CommandText = "SELECT * FROM sys.Tables";
                Reader = Cmd.ExecuteReader();
                while(Reader.Read())
                {
                    list.Add(Reader.GetString(0));
                }
                Con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return list;
        }

        public DataTable GetTableContent(string DB, string Table)
        {
            DataTable dt = new DataTable();
            try
            {
                Con.Open();
                Con.ChangeDatabase(DB);
                Cmd.CommandText = $"SELECT * FROM {Table}";
                Reader = Cmd.ExecuteReader();
                dt.Load(Reader);
                Con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return dt;
        }
    }
}

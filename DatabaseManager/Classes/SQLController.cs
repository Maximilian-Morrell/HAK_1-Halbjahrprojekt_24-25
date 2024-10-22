using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
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

        public SqlDataAdapter GetTableContent(string DB, string Table)
        {
            SqlDataAdapter DA = new SqlDataAdapter();
            try
            {
                Con.Open();
                Con.ChangeDatabase(DB);
                SqlCommand SELECTCmd = new SqlCommand($"SELECT * FROM {Table}", Con);
                SqlCommand INSERTCmd = new SqlCommand($"INSERT INTO {Table} VALUES (")

                /*
                Con.Open();
                Con.ChangeDatabase(DB);
                Cmd.CommandText = $"SELECT * FROM {Table}";
                Reader = Cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(Reader);
                DA.SelectCommand = Cmd;
                DA.Fill(dt);
                Con.Close();
                */

                Con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return DA;
        }

        public void UpdateOldRow(DataGridViewCellCollection cells, string DB, string Table)
        {
            string SQLCommandString = $"UPDATE {Table} SET";
            foreach (DataGridViewCell cell in cells)
            {
                if (cell.ColumnIndex != 0)
                {
                    if(cell.Value.ToString() != string.Empty)
                    {
                        if (cell.ColumnIndex == 1)
                        {
                            SQLCommandString = SQLCommandString + $" {cell.OwningColumn.Name} = '{cell.Value}'";
                        }
                        else
                        {
                            SQLCommandString = SQLCommandString + $", {cell.OwningColumn.Name} = '{cell.Value}'";
                        }
                    }
                }
            }

            SQLCommandString = SQLCommandString + $" WHERE {cells[0].OwningColumn.Name} = {cells[0].Value}";

            try
            {
                Con.Open();
                Con.ChangeDatabase(DB);
                Cmd.CommandText = SQLCommandString;
                Cmd.ExecuteNonQuery();
                Con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void AddNewRows(DataGridViewRow Row , string DB, string Table)
        {
            DataGridViewCellCollection cells = Row.Cells;

            string SQLCommandString = $"INSERT INTO {Table} VALUES (";

            foreach (DataGridViewCell cell in cells)
            {
                if (cell.ColumnIndex != 0)
                {
                    if (cell.Value.ToString() != string.Empty)
                    {
                        if (cell.ColumnIndex == 1)
                        {
                            SQLCommandString = SQLCommandString + $"'{cell.Value}'";
                        }
                        else
                        {
                            SQLCommandString = SQLCommandString + $", '{cell.Value}'";
                        }
                    }
                }
            }

            SQLCommandString = SQLCommandString + ")";

            try
            {
                Con.Open();
                Con.ChangeDatabase(DB);
                Cmd.CommandText = SQLCommandString;
                Cmd.ExecuteNonQuery();
                Con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void AddNewRow(SqlDataAdapter DA)
        {
            try
            {
                Cmd = DA.InsertCommand;
                Cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {

            }
        }

        public void UpdateOldRowToDB(SqlDataAdapter DA)
        {
           // Cmd.CommandText = DA.InsertCommand.CommandText;
            Cmd.ExecuteNonQuery();
        }
    }
}

// SQL Data Adapter
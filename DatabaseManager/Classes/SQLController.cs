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
        SqlDataAdapter DA = new SqlDataAdapter();

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
                DA.SelectCommand = Cmd;
                Reader = Cmd.ExecuteReader();
                dt.Load(Reader);
                SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(DA);
                DA.InsertCommand = cmdBuilder.GetInsertCommand();
                DA.UpdateCommand = cmdBuilder.GetUpdateCommand();
                DA.DeleteCommand = cmdBuilder.GetDeleteCommand();


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
            return dt;
        }

        public void UpdateOldRow(DataTable cells, string DB, string Table)
        {
            /*
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
            */
        }

        public void AddNewRows(DataTable Row, string DB, string Table)
        {
            try
            {
                Con.Open();
                Con.ChangeDatabase(DB);
                int zahl = DA.Update(Row);
                int Zahl2 = zahl + zahl;
                Con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void AddNewTable(TableObject Table)
        {
            try
            {
                Con.Open();
                Con.ChangeDatabase(Table.Database);
                string Cmdtxt = $"CREATE TABLE {Table.Name} ({Table.Rows[0].Name} Int NOT NULL PRIMARY KEY IDENTITY, ";
                Table.Rows.RemoveAt(0);
                foreach(RowObject Row in Table.Rows)
                {
                    if(Row.CanBeNull)
                    {
                        Cmdtxt = Cmdtxt + Row.Name + " " + Row.Type + ", ";
                    }
                    else
                    {
                        Cmdtxt = Cmdtxt + Row.Name + " " + Row.Type + " NOT NULL" + ", ";
                    }
                }
                Cmdtxt = Cmdtxt.Remove(Cmdtxt.Length - 2);
                Cmdtxt = Cmdtxt + ")";
                Cmd.CommandText = Cmdtxt;
                Cmd.ExecuteNonQuery();
                Con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void CreateNewDB(string DBName)
        {
            try
            {
                Con.Open();
                Cmd.CommandText = $"CREATE DATABASE {DBName}";
                Cmd.ExecuteNonQuery();
                Con.Close();
            }
            catch (Exception e)
            {

            }
        }

        public void DeleteDB(string DBName)
        {
            try
            {
                Con.Open();
                Cmd.CommandText = $"DROP DATABASE {DBName}";
                Cmd.ExecuteNonQuery();
                Con.Close();
            }
            catch (Exception e)
            {

            }
        }
    }
}

// SQL Data Adapter
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseManager.Classes
{
    public class TableObject
    {
        private string _Name;
        private string _Database;
        private List<RowObject> _Rows;

        public string Name
        {
            get
            {
                return _Name;
            }
            set
            {
                _Name = value;
            }
        }

        public string Database
        {
            get
            {
                return _Database;
            }
            set
            {
                _Database = value;
            }
        }

        public List<RowObject> Rows
        {
            get
            {
                return _Rows;
            }
            set
            {
                _Rows = value;
            }
        }

        public TableObject(string Name, string Database)
        {
            this.Name = Name;
            this.Rows = new List<RowObject>();
            this.Database = Database;
        }
    }
}

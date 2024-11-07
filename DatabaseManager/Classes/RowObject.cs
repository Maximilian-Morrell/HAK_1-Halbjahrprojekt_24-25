using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseManager.Classes
{
    public class RowObject
    {
        private string _Name;
        private bool _CanBeNull;
        private string _Type;

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

        public bool CanBeNull
        {
            get
            {
                return _CanBeNull;
            }
            set
            {
                _CanBeNull = value;
            }
        }

        public string Type
        {
            get
            {
                return _Type;
            }
            set
            {
                _Type = value;
            }
        }

        public RowObject(string Name, bool  CanBeNull, string Type)
        {
            this.Name = Name;
            this.CanBeNull = CanBeNull;
            this.Type = Type;
        }
    }
}

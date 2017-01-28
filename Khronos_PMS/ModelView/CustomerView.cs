using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Khronos_PMS.ModelView
{
    class CustomerView : IEquatable<CustomerView>
    {
        private String _Username;
        private int _ID;
        private String _Name;

        public String Username
        {
            get { return _Username; }
            set { _Username = value; }
        }

        public String Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }

        public CustomerView(int id, string username, string name)
        {
            _ID = id;
            _Username = username;
            _Name = name;
        }

        public bool Equals(CustomerView other)
        {
            return _ID == other.ID;
        }
    }
}

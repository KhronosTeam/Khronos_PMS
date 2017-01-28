using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Khronos_PMS.ModelView
{
    class WorkerView : IEquatable<CustomerView>
    {
        private string _Username;
        private int _ID;

        public string Username {
            get { return _Username; }
            set { _Username = value; }
        }

        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }

        public WorkerView(int id, string username) {
            _ID = id;
            _Username = username;
        }

        public bool Equals(CustomerView other)
        {
            return _ID == other.ID;
        }
    }
}

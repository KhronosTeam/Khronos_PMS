using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Khronos_PMS.Model {
    public partial class Worker {
        public String FullName {
            get { return FirstName + " " + LastName; }
        }

        public String FullNameWithUsername {
            get { return FirstName + " " + LastName + " (" + User.Username + ")"; }
        }
    }
}
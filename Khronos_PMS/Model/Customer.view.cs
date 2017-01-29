using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Khronos_PMS.Model {
    public partial class Customer : User {
        public override String GetName() {
            return Name;
        }
    }
}
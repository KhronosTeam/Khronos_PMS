using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Khronos_PMS.Model {
    public partial class Activity {
        public String GetFullName() {
            return WorksOn.AssignedTo.Worker.FullName;
        }

        public String GetDate() {
            return Date.ToShortDateString();
        }

        public String Info => WorksOn.AssignedTo.Worker.FullName + "   (" + Date.ToShortDateString() + ")";
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Khronos_PMS.Util {
    static class Role {
        public static readonly String BOSS = "Boss";
        public static readonly String WORKER = "Worker";
        public static readonly String SUPERVISOR = "Supervisor";
        public static readonly String CUSTOMER = "Customer";
    }
}

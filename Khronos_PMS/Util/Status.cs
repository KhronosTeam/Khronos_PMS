using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Khronos_PMS.Properties;

namespace Khronos_PMS.Util {
    static class Status {
        public static int ACTIVE = 0;
        public static int IN_PROGRESS = 1;
        public static int PAUSED = 2;
        public static int COMPLETED = 3;

        public static Bitmap Image(int status) {
            switch (status) {
                case 0:
                    return Resources.status_active;
                case 1:
                    return Resources.status_in_progress;
                case 2:
                    return Resources.status_paused;
                case 3:
                    return Resources.status_completed;
                default:
                    throw new Exception("Invalid status!");
            }
        }

        public static String Name(int status) {
            switch (status) {
                case 0:
                    return "Active";
                case 1:
                    return "In progress";
                case 2:
                    return "Paused";
                case 3:
                    return "Completed";
                default:
                    throw new Exception("Invalid priority!");
            }
        }
    }
}

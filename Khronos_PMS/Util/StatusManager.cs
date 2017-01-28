using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Khronos_PMS.Model;
using Khronos_PMS.Properties;

namespace Khronos_PMS.Util {
    public enum Status {
        ACTIVE = 0,
        IN_PROGRESS = 1,
        PAUSED = 2,
        COMPLETED = 3,
    }

    public static class StatusManager {

        public static Bitmap Image(Status status) {
            switch (status) {
                case Status.ACTIVE:
                    return Resources.status_active;
                case Status.IN_PROGRESS:
                    return Resources.status_in_progress;
                case Status.PAUSED:
                    return Resources.status_paused;
                case Status.COMPLETED:
                    return Resources.status_completed;
                default:
                    throw new Exception("Invalid status!");
            }
        }

        public static String Name(Status status) {
            switch (status) {
                case Status.ACTIVE:
                    return "Active";
                case Status.IN_PROGRESS:
                    return "In progress";
                case Status.PAUSED:
                    return "Paused";
                case Status.COMPLETED:
                    return "Completed";
                default:
                    throw new Exception("Invalid priority!");
            }
        }

        public static void SaveStatus(Project project, Status status) {
            //todo sačuvati u bazu status
        }

        public static void SaveStatus(Unit unit, Status status) {
            //todo sačuvati u bazu status
        }
    }
}
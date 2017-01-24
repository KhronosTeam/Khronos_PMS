using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Khronos_PMS.Properties;

namespace Khronos_PMS.Util {
    static class Priority {
        public static int NONE = 0;
        public static int VERY_LOW = 1;
        public static int LOW = 2;
        public static int MEDIUM = 3;
        public static int HIGH = 4;
        public static int VERY_HIGH = 5;

        public static Bitmap Image(int priority) {
            switch (priority) {
                case 0:
                    return Resources.priority_none;
                case 1:
                    return Resources.priority_very_low;
                case 2:
                    return Resources.priority_low;
                case 3:
                    return Resources.priority_medium;
                case 4:
                    return Resources.priority_high;
                case 5:
                    return Resources.priority_very_high;
                default:
                    throw new Exception("Invalid priority!");
            }
        }

        public static String Name(int priority) {
            switch (priority) {
                case 0:
                    return "None";
                case 1:
                    return "Very low";
                case 2:
                    return "Low";
                case 3:
                    return "Medium";
                case 4:
                    return "High";
                case 5:
                    return "Very high";
                default:
                    throw new Exception("Invalid priority!");
            }
        }

    }
}

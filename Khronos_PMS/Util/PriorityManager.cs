using System;
using System.Drawing;
using Khronos_PMS.Model;
using Khronos_PMS.Properties;

namespace Khronos_PMS.Util {
    public enum Priority {
        NONE,
        VERY_LOW,
        LOW,
        MEDIUM,
        HIGH,
        VERY_HIGH
    }


    public static class PriorityManager {
        public static Bitmap Image(Priority priority) {
            switch (priority) {
                case Priority.NONE:
                    return Resources.priority_none;
                case Priority.VERY_LOW:
                    return Resources.priority_very_low;
                case Priority.LOW:
                    return Resources.priority_low;
                case Priority.MEDIUM:
                    return Resources.priority_medium;
                case Priority.HIGH:
                    return Resources.priority_high;
                case Priority.VERY_HIGH:
                    return Resources.priority_very_high;
                default:
                    throw new Exception("Invalid priority!");
            }
        }

        public static String Name(Priority priority) {
            switch (priority) {
                case Priority.NONE:
                    return "None";
                case Priority.VERY_LOW:
                    return "Very low";
                case Priority.LOW:
                    return "Low";
                case Priority.MEDIUM:
                    return "Medium";
                case Priority.HIGH:
                    return "High";
                case Priority.VERY_HIGH:
                    return "Very high";
                default:
                    throw new Exception("Invalid priority!");
            }
        }

        public static void UpdatePriority(Unit unit, Priority priority) {
            //todo sačuvati u bazu prioritet
        }
    }
}
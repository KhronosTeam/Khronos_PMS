﻿using System;
using System.Drawing;
using Khronos_PMS.Model;
using Khronos_PMS.Properties;

namespace Khronos_PMS.Util {
    public enum Status {
        ACTIVE,
        IN_PROGRESS,
        PAUSED,
        COMPLETED
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

        public static void UpdateStatus(Project project, Status status) {
            //todo sačuvati u bazu status
        }

        public static void UpdateStatus(Unit unit, Status status) {
            //todo sačuvati u bazu status
        }

        public static Status getStausById(int id)
        {
            return (Status)Enum.ToObject(typeof(Status), id);
        }
    }
}
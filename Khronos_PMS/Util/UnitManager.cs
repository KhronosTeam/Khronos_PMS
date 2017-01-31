using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Khronos_PMS.Model;

namespace Khronos_PMS.Util {
    static class UnitManager {
        public static List<Worker> GetAssigness(Unit unit) {
            List<Worker> list = new List<Worker>();
            foreach (WorksOn worksOn in unit.Workers) {
                list.Add(worksOn.AssignedTo.Worker);
            }
            return list;
        }

        // šef i nadzornik mogu da vide sve
        private static List<Activity> GetActivities(Unit unit) {
            List<Activity> activities = new List<Activity>();
            foreach (WorksOn worksOn in unit.Workers) {
                activities.AddRange(worksOn.Activities);
            }
            return activities;
        }

        public static List<Activity> GetActivities(Unit unit, User user) {
            //todo izbaciti null
            if (user == null || unit.Project.BossID == user.ID || unit.Project.SupervisorID == user.ID)
                return GetActivities(unit);

            WorksOn worksOn = unit.Workers.FirstOrDefault(w => w.WorkerID == user.ID);
            return worksOn?.Activities.ToList() ?? new List<Activity>(1);
        }
    }
}
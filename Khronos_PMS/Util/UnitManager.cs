using System;
using System.Collections.Generic;
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

        public static List<Activity> getActivities(Unit unit)
        {
            return ProjectManager.entities.Activities.Where(a => a.UnitID == unit.ID).ToList();
        }

    }
}

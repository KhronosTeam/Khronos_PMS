using System;
using System.Collections.Generic;
using System.Linq;
using Khronos_PMS.Model;

namespace Khronos_PMS.Util {
    public static class ProjectManager {
        public static KhronosPMSEntities entities;

        static ProjectManager() {
            entities = new KhronosPMSEntities();
        }

        public static List<Project> GetProjects() {
            return entities.Projects.ToList();
        }

        public static List<Project> GetProjects(User user)
        {
            if (user == null)
            {
                //todo Ovo treba obrisati za sad ostavljam da se ne morate logovati svaki put
                return GetProjects();
            }
            return entities.Projects.Where(p => (p.BossID == user.ID) || (p.SupervisorID == user.ID) || (p.Customers.Any(c=>c.ID==user.ID)) || (p.AssignedWorkers.Any(w=>w.WorkerID==user.ID))).ToList();
        }

        public static List<Worker> GetWorkers(Project project) {
            List<Worker> workers = new List<Worker>();
            foreach (AssignedTo assigned in project.AssignedWorkers) {
                workers.Add(assigned.Worker);
            }
            return workers;
        }

        public static List<Unit> GetUnits(Project project) {
            // Vratiti sve unite vezena za projekat
            List<Unit> units = new List<Unit>();
            foreach (Unit unit in project.Units) {
                units.Add(unit);
            }
            return units;
        }

        public static List<Unit> GetUnits(Project project, User user) {
            List<Unit> units = new List<Unit>();
            foreach (Unit unit in project.Units) {
            }
            return units;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Khronos_PMS.Model;

namespace Khronos_PMS.Util {
    class ProjectManager {
        private KhronosPMSEntities entities;

        public ProjectManager() {
            entities = new KhronosPMSEntities();
        }

        public List<Project> GetProjects(User user) {
            return entities.Projects.ToList();
        }

        public List<Worker> GetWorkers(Project project) {
            List<Worker> workers = new List<Worker>();
            foreach (AssignedTo assigned in project.AssignedWorkers) {
                workers.Add(assigned.Worker);
            }
            return workers;
        }

        public List<Unit> GetUnits(Project project) {
            // Vratiti sve unite vezena za projekat
            List<Unit> units = new List<Unit>();
            foreach (Unit unit in project.Units) {
                units.Add(unit);
            }

            return units;
        }

        public List<Unit> GetUnits(Project project, User user) {
            List<Unit> units = new List<Unit>();
            foreach (Unit unit in project.Units) {
            }
            return units;
        }
    }
}
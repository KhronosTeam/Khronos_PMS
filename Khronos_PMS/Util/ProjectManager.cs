using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Khronos_PMS.Model;
using Microsoft.Win32;

namespace Khronos_PMS.Util {
    public static class ProjectManager {
        public static KhronosPMSEntities entities;

        static ProjectManager() {
            entities = new KhronosPMSEntities();
        }

        public static List<Project> GetProjects() {
            return entities.Projects.ToList();
        }

        public static List<Project> GetProjects(User user) {
            List<int> assignedProjects = entities.AssignedToes.Where(a => a.WorkerID == user.ID && a.Active).Select(a => a.ProjectID).ToList();
            return entities.Projects.Where(p => (p.BossID == user.ID) || (p.SupervisorID == user.ID) || (p.Customers.Any(c => c.ID == user.ID)) || (assignedProjects.Contains(p.ID))).ToList();
        }

        public static List<Worker> GetWorkers(Project project) {
            List<Worker> workers = new List<Worker>();

            foreach (AssignedTo assignee in project.AssignedWorkers) {
                if (assignee.Active)
                    workers.Add(assignee.Worker);
            }
            return workers;
        }

        public static List<Worker> GetWorkers(Project project, User user) {
            return project.BossID == user.ID ? GetAllWorkers(project) : GetWorkers(project);
        }

        public static List<Worker> GetAllWorkers(Project project) {
            return entities.Workers.Where(worker => worker.ID != project.BossID && worker.ID != project.SupervisorID).ToList();
        }

        public static List<Unit> GetRootUnits(Project project) {
            return project.Units.Where(unit => unit.ClosureUnits.Any(c => c.Depth == 0)).ToList();
        }

        public static List<Unit> GetUnits(Project project) {
            return project.Units.ToList();
        }
        
        public static void AssignWorker(Project project, Worker worker) {
            new Task(() => {
                AssignedTo assignedTo = worker.AssignedProjects.FirstOrDefault(a => a.ProjectID == project.ID);
                lock (entities) {
                    if (assignedTo != null) {
                        assignedTo.Active = true;
                        entities.AssignedToes.Attach(assignedTo);
                        entities.Entry(assignedTo).State = EntityState.Modified;
                    } else {
                        assignedTo = new AssignedTo {ProjectID = project.ID, WorkerID = worker.ID, Active = true};
                        entities.AssignedToes.Add(assignedTo);
                    }
                    entities.SaveChanges();
                }
            }).Start();
        }

        public static void UnassignWorker(Project project, Worker worker) {
            new Task(() => {
                AssignedTo assignedTo = worker.AssignedProjects.FirstOrDefault(a => a.ProjectID == project.ID);
                if (assignedTo != null) {
                    assignedTo.Active = false;
                    lock (entities) {
                        entities.AssignedToes.Attach(assignedTo);
                        entities.Entry(assignedTo).State = EntityState.Modified;
                        entities.SaveChanges();
                    }
                }
            }).Start();
        }
    }
}
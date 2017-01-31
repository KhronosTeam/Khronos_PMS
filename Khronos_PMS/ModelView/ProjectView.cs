using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Khronos_PMS.Model;

namespace Khronos_PMS.ModelView
{
    public class ProjectView
    {
        
            public ProjectView(Project project)
            {
                this.Name = project.Name;
                this.BossName = project.Boss.FirstName + " " + project.Boss.LastName;
                this.SupervisorName = project.Boss.FirstName + " " + project.Boss.LastName;
                this.StartDate = project.StartDate;
                this.DeadlineDate = project.DeadlineDate;
                this.EndDate = project.EndDate;
                this.Budget = project.Budget;
                this.Expense = project.Expense;
                this.Status = project.Status;
                this.ID = project.ID;
                this.Boss = project.Boss;
                this.Supervisor = project.Supervisor;
            }

            public string Name { get; set; }
            public string BossName { get; set; }
            public string SupervisorName { get; set; }
            public System.DateTime StartDate { get; set; }
            public System.DateTime DeadlineDate { get; set; }
            public System.DateTime? EndDate { get; set; }
            public decimal Budget { get; set; }
            public decimal Expense { get; set; }
            public int Status { get; set; }
            public int ID { get; set; }
            public Worker Boss { get; set; }
            public Worker Supervisor { get; set; }
        
    }
}

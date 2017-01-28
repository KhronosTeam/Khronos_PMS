using Khronos_PMS.Model;
using Khronos_PMS.ModelView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Khronos_PMS.Util
{
    class ProjectManagement
    {
        public static KhronosPMSEntities entities = new KhronosPMSEntities();
        public static bool loadData(DataGridView dataGridView, KhronosPMSEntities entities)
        {
            try
            {
                List<Project> data;
                List<ProjectView> dataView = new List<ProjectView>();
  
                    data = entities.Projects.ToList();
           
                foreach (Project project in data)
                {
                    dataView.Add(new ProjectView(project));
                }
                dataGridView.DataSource = dataView;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool searchData(DataGridView dataGridView,String name ,KhronosPMSEntities entities)
        {
            try
            {
                List<Project> data;
                List<ProjectView> dataView = new List<ProjectView>();
               
                    data = entities.Projects.Where(p => p.Name.Contains(name)).ToList();
                
                foreach (Project project in data)
                {
                    dataView.Add(new ProjectView(project));
                }
                dataGridView.DataSource = dataView;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public static void formatColumns(DataGridView dataGridView)
        {
            dataGridView.Columns[0].HeaderText = "Name";
            dataGridView.Columns[1].HeaderText = "Boss Name";
            dataGridView.Columns[2].HeaderText = "Supervisor Name";
            dataGridView.Columns[3].HeaderText = "Start Date";
            dataGridView.Columns[4].HeaderText = "Deadline";
            dataGridView.Columns[5].HeaderText = "End Date";
            dataGridView.Columns[6].HeaderText = "Budget";
            dataGridView.Columns[7].HeaderText = "Expense";
            dataGridView.Columns[8].HeaderText = "Status";
            dataGridView.Columns[9].Visible = false;
            dataGridView.Columns[10].Visible = false;
            dataGridView.Columns[11].Visible = false;
        }

        public static List<WorkerView> GetWorkers()
        {
            List<Worker> workers =  entities.Workers.ToList();
            List<WorkerView> toReturn = new List<WorkerView>();
            foreach (Worker w in workers)
                toReturn.Add(new WorkerView(w.ID, w.User.Username));
            return toReturn;
        }

        public static List<CustomerView> GetCustomers()
        {
            List<Customer> customers = entities.Customers.ToList();
            List<CustomerView> toReturn = new List<CustomerView>();
            foreach (Customer c in customers)
                toReturn.Add(new CustomerView(c.ID, c.User.Username, c.Name));
            return toReturn;
        }
    }
}


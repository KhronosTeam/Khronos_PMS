using Khronos_PMS.Model;
using Khronos_PMS.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Khronos_PMS.ModelView
{
    class UnitView
    {
        public int ID { get; set; }
        public int ProjectID { get; set; }
        public string Name { get; set; }
        public System.DateTime DueDate { get; set; }
        public int Priority { get; set; }
        public decimal Expense { get; set; }
        public bool Finished { get; set; }
        public UnitView Ancestor { get; set; }
        public int AncestorID { get; set; }
        public int Depth { get; set; }
        public List<UnitView> children { get; set; }
        public UnitView() { }
        private Unit unit;
        public UnitView(Unit unit) {
            this.unit = unit;
            ID = unit.ID;
            ProjectID = unit.ProjectID;
            Name = unit.Name;
            DueDate = unit.DueDate;
            Priority = unit.Priority;
            Expense = unit.Priority;
            Finished = unit.Finished;
            try
            {
                Depth = unit.ClosureUnits.ToArray()[0].Depth;
            }
            catch (Exception e) {
                Depth = 0;
            }
        }
        public static void setChildren(UnitView parent) {
            List<UnitView> children = new List<UnitView>();
            List<ClosureUnit> units = parent.unit.AncestorClosureUnits.ToList();
            foreach (ClosureUnit unit in units) {
                UnitView newUnitView = new UnitView(ProjectManager.entities.Units.Where(u => u.ID==unit.ID ).First());
                if(newUnitView.Depth!=0)
                children.Add(newUnitView);
            }
            parent.children = children;
        }
        public void setChildren() {
            setChildren(this);
        }

        public List<UnitView> getChildren() {
            if (children == null) setChildren(this);
            return children;
        }

        public static List<UnitView> getRootUnits(int ProjectID) {
            List<UnitView> toReturn = new List<UnitView>();

            List<Unit> units = ProjectManager.entities.Projects.Where(p => p.ID == ProjectID).First().Units.ToList();
            foreach (Unit unit in units) {
                if (unit.ClosureUnits.ToArray()[0].Depth == 0) {
                    toReturn.Add(new UnitView(unit));
                }
            }

            return toReturn;
        }

        public static void test() {
            List<Unit> units = ProjectManager.entities.Units.ToList();
            foreach (Unit unit in units) {
                UnitView unitView = new UnitView(unit);
                setChildren(unitView);
            }
        }
    }

    // TODO preload in unittreeview
}

using Khronos_PMS.Model;
using Khronos_PMS.Util;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Khronos_PMS.ModelView {
    [Obsolete("UnitView is deprecated, please use Unit instead.")]
    class UnitView {
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
        private Unit unit;

        public UnitView() {
        }

        public UnitView(Unit unit) {
            this.unit = unit;
            ID = unit.ID;
            ProjectID = unit.ProjectID;
            Name = unit.Name;
            DueDate = unit.DueDate;
            Priority = unit.Priority;
            Expense = unit.Priority;
            Finished = unit.Finished;
            try {
                Depth = unit.ClosureUnits.ToArray()[0].Depth;
            } catch (Exception e) {
                Depth = 0;
            }
        }

        public static void setChildren(UnitView parent) {
            List<UnitView> children = new List<UnitView>();
            // AncestorClosureUnits predstavlja listu svih unita kojima je ancestor trenutni objekat
            List<ClosureUnit> units = parent.unit.AncestorClosureUnits.ToList();
            foreach (ClosureUnit unit in units) {
                UnitView newUnitView = new UnitView(ProjectManager.entities.Units.First(u => u.ID == unit.ID));
                // kako su root uniti predaci sami sebi, ovo sprečava da ubaci sam sebe u listu svojih potomaka
                if (newUnitView.Depth != 0)
                    children.Add(newUnitView);
            }
            parent.children = children;
        }

        public void setChildren() {
            if (children == null) setChildren(this);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>List-u koja predstavlja djecu unita</returns>
        public List<UnitView> getChildren() {
            if (children == null) setChildren(this);
            return children;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ProjectID">int, id projekta čiji se root uniti traže</param>
        /// <returns> listu root unita</returns>
        public static List<UnitView> getRootUnits(Project project) {
            List<UnitView> toReturn = new List<UnitView>();
            var units = project.Units;
            foreach (Unit unit in units) {
                if (unit.ClosureUnits.ToArray()[0].Depth == 0) {
                    toReturn.Add(new UnitView(unit));
                }
            }

            return toReturn;
        }

        public void setGrandChildren() {
            foreach (UnitView child in children) {
                child.setChildren();
            }
        }

        public void setChildrenAndGrandChildren() {
            setChildren();
            setGrandChildren();
        }

        public void addChild(Unit unit) {
            children.Add(new UnitView(unit));
        }
    }

    // TODO preload in unittreeview
}
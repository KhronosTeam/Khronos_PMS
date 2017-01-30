using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Khronos_PMS.Model {
    public partial class Unit {
        private int estimatedManhours = 100;
        private int spentManhours = 5;

        public int EstimatedManhours => estimatedManhours;

        public int SpentManhours => spentManhours;

        public bool HasChildren => AncestorClosureUnits.Any(a => a.AncestorID != a.ID);

        public List<Unit> Children => AncestorClosureUnits.Where(c => c.AncestorID != c.ID).Select(c => c.Unit).ToList();

        public bool IsRoot => ClosureUnits.Any(unit => unit.Depth == 0);

        public List<Worker> Assigness {
            get {
                List<Worker> list = new List<Worker>();
                foreach (WorksOn worksOn in Workers) {
                    list.Add(worksOn.AssignedTo.Worker);
                }
                return list;
            }
        }
    }
}
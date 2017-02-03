using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Khronos_PMS.Model {
    public partial class Unit {
        public bool HasChildren => Children.Any(unit => unit.Active);

        public bool IsRoot => Ancestor == null;

        public List<Worker> Assignees => Workers.Where(w => w.Active).Select(worksOn => worksOn.AssignedTo.Worker).ToList();
    }
}
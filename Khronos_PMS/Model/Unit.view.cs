using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Khronos_PMS.Model {
    public partial class Unit {
        public bool HasChildren => AncestorClosureUnits.Any(a => a.AncestorID != a.ID);

        public List<Unit> Children => AncestorClosureUnits.Where(c => c.AncestorID != c.ID).Select(c => c.Unit).ToList();

        public bool IsRoot => ClosureUnits.Any(unit => unit.Depth == 0);
    }
}
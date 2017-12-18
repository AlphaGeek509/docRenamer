using docRenamer;
using Massive;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace docManager.TableClasses
{
    class PURCHASE_ORDER : DynamicModel
    {
        public PURCHASE_ORDER() : this(includeSchema: true) { }
        public PURCHASE_ORDER(bool includeSchema)
            : base(ConstantsEnums.connectionStringName, includeSchema ? "SYSADM.PURCHASE_ORDER" : "PURCHASE_ORDER", "ID")
        {

        }
    }
}

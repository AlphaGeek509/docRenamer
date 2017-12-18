using docRenamer;
using Massive;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace docManager.TableClasses
{
    class LT_RM_CONTAINER: DynamicModel
    {
        public LT_RM_CONTAINER() : this(includeSchema: true) { }
        public LT_RM_CONTAINER(bool includeSchema)
            : base(ConstantsEnums.connectionStringName, includeSchema ? "SYSADM.LT_RM_CONTAINER" : "LT_RM_CONTAINER", "ID")
        {

        }
    }
}

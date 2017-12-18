using docRenamer;
using Massive;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace docManager.TableClasses
{
    class LT_RAW_MATERIAL: DynamicModel
    {
        public LT_RAW_MATERIAL() : this(includeSchema: true) { }
        public LT_RAW_MATERIAL(bool includeSchema)
            : base(ConstantsEnums.connectionStringName, includeSchema ? "SYSADM.LT_RAW_MATERIAL" : "LT_RAW_MATERIAL", "ID")
        {

        }
    }
}

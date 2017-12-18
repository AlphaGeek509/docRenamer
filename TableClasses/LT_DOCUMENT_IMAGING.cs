using docRenamer;
using Massive;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace docManager.TableClasses
{
    class LT_DOCUMENT_IMAGING: DynamicModel
    {
        public LT_DOCUMENT_IMAGING() : this(includeSchema: true) { }
        public LT_DOCUMENT_IMAGING(bool includeSchema)
            : base(ConstantsEnums.connectionStringName, includeSchema ? "SYSADM.LT_DOCUMENT_IMAGING" : "LT_DOCUMENT_IMAGING", "ID")
        {

        }

    }
}

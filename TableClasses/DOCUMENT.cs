using Massive;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace docRenamer.TableClasses
{
    class DOCUMENT : DynamicModel
    {
        public DOCUMENT() : this(includeSchema: true) { }
        public DOCUMENT(bool includeSchema)
            : base(ConstantsEnums.connectionStringName, includeSchema ? "SYSADM.DOCUMENT" : "DOCUMENT", "ID")
        {

        }

    }
}

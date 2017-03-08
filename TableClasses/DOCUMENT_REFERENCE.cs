using Massive;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace docRenamer.TableClasses
{
    class DOCUMENT_REFERENCE : DynamicModel
    {
        public DOCUMENT_REFERENCE() : this(includeSchema: true) { }
        public DOCUMENT_REFERENCE(bool includeSchema)
            : base(ConstantsEnums.connectionStringName, includeSchema ? "SYSADM.DOCUMENT" : "DOCUMENT", "ID")
        {

        }

    }
}

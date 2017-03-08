using Massive;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace docRenamer.TableClasses
{
    class RECEIVER : DynamicModel
    {
        public RECEIVER() : this(includeSchema: true) { }
        public RECEIVER(bool includeSchema)
            : base(ConstantsEnums.connectionStringName, includeSchema ? "SYSADM.RECEIVER" : "RECEIVER", "ID")
        {

        }

    }
}

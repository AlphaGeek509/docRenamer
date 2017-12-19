using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace docRenamer
{
    public class ConstantsEnums
    {
        public static string connectionStringName { get; set; }
        public static readonly string logFile = @"C:\LynTron\logs\documentManager.txt";

        public ConstantsEnums()
        {
            connectionStringName = "VMFG";
        }
        //public getConnectionStringName(string name)
        //{

        //}
    }

    
}
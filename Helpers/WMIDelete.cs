using System;
using System.Collections.Generic;
using System.Text;
using baileysoft.Wmi;
using System.Management;

namespace WMI_Hardware.Class
{
    public class WMIDelete
    {
        public static IList<string> Process(Connection WMIConnection,
            string SelectQuery,
            string className)
        {
            ManagementScope connectionScope = WMIConnection.GetConnectionScope;
            List<string> alProperties = new List<string>();
            SelectQuery msQuery = new SelectQuery(SelectQuery);
            ManagementObjectSearcher searchProcedure = new ManagementObjectSearcher(connectionScope, msQuery);

            try
            {
                foreach (ManagementObject item in searchProcedure.Get())
                {
                    item.Delete();
                }
            }
            catch (ManagementException e)
            {
                Console.WriteLine(e.Message);
            }

            return alProperties;
        }
    }
}

using baileysoft.Wmi;
using System;
using System.Collections.Generic;
using System.Text;
using WMI_Hardware.Class;

namespace WMI_Hardware.Hardware
{
    class Win32_DeleteFile
    {
        Connection WMIConnection;

        public Win32_DeleteFile(Connection WMIConnection)
        {
            this.WMIConnection = WMIConnection;
        }
        public void Process()
        {
            string className = "CIM_DataFile";

            try
            {
                WMIDelete.Process(WMIConnection,
                    "SELECT * FROM " + className + " Where Drive='D:' AND Path = '\\\\Logs\\\\' AND FileName LIKE '%iViewHostClientLog.0%'",
                    className);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}

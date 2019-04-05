using baileysoft.Wmi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMI_Hardware.Hardware;

namespace ComputerExplorer
{
    class Program
    {
        static void Main(string[] args)
        {
            //Connection wmiConnection = new Connection();

            //Remote Connection
            Connection wmiConnection = new Connection("iview",
                                                      "iVIEW4@WES7",
                                                      "WORKGROUP",
                                                      "10.2.109.74");

            Win32_DeleteFile df = new Win32_DeleteFile(wmiConnection);
            df.Process();

            Console.ReadLine();
        }
    }
}

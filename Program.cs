using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace ElectiveManagementSystem
{
    static class Program
    {
       

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Kernel console = new Kernel("localhost", "elecdb", "root", "");
            Application.Run();
            
        }
    }
}

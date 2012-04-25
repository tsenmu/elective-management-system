using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;


namespace ElectiveManagementSystem
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
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

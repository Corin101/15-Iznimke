using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Vsite.CSharp
{
    // Program generira iznimke u odre�enim vremenskim intervalima da bismo
    // ih mogli pratiti u PERFMON aplikaciji
    // Nakon �to ovaj program pokrenemo (moramo isklju�iti hvatanje 
    // DivideByZeroException u Visual Studiju!), treba pokrenuti 
    // PerfMon.exe i uklju�iti pra�ene .NET CLR Exceptions. Nakon toga kliknemo
    // na tipku da na�a aplikacija po�ne bacati iznimke.
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
            Application.Run(new Form1());
        }
    }
}
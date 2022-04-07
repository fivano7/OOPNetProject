using PodatkovniSloj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorldCupWF
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

            if (!Repository.DaLiPostojePostavke())
            {
                Application.Run(new PocetnePostavke());
                Application.Run(new OdabirReprezentacije(Repository.DohvacanjePostavki()));
            }

            Application.Run(new OdabirOmiljenihIgraca());
        }
    }
}

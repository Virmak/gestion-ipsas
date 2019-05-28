using Gestion_Ipsas.Ui;
using System;
using System.Windows.Forms;

namespace Gestion_Ipsas
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
            Application.Run(new Authentification());
        }
    }
}

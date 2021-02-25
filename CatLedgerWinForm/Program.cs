using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace CatLedgerWinForm
{
    static class Program
    {
        public static readonly FormSignUp frmSignUp = new FormSignUp();
        public static readonly FormLogIn frmLogIn = new FormLogIn();
        public static readonly FormMainPage frmMainPage = new FormMainPage();
        public static CommonData commonData = new CommonData();

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(frmLogIn);
        }
    }
}

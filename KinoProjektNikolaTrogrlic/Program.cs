using KinoProjektNikolaTrogrlic.Classes;
using System;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

namespace KinoProjektNikolaTrogrlic
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var iniFile = new ReadWriteINIFiles("Settings.ini");
            var changeStartup = false;
            var language = iniFile.Read("Language");
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo(language);
            if (iniFile.KeyExists("Startup"))
            {
                if (iniFile.Read("Startup") == "true")
                {
                    changeStartup = true;
                }
            }
            if (iniFile.KeyExists("Mode") && changeStartup)
            {
                switch (iniFile.Read("Mode"))
                {
                    case "User":
                        var auth = new Authentification();
                        auth.Show();
                        break;
                    case "Admin":
                        var authentification = new AdminAuthentification();
                        authentification.Show();
                        break;
                    default:
                        var main_form = new Startup();
                        main_form.Show();
                        break;
                }
            }
            else
            {
                var main_form = new Startup();
                main_form.Show();
            }
            Application.Run();
        }
    }
}

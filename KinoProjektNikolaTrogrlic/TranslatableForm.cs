using ConfirmationDialog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KinoProjektNikolaTrogrlic.Classes
{
    public partial class TranslatableForm : Form
    {
        public string Language { get; set; }
        public bool AskExit { get; set; }
        public bool GoToMainMenu { get; set; }

        public TranslatableForm()
        {
            InitializeComponent();
            ReadWriteINIFiles iniFile = new ReadWriteINIFiles("Settings.ini");
            if (iniFile.KeyExists("AskExit"))
            {
                if (iniFile.Read("AskExit") == "true")
                {
                    AskExit = true;
                }
                else
                {
                    AskExit = false;
                }
            }
            if (iniFile.KeyExists("Language"))
            {
                Language = iniFile.Read("Language");
            }
            else
            {
                Language = "en";
            }
            GoToMainMenu = false;
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            if (Application.OpenForms.Count == 0)
            {
                if (GoToMainMenu)
                {
                    Startup startup = new Startup();
                    startup.Show();
                }
                else
                {
                    Application.Exit();
                }
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (Application.OpenForms.Count <= 1 && AskExit && !GoToMainMenu)
            {             
                Confirm confirm = new Confirm(TranslatableString("Exit application?","Zatvori aplikaciju ?"));
                confirm.ShowDialog();
                if (confirm.DialogResult == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        public string TranslatableString(string en,string hr)
        {
            switch (Language)
            {
                case "hr":
                    return hr;
                default:
                    return en;
            }
        }

        public  void LoadLanguage()
        {
            ReadWriteINIFiles iniFile = new ReadWriteINIFiles("Settings.ini");
            Language = iniFile.Read("Language");
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo(Language);
        }
    }
}

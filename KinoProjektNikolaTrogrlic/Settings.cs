using KinoProjektNikolaTrogrlic.Classes;
using System;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

namespace KinoProjektNikolaTrogrlic
{
    public partial class Settings : TranslatableForm
    {
        ReadWriteINIFiles IniFile { get; set; }
        public Settings()
        {
            InitializeComponent();
            GoToMainMenu = true;
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            IniFile = new ReadWriteINIFiles("Settings.ini");
            comboboxLanguage.Items.Add("English");
            comboboxLanguage.Items.Add("Croatian");
            switch (Language)
            {
                case "hr":
                    comboboxLanguage.SelectedIndex = 1;
                    comboboxStart.Items.Add("Administratorski način rada");
                    comboboxStart.Items.Add("Korisnički način rada");
                    break;
                default:
                    comboboxLanguage.SelectedIndex = 0;
                    comboboxStart.Items.Add("Admin mode");
                    comboboxStart.Items.Add("User mode");
                    break;
            }
            if (IniFile.KeyExists("Startup"))
            {
                if (IniFile.Read("Startup") == "true")
                {
                    checkboxSkip.Checked = true;
                    comboboxStart.Enabled = true;
                }
                else
                {
                    checkboxSkip.Checked = false;
                    comboboxStart.Enabled = false;
                }
            }
            if (IniFile.KeyExists("AskExit"))
            {
                if (IniFile.Read("AskExit") == "false")
                {
                    checkboxApp.Checked = true;
                }
                else
                {
                    checkboxApp.Checked = false;
                }
            }
        }

        private void ComboboxLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboboxLanguage.SelectedItem.ToString() == "English")
            {
                IniFile.Write("Language", "en");

            }
            else if (comboboxLanguage.SelectedItem.ToString() == "Croatian")
            {
                IniFile.Write("Language", "hr");
            }
            LoadLanguage();
        }

        private void ComboboxStart_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboboxStart.SelectedItem.ToString() == "Admin mode" ||
                comboboxStart.SelectedItem.ToString() == "Administratorski način rada")
            {
                IniFile.Write("Mode", "Admin");

            }
            else if (comboboxStart.SelectedItem.ToString() == "User mode" ||
                comboboxStart.SelectedItem.ToString() == "Korisnički način rada")
            {
                IniFile.Write("Mode", "User");
            }
        }

        private void CheckboxSkip_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkboxSkip.Checked)
            {
                comboboxStart.Enabled = false;
                IniFile.Write("Startup", "false");

            }
            else
            {
                comboboxStart.Enabled = true;
                IniFile.Write("Startup", "true");
            }
        }

        private void CheckboxApp_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkboxApp.Checked)
            {
                IniFile.Write("AskExit", "true");

            }
            else
            {
                IniFile.Write("AskExit", "false");
            }
        }

        private void ButtonAuthor_Click(object sender, EventArgs e)
        {
            ConfirmationDialog.Info dialog = new ConfirmationDialog.Info();
            dialog.ShowDialog();
        }
    }
}

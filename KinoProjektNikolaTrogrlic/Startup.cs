using KinoProjektNikolaTrogrlic.Classes;
using System;
using System.Windows.Forms;

namespace KinoProjektNikolaTrogrlic
{
    public partial class Startup : TranslatableForm
    {
        public Startup()
        {
            InitializeComponent();
        }

        private void ButtonAdmin_Click(object sender, EventArgs e)
        {
            AdminAuthentification authentification = new AdminAuthentification();
            authentification.Show();
            this.Close();
        }

        private void ButtonUser_Click(object sender, EventArgs e)
        {
            Authentification authentification = new Authentification();
            authentification.Show();
            this.Close();
        }

        private void ButtonSettings_Click(object sender, EventArgs e)
        {

            Settings settings = new Settings();
            settings.Show();
            this.Close();
        }
 
    }
}

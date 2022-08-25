using KinoProjektNikolaTrogrlic.AdminAPP;
using KinoProjektNikolaTrogrlic.Classes;
using System;
using System.Data.SqlClient;
using System.Threading;
using System.Windows.Forms;

namespace KinoProjektNikolaTrogrlic
{
    public partial class AdminAuthentification : TranslatableForm
    {
        public string Key { get; set; }
        public AdminAuthentification()
        {
            InitializeComponent();
            GoToMainMenu = true;
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            DatabaseLoginThread(textboxDBName.Text, textboxDBUser.Text, textboxDBPassword.Text, textboxDB.Text);
        }

        private void AdminAuthentification_Load(object sender, EventArgs e)
        {
            if (AdminManagement.CheckIfSettingsKeyPresent("AutoEnter") == true)
            {
                if (AdminManagement.GetSettingsKey("AutoEnter") == "True")
                {
                    EnterKey dialog = new EnterKey(this,"Admin");
                    dialog.ShowDialog();
                    if (dialog.DialogResult == DialogResult.OK)
                    {
                        var decrypted = EncryptionManager.DecryptString(AdminManagement.GetSettingsKeyBytes("ServerPassword"), Key);
                        DatabaseLoginThread(AdminManagement.GetSettingsKey("ServerName"),
                            AdminManagement.GetSettingsKey("ServerUID"),
                            decrypted,
                            AdminManagement.GetSettingsKey("ServerDatabase"));
                    }
                }
            }
        }

        public void EnterDatabase(string server, string UID, string password, string database = "master")
        {
            String connectionString = "";
            this.Invoke((MethodInvoker)delegate
            {
                buttonLogin.Enabled = false;
            });
            try

            {

                String databaseToConnect = textboxDB.Text;
                if (String.IsNullOrEmpty(databaseToConnect))
                {
                    databaseToConnect = database;
                }

                connectionString = "server=" + server +
                    ";database=" + databaseToConnect +
                    ";UID=" + UID +
                    ";password=" + password;

                using(SqlConnection myConnection = new SqlConnection(connectionString))
                {
                    myConnection.Open();
                    this.Invoke((MethodInvoker)delegate
                    {
                        AdminManagement managment = new AdminManagement(connectionString);
                        managment.Show();
                        this.Close();
                    });
                }
            }

            catch (Exception es)
            {
                MessageBox.Show(es.Message);
                this.Invoke((MethodInvoker)delegate
                {
                    buttonLogin.Enabled = true;
                });
            }
        }

        public Thread DatabaseLoginThread(string server, string UID, string password, string database = "master")
        {
            Thread thread = new Thread(() => EnterDatabase(server, UID, password, database));
            thread.Start();
            return thread;
        }
    }
}

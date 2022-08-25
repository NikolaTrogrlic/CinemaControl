using KinoProjektNikolaTrogrlic.Classes;
using KinoProjektNikolaTrogrlic.UserAPP;
using Newtonsoft.Json;
using SimpleTCP;
using System;
using System.Text;
using System.Windows.Forms;

namespace KinoProjektNikolaTrogrlic
{
    public partial class Authentification : TranslatableForm
    {
        SimpleTcpClient Client { get; set; }
        User User { get; set; }
        public Authentification()
        {
            InitializeComponent();
            GoToMainMenu = true;
        }

        private void Authentification_Load(object sender, EventArgs e)
        {
            Client = new SimpleTcpClient
            {
                StringEncoder = Encoding.UTF8
            };
            Client.DataReceived += Client_DataReceived;
            var iniFile = new ReadWriteINIFiles("Settings.ini");
            if (iniFile.KeyExists("RememberInfo"))
            {
                if (Convert.ToBoolean(iniFile.Read("RememberInfo")))
                {
                    checkboxPortAddress.Checked = true;
                    textboxPort.Text = iniFile.Read("RememberPort");
                    textboxAddress.Text = iniFile.Read("RememberAddress");
                }
            }
        }

        private void Register_Click(object sender, EventArgs e)
        {
            Registration registerForm = new Registration();
            registerForm.ShowDialog();
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                buttonLogin.Enabled = false;
                int port = Convert.ToInt32(textboxPort.Text);
                Client.Connect(textboxAddress.Text, port);
                User u = new User(textboxUsername.Text, textboxPassword.Text);
                string s = JsonConvert.SerializeObject(u);
                Client.Write(s);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                buttonLogin.Enabled = true;
            }
        }

        private void Client_DataReceived(object sender, SimpleTCP.Message e)
        {
            try
            {
                buttonLogin.Invoke((MethodInvoker)delegate ()
                {
                    buttonLogin.Enabled = true;
                    if (checkboxPortAddress.Checked)
                    {
                        var iniFile = new ReadWriteINIFiles("Settings.ini");
                        iniFile.Write("RememberInfo", checkboxPortAddress.Checked.ToString());
                        iniFile.Write("RememberPort", textboxPort.Text);
                        iniFile.Write("RememberAddress", textboxAddress.Text);
                    }
                });
                if (e.MessageString != "Connection Failure")
                {
                    User = JsonConvert.DeserializeObject<User>(e.MessageString);
                    if (User.ValidatedAccount)
                    {
                        this.Invoke((MethodInvoker)delegate ()
                        {
                            UserManagement mainwindow = new UserManagement(User, textboxAddress.Text , Convert.ToInt32(textboxPort.Text));
                            mainwindow.Show();
                            this.Close();
                        });
                    }
                    else
                    {
                        switch (Language)
                        {
                            case "en":
                                MessageBox.Show("This account is not validated. Please contact the server administrator.");
                                break;
                            case "hr":
                                MessageBox.Show("Račun nije validiran. Molimo vas obratite se administratoru sustava.");
                                break;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Login failed");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

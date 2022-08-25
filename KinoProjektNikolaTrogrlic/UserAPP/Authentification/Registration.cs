using KinoProjektNikolaTrogrlic.Classes;
using Newtonsoft.Json;
using SimpleTCP;
using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KinoProjektNikolaTrogrlic
{
    public partial class Registration : Form
    {
        SimpleTcpClient Client { get; set; }
        public string Language { get; set; }
        public Registration()
        {
            InitializeComponent();
        }

        private void Registration_Load(object sender, EventArgs e)
        {
            var iniFile = new ReadWriteINIFiles("Settings.ini");

            /*COMBOBOX*/
            Language = iniFile.Read("Language");
            switch (Language)
            {
                case "hr":
                    comboboxGender.Items.Add("Muško");
                    comboboxGender.Items.Add("Žensko");
                    comboboxGender.Items.Add("Drugi");
                    break;
                default:
                    comboboxGender.Items.Add("Male");
                    comboboxGender.Items.Add("Female");
                    comboboxGender.Items.Add("Other");
                    break;
            }
            comboboxGender.SelectedIndex = 0;
            /*TCP*/
            Client = new SimpleTcpClient
            {
                StringEncoder = Encoding.UTF8
            };
            Client.DataReceived += Client_DataReceived;
        }

        private void ButtonRegister_Click(object sender, EventArgs e)
        {
            try
            {
                ImageConverter converter = new ImageConverter();
                byte[] image = (byte[])converter.ConvertTo(pictureboxUser.Image, typeof(byte[]));
                buttonRegister.Enabled = false;
                User.ValidateInput(textboxUser.Text,
                    textboxFirstName.Text,
                    textboxLastName.Text,
                    comboboxGender.SelectedItem.ToString(),Language);
                User user = new User(textboxUser.Text,
                    textboxPassword.Text,
                    textboxFirstName.Text,
                    textboxLastName.Text,
                    comboboxGender.SelectedItem.ToString(),
                    "False",
                    image
                    );
                int port = Convert.ToInt32(textboxPort.Text);
                Client.Connect(textboxAddress.Text, port);
                string s = "REGISTER:" + JsonConvert.SerializeObject(user);
                Client.Write(s);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                buttonRegister.Enabled = true;
            }
        }

        private void PictureboxUser_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Open Image";
                dlg.Filter = "image files|*.bmp;*.png;*.jpg;*.jpeg";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    pictureboxUser.Image = new Bitmap(dlg.FileName);
                }
            }
        }

        private void Client_DataReceived(object sender, SimpleTCP.Message e)
        {
            try
            {
                buttonRegister.Invoke((MethodInvoker)delegate ()
                {
                    buttonRegister.Enabled = true;
                });
                if (e.MessageString == "Exists")
                {
                    switch (Language)
                    {
                        case "hr":
                            MessageBox.Show("Korisnik već postoji.");
                            break;
                        default:
                            MessageBox.Show("Username already exists.");
                            break;
                    }
                }
                else if (e.MessageString != "Connection Failure")
                {
                    switch (Language)
                    {
                        case "hr":
                            MessageBox.Show("Registracija uspiješna");
                            break;
                        default:
                            MessageBox.Show("Registration sucessful.");
                            break;
                    }
                    this.Invoke((MethodInvoker)delegate ()
                    {
                        this.Close();
                    });
                }
                else
                {
                    MessageBox.Show("Registration failed");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

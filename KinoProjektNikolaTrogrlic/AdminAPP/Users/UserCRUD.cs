using KinoProjektNikolaTrogrlic.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KinoProjektNikolaTrogrlic.AdminAPP.Users
{
    public partial class UserCRUD : TranslatableForm
    {
        /*SQL*/
        public DatabaseManager Db { get; set; }

        /*ELEMENTS*/

        TextBox TextBoxUsername { get; set; }

        TextBox TextBoxFirstName { get; set; }
        TextBox TextBoxLastName { get; set; }

        CheckBox CheckBoxValidated { get; set; }

        ComboBox ComboBoxGender { get; set; }

        PictureBox PictureBoxProfile { get; set; }
        public UserCRUD()
        {
            InitializeComponent();
        }

        public UserCRUD(DatabaseManager db)
        {
            InitializeComponent();
            Db = db;
        }

        protected void OnLoad(TextBox textboxUsername,
            TextBox teextboxFirstName, TextBox textboxLastName, ComboBox comboboxGender,
            CheckBox checkboxValidated, PictureBox pictureboxProfile, User user = null)
        {
            TextBoxUsername = textboxUsername;

            TextBoxFirstName = teextboxFirstName;
            TextBoxLastName = textboxLastName;

            CheckBoxValidated = checkboxValidated;

            ComboBoxGender = comboboxGender;

            PictureBoxProfile = pictureboxProfile;

            switch (Language)
            {
                case "hr":
                    ComboBoxGender.Items.Add("Muško");
                    ComboBoxGender.Items.Add("Žensko");
                    ComboBoxGender.Items.Add("Drugi");
                    break;
                default:
                    ComboBoxGender.Items.Add("Male");
                    ComboBoxGender.Items.Add("Female");
                    ComboBoxGender.Items.Add("Other");
                    break;
            }
            comboboxGender.SelectedIndex = 0;

            if (user != null)
            {
                TextBoxUsername.Text = user.Username;

                TextBoxFirstName.Text = user.FirstName;
                TextBoxLastName.Text = user.LastName;

                CheckBoxValidated.Text = user.ValidatedAccount.ToString();


                for (int i = 0; i < ComboBoxGender.Items.Count; i++)
                {
                    if (ComboBoxGender.Items[i].ToString() == user.Gender)
                    {
                        ComboBoxGender.SelectedIndex = i;
                    }
                }
                checkboxValidated.Checked = user.ValidatedAccount;

                using (var ms = new MemoryStream(user.ImageBytes))
                {
                    Image image = Image.FromStream(ms, true);
                    PictureBoxProfile.Image = image;
                }
            }
        }

        protected void UploadPicture(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Open Image";
                dlg.Filter = "image files|*.bmp;*.png;*.jpg;*.jpeg";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    PictureBoxProfile.Image = new Bitmap(dlg.FileName);
                }
            }
        }

        protected void VerifyAndSaveUser(Action<User> action)
        {
            try
            {
                string gender = ComboBoxGender.SelectedItem.ToString();
                User.ValidateInput(TextBoxUsername.Text,
                    TextBoxFirstName.Text,
                    TextBoxLastName.Text,
                    gender,Language);
                bool validated = false;
                if(CheckBoxValidated  != null)
                {
                    validated = CheckBoxValidated.Checked;
                }
                User user = new User()
                {
                    FirstName = TextBoxFirstName.Text,
                    LastName = TextBoxLastName.Text,
                    Gender = gender,
                    Username = TextBoxUsername.Text,
                    ValidatedAccount = validated
                };
                action(user);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

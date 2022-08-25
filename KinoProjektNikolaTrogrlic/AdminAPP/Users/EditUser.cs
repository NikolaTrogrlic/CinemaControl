using KinoProjektNikolaTrogrlic.AdminAPP.Users;
using KinoProjektNikolaTrogrlic.Classes;
using System;
using System.Windows.Forms;

namespace KinoProjektNikolaTrogrlic.AdminAPP
{
    public partial class EditUser : UserCRUD
    {
        private int Id { get; set; }

        public EditUser(int id, DatabaseManager db) : base(db)
        {
            InitializeComponent();
            Id = id;

        }
        private void EditUser_Load(object sender, EventArgs e)
        {
            User user = Db.GetUserById(Id);
            OnLoad(textboxUser, textboxFirstName, textboxLastName, comboboxGender, checkboxValidated, pictureboxUser, user);
        }

        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            VerifyAndSaveUser((user) =>
            {
                string result = Db.UpdateUserInfo(Id, user);
                MessageBox.Show(result);
            });
        }

        private void ButtonUpdatePass_Click(object sender, EventArgs e)
        {
            try
            {
                if (textboxPassword.Text == textboxPassword2.Text)
                {
                    if (textboxPassword.Text.Length < 6)
                        throw new Exception("Password must be at least 6 characters");
                    if (textboxPassword.Text != textboxPassword2.Text)
                        throw new Exception(TranslatableString("Passwords must match.", "Lozinke se moraju podudarati"));
                    string result = Db.ChangeUserPassword(Id, textboxPassword.Text);
                    MessageBox.Show(result);
                    this.Close();
                }
                else
                {
                    MessageBox.Show(TranslatableString("Passwords need to match!", "Lozinke se moraju podudarati!"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            ConfirmationDialog.Confirm confirm = new ConfirmationDialog.Confirm(TranslatableString("Delete User?", "Izbrisati korisnika?"));
            confirm.ShowDialog();
            if (confirm.DialogResult == DialogResult.Yes)
            {
                string result = Db.DeleteFromDB(Id, "Users");
                if (result == "Deleted")
                {
                    this.Close();
                }
            }
        }

        private void ButtonPictureUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Db.UpdateUserPicture(Id, pictureboxUser.Image);
                buttonPictureUpdate.Enabled = false;
                MessageBox.Show(TranslatableString("Profile picture changed.", "Uspiješno promijenjena profilna slika."));
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void PictureboxUser_Click(object sender, EventArgs e)
        {
            UploadPicture(sender, e);
            buttonPictureUpdate.Enabled = true;
        }
    }
}

using KinoProjektNikolaTrogrlic.AdminAPP.Users;
using KinoProjektNikolaTrogrlic.Classes;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace KinoProjektNikolaTrogrlic.AdminAPP
{
    public partial class AddUser : UserCRUD
    {
        public AddUser(DatabaseManager db): base(db)
        {
            InitializeComponent();
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            VerifyAndSaveUser((user) =>
            {
                if (textboxPassword.Text.Length < 6)
                    throw new Exception("Password must be at least 6 characters");
                if (textboxPassword.Text != textboxPassword2.Text)
                    throw new Exception(TranslatableString("Passwords must match.","Lozinke se moraju podudarati"));
                user.Password = textboxPassword.Text;
                user.Image = pictureboxUser.Image;
                string result = Db.AddUserToDB(user);
                MessageBox.Show(result);
            });
        }

        private void PictureboxUser_Click(object sender, EventArgs e)
        {
            UploadPicture(sender,e);
        }

        private void AddUser_Load(object sender, EventArgs e)
        {
            OnLoad(textboxUser, textboxFirstName, textboxLastName, comboboxGender, null, pictureboxUser);
        }
    }
}

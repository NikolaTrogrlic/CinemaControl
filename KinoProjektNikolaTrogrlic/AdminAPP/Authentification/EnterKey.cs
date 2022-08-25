using KinoProjektNikolaTrogrlic.Classes;
using KinoProjektNikolaTrogrlic.UserAPP;
using System;
using System.Windows.Forms;

namespace KinoProjektNikolaTrogrlic.AdminAPP
{
    public partial class EnterKey : TranslatableForm
    {
        private AdminAuthentification MainForm { get; set; }

        private UserManagement UserForm { get; set; }

        private string KeyFor { get; set; }

        public EnterKey()
        {
            InitializeComponent();
        }

        public EnterKey(Form initialForm,string keyFor)
        {
            KeyFor = keyFor;
            if(KeyFor == "Admin")
            {
                MainForm = initialForm as AdminAuthentification;
            }
            else if(KeyFor == "UserXML")
            {
                UserForm = initialForm as UserManagement;
            }
            InitializeComponent();
        }

        private void PasswordForm_Load(object sender, EventArgs e)
        {

        }

        private void ButtonSend_Click(object sender, EventArgs e)
        {
            if (KeyFor == "Admin")
            {
                MainForm.Key = textBox1.Text;
            }
            else if (KeyFor == "UserXML")
            {
                UserForm.Key = textBox1.Text;
            }
        }
    }
}

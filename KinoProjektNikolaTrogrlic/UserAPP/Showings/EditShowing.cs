using KinoProjektNikolaTrogrlic.Classes;
using Movies;
using Newtonsoft.Json;
using SimpleTCP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KinoProjektNikolaTrogrlic.UserAPP
{
    public partial class EditShowing : Showing
    {
        public int ShowingIndex { get; set; }
        public EditShowing(string address, int port, int seats, UserManagement mainForm,int index) : base(address, port, seats, mainForm)
        {
            InitializeComponent();
            ShowingIndex = index;
        }

        private void EditShowing_Load(object sender, EventArgs e)
        {
            ShowingOnLoad(comboboxMovie, datetimePicker, textboxTicketPrice, UserManagement.CurrentRoom.Showings[ShowingIndex]);
        }

        public void ButtonAddClick(object sender, EventArgs e)
        {
            ButtonVerifyShowing((showing) =>
            {
                UserManagement.CurrentRoom.Showings[ShowingIndex] = showing;
            });
        }

        public void ButtonMoviesClick(object sender, EventArgs e)
        {
            ButtonGetMoviesClick(sender, e);
        }

        private void ButtonDeleteClick(object sender, EventArgs e)
        { 
            ConfirmationDialog.Confirm confirm = new ConfirmationDialog.Confirm("Are you sure you want to remove this item?");
            confirm.ShowDialog();
            if (confirm.DialogResult == DialogResult.Yes)
            {
                UserManagement.CurrentRoom.Showings.RemoveAt(ShowingIndex);
            }
        }
    }
}

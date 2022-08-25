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
    public partial class AddShowing : Showing
    {

        public AddShowing(string address, int port, int seats, UserManagement mainForm) : base(address, port, seats, mainForm)
        {
            InitializeComponent();
        }

        public void ButtonAddClick(object sender, EventArgs e)
        {
            ButtonVerifyShowing((showing) =>
            {
                UserManagement.CurrentRoom.Showings.Add(showing);
            });
        }

        public void ButtonMoviesClick(object sender, EventArgs e)
        {
            ButtonGetMoviesClick(sender, e);
        }

        private void AddShowing_Load(object sender, EventArgs e)
        {
            ShowingOnLoad(comboboxMovie, datetimePicker, textboxTicketPrice);
        }
    }
}

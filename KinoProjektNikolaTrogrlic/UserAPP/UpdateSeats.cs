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
    public partial class UpdateSeats : Form
    {
        public Seat Seat { get; set; }

        public UpdateSeats(ref Seat seat)
        {
            Seat = seat;
            InitializeComponent();
        }

        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            Seat.SeatStatus = (SeatStatus)comboboxSeatStatus.SelectedItem;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void UpdateSeats_Load(object sender, EventArgs e)
        {
            labelSeat.Text = Seat.SeatNumber.ToString();
            comboboxSeatStatus.Items.Add(SeatStatus.Free);
            comboboxSeatStatus.Items.Add(SeatStatus.Taken);
            comboboxSeatStatus.Items.Add(SeatStatus.VIP);
            comboboxSeatStatus.Items.Add(SeatStatus.VIP_Taken);
            comboboxSeatStatus.Items.Add(SeatStatus.Broken);
            for(int i=0;i < comboboxSeatStatus.Items.Count;i++)
            {
                if((SeatStatus)comboboxSeatStatus.Items[i] == Seat.SeatStatus)
                {
                    comboboxSeatStatus.SelectedIndex = i;
                }
            }
        }
    }
}

using KinoProjektNikolaTrogrlic.Classes;
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
    public partial class ViewShowings : Form
    {

        public UserManagement UserManagement { get; set; }

        public ViewShowings(UserManagement userManagement)
        {
            InitializeComponent();
            UserManagement = userManagement;
        }

        private void ViewShowings_Load(object sender, EventArgs e)
        {

            datagridviewShowings.DataSource = LoadTable();
        }

        public DataTable LoadTable()
        {
            DataTable dt = new DataTable();

            DataColumn column0 = new DataColumn
            {
                DataType = Type.GetType("System.Int32"),
                AllowDBNull = false,
                Caption = "Index",
                ColumnName = "Index"
            };
            DataColumn column1 = new DataColumn
            {
                DataType = Type.GetType("System.String"),
                AllowDBNull = false,
                Caption = "Movie Shown",
                ColumnName = "Movie Shown"
            };
            DataColumn column2 = new DataColumn
            {
                DataType = Type.GetType("System.DateTime"),
                AllowDBNull = false,
                Caption = "Start Time",
                ColumnName = "Start Time"
            };
            DataColumn column3 = new DataColumn
            {
                DataType = Type.GetType("System.DateTime"),
                AllowDBNull = false,
                Caption = "End Time",
                ColumnName = "End Time"
            };
            DataColumn column4 = new DataColumn
            {
                DataType = Type.GetType("System.Int32"),
                AllowDBNull = true,
                Caption = "Seats Taken",
                ColumnName = "Seats Taken"
            };
            DataColumn column5 = new DataColumn
            {
                DataType = Type.GetType("System.Int32"),
                AllowDBNull = true,
                Caption = "Total Seats",
                ColumnName = "Total Seats"
            };
            DataColumn column6 = new DataColumn
            {
                DataType = Type.GetType("System.Double"),
                AllowDBNull = false,
                Caption = "Ticket Price",
                ColumnName = "Ticket Price"
            };
            dt.Columns.Add(column0);
            dt.Columns.Add(column1);
            dt.Columns.Add(column2);
            dt.Columns.Add(column3);
            dt.Columns.Add(column4);
            dt.Columns.Add(column5);
            dt.Columns.Add(column6);
            for (int i = 0; i < UserManagement.CurrentRoom.Showings.Count; i++)
            {
                MovieShowing showing = UserManagement.CurrentRoom.Showings[i];
                DataRow row = dt.NewRow();
                row["Index"] = i;
                row["Movie Shown"] = showing.MovieShown.Title;
                row["Start Time"] = showing.StartTime;
                row["End Time"] = showing.MovieEnding();
                row["Total Seats"] = showing.Seats.Count;
                row["Seats Taken"] = showing.Seats.Count(x => x.SeatStatus == SeatStatus.Taken);
                row["Ticket Price"] = showing.TicketPrice;
                dt.Rows.Add(row);
            }
            return dt;
        }

        private void DatagridviewShowings_RowHeaderDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(datagridviewShowings.Rows[e.RowIndex].Cells[0].Value);
                EditShowing showing = new EditShowing(UserManagement.Address, UserManagement.Port, UserManagement.CurrentRoom.SeatRows * UserManagement.CurrentRoom.SeatColumns, UserManagement, id);
                showing.ShowDialog();
                datagridviewShowings.DataSource = LoadTable();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

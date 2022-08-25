using KinoProjektNikolaTrogrlic.AdminAPP;
using KinoProjektNikolaTrogrlic.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace KinoProjektNikolaTrogrlic.UserAPP
{
    public partial class UserManagement : TranslatableForm
    {
        /*TCP*/
        User CurrentUser { get; set; }

        public string Address { get; set; }

        public int Port { get; set; }

        /*SHOWINGS AND ROOMS*/
        public CinemaRoom CurrentRoom { get; set; }

        public MovieShowing CurrentShowing { get; set; }

        public MovieShowing CurrentSelectedShowing { get; set; }

        public string CurrentFileSaveLocation { get; set; }

        public List<Color> Colors { get; set; }
        public UserManagement(User user, string address, int port)
        {
            InitializeComponent();
            CurrentUser = user;
            Address = address;
            Port = port;
        }

        /*ENCRYPTION*/
        public string Key {get; set;}

        private void UserManagement_Load(object sender, EventArgs e)
        {
            using (var ms = new MemoryStream(CurrentUser.ImageBytes))
            {
                Image image = Image.FromStream(ms, true);
                pictureboxPicture.Image = image;
            }
            labelName.Text = CurrentUser.Name();
            labelGender.Text = CurrentUser.Gender;
            Colors = new List<Color>
            {
                Color.Black,
                Color.Black,
                Color.Black,
                Color.Black,
                Color.Black
            };
            ReadWriteINIFiles iniFile = new ReadWriteINIFiles("Settings.ini");
            if (iniFile.KeyExists(buttonFree.Text, CurrentUser.Username))
            {
                Color newColor = Color.FromName(iniFile.Read(buttonFree.Text, CurrentUser.Username));
                Colors[0] = newColor;
                buttonFree.BackColor = Colors[0];
                labelSeatFree.BackColor = Colors[0];
            }
            if (iniFile.KeyExists(buttonTaken.Text, CurrentUser.Username))
            {
                Colors[1] = Color.FromName(iniFile.Read(buttonTaken.Text, CurrentUser.Username));
                buttonTaken.BackColor = Colors[1];
                labelSeatTaken.BackColor = Colors[1];
            }
            if (iniFile.KeyExists(buttonVIP.Text, CurrentUser.Username))
            {
                Colors[2] = Color.FromName(iniFile.Read(buttonVIP.Text, CurrentUser.Username));
                buttonVIP.BackColor = Colors[2];
                labelSeatVIP.BackColor = Colors[2];
            }
            if (iniFile.KeyExists(buttonVIP_Taken.Text, CurrentUser.Username))
            {
                Colors[3] = Color.FromName(iniFile.Read(buttonVIP_Taken.Text, CurrentUser.Username));
                buttonVIP_Taken.BackColor = Colors[3];
                labelSeatVIPTaken.BackColor = Colors[3];
            }
            if (iniFile.KeyExists(buttonBroken.Text, CurrentUser.Username))
            {
                Colors[4] = Color.FromName(iniFile.Read(buttonBroken.Text, CurrentUser.Username));
                buttonBroken.BackColor = Colors[4];
                labelSeatBroken.BackColor = Colors[4];
            }
        }

        private void Tabcontrol_SelectedIndexChanged(Object sender, EventArgs e)
        {

            int index = tabcontrol.SelectedIndex;
            switch (index)
            {
                /*OVERVIEW*/
                case 0:
                    UpdateOverview();
                    break;
                /*ROOM*/
                case 2:
                    labelSeatFree.BackColor = Colors[0];
                    labelSeatTaken.BackColor = Colors[1];
                    labelSeatVIP.BackColor = Colors[2];
                    labelSeatVIPTaken.BackColor = Colors[3];
                    labelSeatBroken.BackColor = Colors[4];
                    break;
                /*CRERATE/EDIT ROOM*/
                case 3:
                    if (CurrentRoom == null)
                    {
                        CurrentRoom = new CinemaRoom();
                    }
                    break;
            }
        }

        /*USER INFO*/
        private void CheckboxEncrypt_CheckedChanged(object sender, EventArgs e)
        {
            if (checkboxEncrypt.Checked)
            {
                textboxKey.Enabled = true;
            }
            else
            {
                textboxKey.Enabled = false;
            }
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            ReadWriteINIFiles iniFile = new ReadWriteINIFiles("Settings.ini");
            if (checkboxEncrypt.Checked)
            {
                if (!String.IsNullOrEmpty(textboxKey.Text))
                {
                    iniFile.Write("Certificate", "True", CurrentUser.Username);
                    byte[] salt = EncryptionManager.CreateSalt(33);
                    iniFile.Write("Salt", Convert.ToBase64String(salt), CurrentUser.Username);
                    iniFile.Write("CertificateKey", Convert.ToBase64String(EncryptionManager.GenerateSaltedHash(textboxKey.Text,salt)), CurrentUser.Username);
                    MessageBox.Show(TranslatableString("Encryption information saved.", "Spremljeni enkripcijski podatci."));
                }
            }
            else
            {
                iniFile.Write("Certificate", "False", CurrentUser.Username);
            }
        }

        /*OVERVIEW*/

        private void UpdateOverview()
        {
            if (CurrentRoom != null)
            {
                labelCurrentName.Text = CurrentRoom.Name;
                listviewUpcoming.Clear();
                if (CurrentRoom.Showings != null)
                {
                    MovieShowing currentlyShowing = null;
                    listviewUpcoming.Columns.Add(TranslatableString("Title", "Ime"));
                    listviewUpcoming.Columns.Add(TranslatableString("Ticket price", "Cijena ulaznica"));
                    listviewUpcoming.Columns.Add(TranslatableString("Starting time", "Vrijeme početka"));
                    listviewUpcoming.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.HeaderSize);
                    listviewUpcoming.AutoResizeColumn(1, ColumnHeaderAutoResizeStyle.HeaderSize);
                    listviewUpcoming.AutoResizeColumn(2, ColumnHeaderAutoResizeStyle.HeaderSize);
                    CurrentRoom.Showings.Sort((showing1, showing2) => DateTime.Compare(showing1.StartTime, showing2.StartTime));
                    foreach (MovieShowing showing in CurrentRoom.Showings)
                    {
                        ListViewItem item = new ListViewItem
                        {
                            Text = showing.MovieShown.Title
                        };
                        item.SubItems.Add(showing.TicketPrice.ToString());
                        item.SubItems.Add(showing.StartTime.ToShortTimeString());
                        if (showing.StartTime.Date == DateTime.Now.Date || showing.MovieEnding() == DateTime.Now.Date)
                        {
                            if (showing.StartTime.TimeOfDay <= DateTime.Now.TimeOfDay && DateTime.Now.TimeOfDay <= showing.MovieEnding().TimeOfDay)
                            {
                                currentlyShowing = showing;
                            }
                            else
                            {
                                listviewUpcoming.Items.Add(item);
                            }
                        }
                        else if(showing.StartTime.Date >= DateTime.Now.Date)
                        {
                            listviewUpcoming.Items.Add(item);
                        }
                    }
                    CurrentShowing = currentlyShowing;
                    if (currentlyShowing != null)
                    {
                        labelSeatNum.Text = currentlyShowing.Seats.Count(x => x.SeatStatus == SeatStatus.Taken).ToString() + "/" + currentlyShowing.Seats.Count.ToString();
                        labelCurrentMovieTitle.Text = currentlyShowing.MovieShown.Title;
                        if (currentlyShowing.TicketPrice == 0)
                        {
                            labelCurrentMovieTicketCost.Text = "Free";
                        }
                        else
                        {
                            labelCurrentMovieTicketCost.Text = currentlyShowing.TicketPrice.ToString();
                        }
                    }
                }
            }
        }

        /*CREATE/EDIT*/
        private void ButtonAddShowing_Click(object sender, EventArgs e)
        {
            AddShowing dialog = new AddShowing(Address, Port, Convert.ToInt32(numericSeatRows.Value) * Convert.ToInt32(numericSeatColumns.Value), this);
            dialog.ShowDialog();
            labelNumShowings.Text = CurrentRoom.Showings.Count.ToString();
            if (CurrentRoom.Showings.Count > 0)
            {
                numericSeatRows.Enabled = false;
                numericSeatColumns.Enabled = false;
                RefillShowings();
            }
        }

        private void NumericSeatRows_ValueChanged(object sender, EventArgs e)
        {
            if (numericSeatRows.Value > 0)
            {
                CurrentRoom.SeatRows = Convert.ToInt32(numericSeatColumns.Value);
            }
        }

        private void NumericSeatColumns_ValueChanged(object sender, EventArgs e)
        {
            if (numericSeatColumns.Value > 0)
            {
                CurrentRoom.SeatColumns = Convert.ToInt32(numericSeatColumns.Value);
            }
        }

        private void TextboxRoomName_TextChanged(object sender, EventArgs e)
        {
            CurrentRoom.Name = textboxRoomName.Text;
        }

        private void ButtonViewShowings_Click(object sender, EventArgs e)
        {
            ViewShowings dialog = new ViewShowings(this);
            dialog.ShowDialog();
            labelNumShowings.Text = CurrentRoom.Showings.Count.ToString();
            if (CurrentRoom.Showings.Count > 0)
            {
                numericSeatRows.Enabled = false;
                numericSeatColumns.Enabled = false;
                RefillShowings();
            }
            else
            {
                numericSeatRows.Enabled = true;
                numericSeatColumns.Enabled = true;
            }
        }

        private void ButtonSaveCurrent_Click(object sender, EventArgs e)
        {
            try
            {
                if (CurrentRoom.SeatRows <= 0 || CurrentRoom.SeatColumns <= 0)
                    throw new Exception(TranslatableString("Invalid column or row number", "Neispravan broj redova ili stupaca."));
                if (CurrentRoom.Showings == null)
                    throw new Exception(TranslatableString("Showings List can't be null.", "Lista prikazivanja ne može biti null"));
                if (String.IsNullOrEmpty(CurrentRoom.Name))
                    throw new Exception(TranslatableString("Room needs to have a name", "Soba treba imati ime."));
                XmlSerializer xsSubmit = new XmlSerializer(typeof(CinemaRoom));
                CurrentRoom.SeatRows = Convert.ToInt32(numericSeatRows.Value);
                CurrentRoom.SeatColumns = Convert.ToInt32(numericSeatColumns.Value);
                CurrentRoom.Name = textboxRoomName.Text;
                using (SaveFileDialog dlg = new SaveFileDialog())
                {
                    dlg.Title = "Save Room";
                    dlg.Filter = "XML file|*.xml";
                    dlg.DefaultExt = "xml";

                    if (dlg.ShowDialog() == DialogResult.OK)
                    {
                        using (FileStream sw = File.Create(dlg.FileName))
                        {
                            CurrentFileSaveLocation = dlg.FileName;
                            xsSubmit.Serialize(sw, CurrentRoom);
                        }
                        ReadWriteINIFiles iniFile = new ReadWriteINIFiles("Settings.ini");
                        if (iniFile.KeyExists("Certificate", CurrentUser.Username))
                        {
                            if (Convert.ToBoolean(iniFile.Read("Certificate", CurrentUser.Username)))
                            {
                                CspParameters cspParams = new CspParameters
                                {
                                    KeyContainerName = iniFile.Read("CertificateKey", CurrentUser.Username)
                                };


                                RSACryptoServiceProvider rsaKey = new RSACryptoServiceProvider(cspParams);


                                XmlDocument xmlDoc = new XmlDocument
                                {
                                    PreserveWhitespace = true
                                };
                                xmlDoc.Load(dlg.FileName);

                                EncryptionManager.SignXml(xmlDoc, rsaKey);

                                xmlDoc.Save(dlg.FileName);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ButtonLoadRoom_Click(object sender, EventArgs e)
        {
            try
            {
                XmlSerializer xsOpen = new XmlSerializer(typeof(CinemaRoom));
                using (OpenFileDialog dlg = new OpenFileDialog())
                {
                    dlg.Title = "Save Room";
                    dlg.Filter = "XML file|*.xml";
                    dlg.DefaultExt = "xml";

                    if (dlg.ShowDialog() == DialogResult.OK)
                    {
                        using (StreamReader sw = new StreamReader(dlg.FileName))
                        {
                            ReadWriteINIFiles iniFile = new ReadWriteINIFiles("Settings.ini");
                            if (iniFile.KeyExists("Certificate", CurrentUser.Username))
                            {
                                if (Convert.ToBoolean(iniFile.Read("Certificate", CurrentUser.Username)))
                                {
                                    CspParameters cspParams = new CspParameters();
                                    string key= iniFile.Read("CertificateKey", CurrentUser.Username);

                                    EnterKey dialog = new EnterKey(this, "UserXML");
                                    dialog.ShowDialog();
                                    if (dialog.DialogResult == DialogResult.OK)
                                    {
                                        if (EncryptionManager.CheckHashMatch(key, Key, iniFile.Read("Salt", CurrentUser.Username))){
                                            cspParams.KeyContainerName = key;
                                            RSACryptoServiceProvider rsaKey = new RSACryptoServiceProvider(cspParams);

                                            XmlDocument xmlDoc = new XmlDocument
                                            {
                                                PreserveWhitespace = true
                                            };
                                            xmlDoc.Load(dlg.FileName);

                                            bool result = EncryptionManager.VerifyXml(xmlDoc, rsaKey);

                                            /*DESERIALIZATION*/
                                            CurrentRoom = (CinemaRoom)xsOpen.Deserialize(sw);
                                            if (CurrentRoom.Showings.Count > 0)
                                            {
                                                numericSeatColumns.Enabled = false;
                                                numericSeatRows.Enabled = false;
                                            }
                                            CurrentFileSaveLocation = dlg.FileName;
                                            textboxRoomName.Text = CurrentRoom.Name;
                                            numericSeatColumns.Value = CurrentRoom.SeatColumns;
                                            numericSeatRows.Value = CurrentRoom.SeatRows;
                                            labelNumShowings.Text = CurrentRoom.Showings.Count.ToString();
                                            if (CurrentRoom.Showings.Count > 0)
                                            {
                                                comboboxShowing.Items.Clear();
                                                foreach (MovieShowing showing in CurrentRoom.Showings)
                                                {
                                                    comboboxShowing.Items.Add(showing);
                                                    comboboxShowing.DisplayMember = "StartTime";
                                                }
                                                if (comboboxShowing.Items.Count > 0)
                                                {
                                                    comboboxShowing.SelectedIndex = 0;
                                                }
                                            }

                                            if (result)
                                            {
                                                MessageBox.Show(TranslatableString("Sucessfully loaded.", "Uspiješno učitano."));
                                            }
                                            else
                                            {
                                                throw new Exception(TranslatableString("Failed to validate document. Was the document changed without permission?", "Neuspjela validacija dokumenta. Da li je dokument mijenjan bez dopuštenja?"));
                                            }
                                        }
                                        else
                                        {
                                            throw new Exception(TranslatableString("Invalid key entered","Neispravan ključ unesen"));
                                        }
                                    }

                                }
                                else
                                {
                                    CurrentRoom = (CinemaRoom)xsOpen.Deserialize(sw);
                                    if (CurrentRoom.Showings.Count > 0)
                                    {
                                        numericSeatColumns.Enabled = false;
                                        numericSeatRows.Enabled = false;
                                    }
                                    CurrentFileSaveLocation = dlg.FileName;
                                    textboxRoomName.Text = CurrentRoom.Name;
                                    numericSeatColumns.Value = CurrentRoom.SeatColumns;
                                    numericSeatRows.Value = CurrentRoom.SeatRows;
                                    labelNumShowings.Text = CurrentRoom.Showings.Count.ToString();
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /*COLOR BUTTONS*/
        private void ButtonFree_Click(object sender, EventArgs e)
        {
            ChangeSeatColor(buttonFree, 0);
        }

        private void ButtonTaken_Click(object sender, EventArgs e)
        {
            ChangeSeatColor(buttonTaken, 1);
        }

        private void ButtonVIP_Click(object sender, EventArgs e)
        {
            ChangeSeatColor(buttonVIP, 2);
        }

        private void ButtonVIP_Taken_Click(object sender, EventArgs e)
        {
            ChangeSeatColor(buttonVIP_Taken, 3);
        }

        private void ButtonBroken_Click(object sender, EventArgs e)
        {
            ChangeSeatColor(buttonBroken, 4);
        }

        private void ChangeSeatColor(Button buttonProfile, int colorNumber)
        {
            ReadWriteINIFiles iniFile = new ReadWriteINIFiles("Settings.ini");
            ColorDialog colorDialog = new ColorDialog
            {
                SolidColorOnly = true
            };
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                iniFile.Write(buttonProfile.Text, colorDialog.Color.Name.ToString(), CurrentUser.Username);
                buttonProfile.BackColor = colorDialog.Color;
                Colors[colorNumber] = colorDialog.Color;
            }
        }

        private void ComboboxShowing_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (CurrentRoom != null)
                {
                    CurrentSelectedShowing = (MovieShowing)comboboxShowing.SelectedItem;
                    labelSelectedShowingMovie.Text = CurrentSelectedShowing.MovieShown.Title;
                    //datagridviewSeats = new DataGridView();
                    datagridviewSeats.RowHeadersVisible = false;
                    datagridviewSeats.ColumnHeadersVisible = false;
                    datagridviewSeats.Visible = false;
                    datagridviewSeats.Visible = true;
                    DataTable seatGrid = new DataTable();
                    for (int i = 0; i < CurrentRoom.SeatColumns; i++)
                    {
                        seatGrid.Columns.Add(i.ToString());
                    }
                    for (int j = 0; j < CurrentRoom.SeatRows; j++)
                    {
                        seatGrid.Rows.Add();
                    }
                    int k = 0;
                    for (int i = 0; i < CurrentRoom.SeatColumns; i++)
                    {
                        for (int j = 0; j < CurrentRoom.SeatRows; j++)
                        {
                            seatGrid.Rows[j][i] = CurrentSelectedShowing.Seats[k + j].SeatNumber;
                        }
                        k = (CurrentRoom.SeatRows * (i + 1));
                    }
                    datagridviewSeats.DataSource = null;
                    datagridviewSeats.Refresh();
                    datagridviewSeats.DataSource = seatGrid;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RefillShowings()
        {
            comboboxShowing.Items.Clear();
            foreach (MovieShowing showing in CurrentRoom.Showings)
            {
                comboboxShowing.Items.Add(showing);
                comboboxShowing.DisplayMember = "StartTime";
                comboboxShowing.SelectedIndex = 0;
            }
        }
        private void DatagridviewSeats_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                int seatnumber = Convert.ToInt32(datagridviewSeats.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                for (int i = 0; i < CurrentSelectedShowing.Seats.Count; i++)
                {
                    if (CurrentSelectedShowing.Seats[i].SeatNumber == Convert.ToInt32(seatnumber))
                    {
                        Seat seat = CurrentSelectedShowing.Seats[i];
                        UpdateSeats dialog = new UpdateSeats(ref seat);
                        dialog.ShowDialog();
                        if (dialog.DialogResult == DialogResult.OK)
                        {
                            datagridviewSeats.Refresh();
                            CurrentRoom.Showings.Find(showing => showing.StartTime == CurrentSelectedShowing.StartTime).Seats[i].SeatStatus = seat.SeatStatus;
                        }
                    }
                }
            }
        }

        private void DatagridviewSeats_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                int seatnumber = Convert.ToInt32(datagridviewSeats.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                for (int i = 0; i < CurrentSelectedShowing.Seats.Count; i++)
                {
                    if (CurrentSelectedShowing.Seats[i].SeatNumber == Convert.ToInt32(seatnumber))
                    {
                        Color color = Color.White;
                        switch (CurrentSelectedShowing.Seats[i].SeatStatus)
                        {
                            case SeatStatus.Free:
                                color = Colors[0];
                                break;
                            case SeatStatus.Taken:
                                color = Colors[1];
                                break;
                            case SeatStatus.VIP:
                                color = Colors[2];
                                break;
                            case SeatStatus.VIP_Taken:
                                color = Colors[3];
                                break;
                            case SeatStatus.Broken:
                                color = Colors[4];
                                break;
                        }
                        datagridviewSeats.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = color;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

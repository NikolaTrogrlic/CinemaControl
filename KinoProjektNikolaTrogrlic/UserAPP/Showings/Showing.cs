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
    public partial class Showing : TranslatableForm
    {
        /*MOVIESHOWING*/
        public Movie MovieShown { get; set; }
        public double TicketPrice { get; set; }
        public int Seats { get; set; }
        public string Address { get; set; }

        /*TCP*/
        public UserManagement UserManagement { get; set; }

        public int Port { get; set; }

        public SimpleTcpClient Client { get; set; }


        /*ELEMENTS*/
        public ComboBox ComboBoxMovie { get; set; }
        public DateTimePicker DateTimePicker { get; set; }

        public TextBox TicketPriceBox { get; set; }

        public Showing()
        {
            InitializeComponent();
        }

        public Showing(string address, int port, int seats, UserManagement mainForm)
        {
            Address = address;
            Port = port;
            Client = new SimpleTcpClient
            {
                StringEncoder = Encoding.UTF8
            };
            Client.DataReceived += Client_DataReceived;
            Seats = seats;
            UserManagement = mainForm;

        }

        protected void ShowingOnLoad(ComboBox combobox, DateTimePicker datetimepicker, TextBox ticketbox,MovieShowing showing = null )
        {
            ComboBoxMovie = combobox;
            DateTimePicker = datetimepicker;
            TicketPriceBox = ticketbox;
            ComboBoxMovie.SelectedIndex = -1;
            DateTimePicker.Format = DateTimePickerFormat.Custom;
            DateTimePicker.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            DateTimePicker.ShowUpDown = true;
            if(showing != null)
            {
                ComboBoxMovie.Items.Add(showing.MovieShown);
                ComboBoxMovie.DisplayMember = "Title";
                ComboBoxMovie.SelectedIndex = 0;
                DateTimePicker.Value = showing.StartTime;
                TicketPriceBox.Text = showing.TicketPrice.ToString();
            }
        }

        protected void Client_DataReceived(object sender, SimpleTCP.Message e)
        {
            try
            {
                List<Movie> movies = JsonConvert.DeserializeObject<List<Movie>>(e.MessageString);
                if (movies.Count > 0)
                {
                    ComboBoxMovie.Invoke((MethodInvoker)delegate
                    {
                        ComboBoxMovie.SelectedIndex = -1;
                        ComboBoxMovie.Items.Clear();
                        foreach (Movie movie in movies)
                        {
                            ComboBoxMovie.Items.Add(movie);
                        }
                        ComboBoxMovie.DisplayMember = "Title";
                        ComboBoxMovie.SelectedIndex = 0;
                    });
                }
                else
                {
                    this.Invoke((MethodInvoker)delegate {
                        MessageBox.Show("Didn't recieve any movies");
                    });
                }

            }
            catch (Exception ex)
            {
                this.Invoke((MethodInvoker)delegate {
                    MessageBox.Show(ex.Message);
                });
            }
        }

        protected void ButtonGetMoviesClick(object sender, EventArgs e)
        {
            try
            {
                Client.Connect(Address, Port);
                Client.Write("SEND MOVIES");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        protected void ButtonVerifyShowing(Action<MovieShowing> doWithData)
        {
            try
            {
                if (ComboBoxMovie.SelectedIndex != -1)
                {
                    MovieShown = (Movie)ComboBoxMovie.SelectedItem;
                }
                else
                {
                    throw new Exception(TranslatableString("Choose a movie.","Izaberite film."));
                }
                if (!String.IsNullOrEmpty(TicketPriceBox.Text))
                {
                    if (double.TryParse(TicketPriceBox.Text, out double ticketPrice))
                    {
                        if (ticketPrice < 0)
                        {
                            throw new Exception("Ticket price can't be negative number");
                        }
                        else if(ticketPrice == 0)
                        {
                            TicketPrice = ticketPrice;
                            MessageBox.Show(TranslatableString("Ticket price set to free because field was empty.", "Cijena karte postavljena na besplatno jer je polje bilo prazno."));
                        }
                        else
                        {
                            TicketPrice = ticketPrice;
                        }
                    }
                    else
                    {
                        throw new Exception(TranslatableString("Input valid ticket price (a number)","Ubacite ispavnu cijenu (broj)"));
                    }
                }
                else
                {
                    MessageBox.Show(TranslatableString("Ticket price set to free because field was empty.", "Cijena karte postavljena na besplatno jer je polje bilo prazno."));
                }
                MovieShowing showing = new MovieShowing(MovieShown, DateTimePicker.Value, Seats, TicketPrice);
                if (AllowedTime(showing))
                {
                    doWithData(showing);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show(TranslatableString("Movie overlaps with another movie, try changing start time.","Početak filma se kosi sa nekim drugim filmom. Pokušajte ponovno."));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public bool AllowedTime(MovieShowing showingToAdd)
        {
            List<MovieShowing> showings = UserManagement.CurrentRoom.Showings;
            foreach (MovieShowing showing in showings)
            {
                if (showing.MovieShown.Title != showingToAdd.MovieShown.Title)
                {
                    if (showing.StartTime.Date == showingToAdd.StartTime.Date)
                    {
                        if (showing.StartTime.TimeOfDay <= showingToAdd.StartTime.TimeOfDay && showingToAdd.StartTime.TimeOfDay <= showing.MovieEnding().TimeOfDay)
                        {
                            return false;
                        }
                        if (showing.StartTime.TimeOfDay <= showingToAdd.MovieEnding().TimeOfDay && showingToAdd.MovieEnding().TimeOfDay <= showing.MovieEnding().TimeOfDay)
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }
    }
}

using KinoProjektNikolaTrogrlic.Classes;
using Movies;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KinoProjektNikolaTrogrlic.AdminAPP
{
    
    public partial class MovieCRUD : TranslatableForm
    {
        /*SQL*/
        public DatabaseManager Db { get; set; }


        /*REST CLIENT*/
        public RestClient RestClient { get; set; }

        protected string ApiKey { get; set; }
        protected string RestClientString { get; set; }

        /*ELEMENTS*/
        ComboBox ComboBoxCategory { get; set; }
        TextBox TextBoxTitle { get; set; }
        TextBox TextBoxDescription { get; set; }
        NumericUpDown NumericHours { get; set; }
        NumericUpDown NumericMinutes { get; set; }
        NumericUpDown NumericSeconds { get; set; }
        Button ButtonLookup { get; set; }

        public MovieCRUD()
        {
            InitializeComponent();
        }

        public MovieCRUD(DatabaseManager db)
        {
            InitializeComponent();

            Db = db;

            if (AdminManagement.CheckIfSettingsKeyPresent("OMDBApiKey"))
            {
                ApiKey = AdminManagement.GetSettingsKey("OMDBApiKey");
                RestClientString = "http://www.omdbapi.com/?apikey=" + ApiKey + "&t=";
                var options = new RestClientOptions(RestClientString)
                {
                    ThrowOnAnyError = true,
                    MaxTimeout = 4000
                };
                RestClient = new RestClient(options);
            }
            else
            {
                ApiKey = "";
            }
        }

        protected void OnLoad(ComboBox categoryComboBox,TextBox textboxTitle,
            TextBox textboxDescription, NumericUpDown numericHours,
            NumericUpDown numericMinutes, NumericUpDown numericSeconds,
            Button buttonLookup,Movie movie = null)
        {
            TextBoxTitle = textboxTitle;
            TextBoxDescription = textboxDescription;
            NumericHours = numericHours;
            NumericMinutes = numericMinutes;
            NumericSeconds = numericSeconds;
            ButtonLookup = buttonLookup;

            ComboBoxCategory = categoryComboBox;
            List<string> categories = Db.LoadCategories();
            for (int i = 0; i < categories.Count; i++)
            {
                ComboBoxCategory.Items.Add(categories[i]);
                if (movie != null)
                {
                    if (categories[i] == movie.Category)
                    {
                        ComboBoxCategory.SelectedIndex = i;
                    }
                }
            }
            ComboBoxCategory.SelectedIndex = 0;
        }

        protected void OnVerifyMovie(Action<Movie> action)
        {
            try
            {
                string category = ComboBoxCategory.Text;
                if (!String.IsNullOrEmpty(TextBoxTitle.Text))
                {
                    Movie movie = new Movie(
                        TextBoxTitle.Text,
                        category,
                        TextBoxDescription.Text,
                        Convert.ToInt32(NumericHours.Value),
                        Convert.ToInt32(NumericMinutes.Value),
                        Convert.ToInt32(NumericSeconds.Value));
                    action(movie);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        protected async void ButtonLookupClick(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(ApiKey))
            {
                if (!String.IsNullOrEmpty(TextBoxTitle.Text))
                {
                    try
                    {
                        ButtonLookup.Enabled = false;
                        RestClientString = "http://www.omdbapi.com/?apikey=" + ApiKey + "&t=";
                        RestRequest request = new RestRequest(RestClientString + TextBoxTitle.Text);
                        RestResponse response = await RestClient.GetAsync(request);
                        var movieObject = JsonSerializer.Deserialize<Root>(response.Content);
                        TextBoxTitle.Text = movieObject.Title;
                        TextBoxDescription.Text = movieObject.Plot;
                        ComboBoxCategory.Text = movieObject.Genre;

                        /*Remove the " min" part of the runtime string*/
                        if (movieObject.Runtime != null)
                        {
                            int runtime = Convert.ToInt32(movieObject.Runtime.Remove(movieObject.Runtime.Length - 4));
                            NumericHours.Value = Convert.ToInt32(runtime) / 60;
                            NumericMinutes.Value = Convert.ToInt32(runtime) % 60;
                        }
                        ButtonLookup.Enabled = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show(TranslatableString("Please enter a valid APIKey in admin settings.", "Molimo unesite ispravan API ključ prije korištenja."));
            }
        }


        /*JSON DESERIALIZATION*/
        public class Rating
        {
            public string Source { get; set; }
            public string Value { get; set; }
        }
        public class Root
        {
            public string Title { get; set; }
            public string Year { get; set; }
            public string Rated { get; set; }
            public string Released { get; set; }
            public string Runtime { get; set; }
            public string Genre { get; set; }
            public string Director { get; set; }
            public string Writer { get; set; }
            public string Actors { get; set; }
            public string Plot { get; set; }
            public string Language { get; set; }
            public string Country { get; set; }
            public string Awards { get; set; }
            public string Poster { get; set; }
            public List<Rating> Ratings { get; set; }
            public string Metascore { get; set; }
            #pragma warning disable IDE1006
            public string imdbRating { get; set; }
            public string imdbVotes { get; set; }
            public string imdbID { get; set; }
            public string Type { get; set; }
            public string DVD { get; set; }
            public string BoxOffice { get; set; }
            public string Production { get; set; }
            public string Website { get; set; }
            public string Response { get; set; }
        }
    }
    
}

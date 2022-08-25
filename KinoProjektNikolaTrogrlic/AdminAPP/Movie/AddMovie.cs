using KinoProjektNikolaTrogrlic.AdminAPP;
using KinoProjektNikolaTrogrlic.Classes;
using Movies;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Windows.Forms;

namespace KinoProjektNikolaTrogrlic
{
    public partial class AddMovie : MovieCRUD
    {
        public AddMovie(DatabaseManager db) : base(db)
        {
            InitializeComponent();
        }

        private void AddMovie_Load(object sender, EventArgs e)
        {
            OnLoad(comboboxCategory, textboxTitle, textboxDescription, numericHours, numericMinutes, numericSeconds, buttonLookup);
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            OnVerifyMovie((movie) =>
            {
                string result = Db.AddMovieToDB(movie);
                MessageBox.Show(result);
            });
        }

        private void ButtonLookup_Click(object sender, EventArgs e)
        {
            ButtonLookupClick(sender, e);
        }
    }
}

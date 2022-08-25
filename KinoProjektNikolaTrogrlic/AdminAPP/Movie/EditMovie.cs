using ConfirmationDialog;
using KinoProjektNikolaTrogrlic.AdminAPP;
using KinoProjektNikolaTrogrlic.Classes;
using Movies;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace KinoProjektNikolaTrogrlic
{
    public partial class EditMovie : MovieCRUD
    {
        private int Id { get; set; }
        private Movie Movie { get; set; }
        public EditMovie(int id, DatabaseManager db):base(db)
        {
            InitializeComponent();
            Id = id;
        }

        private void EditMovie_Load(object sender, EventArgs e)
        {
            Movie = Db.GetMovieById(Id);
            OnLoad(comboboxCategory, textboxTitle, textboxDescription, numericHours, numericMinutes, numericSeconds, buttonLookup, Movie);
            if (Movie != null)
            {
                textboxDescription.Text = Movie.Description;
                textboxTitle.Text = Movie.Title;
                numericHours.Value = Movie.DurationHours;
                numericMinutes.Value = Movie.DurationMinutes;
                numericSeconds.Value = Movie.DurationSeconds;
            }
        }

        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            OnVerifyMovie((movie) =>
            {
                string result = Db.UpdateMovie(Id, movie);
                MessageBox.Show(result);
            });
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            Confirm confirm = new Confirm(TranslatableString("Delete this movie?", "Izbrisati film?"));
            confirm.ShowDialog();
            if (confirm.DialogResult == DialogResult.Yes)
            {
                string result = Db.DeleteFromDB(Id, "Movies");
                if (result == "Deleted")
                {
                    this.Close();
                }
            }
        }

        private void ButtonLookup_Click(object sender, EventArgs e)
        {
            ButtonLookupClick(sender, e);
        }
    }
}

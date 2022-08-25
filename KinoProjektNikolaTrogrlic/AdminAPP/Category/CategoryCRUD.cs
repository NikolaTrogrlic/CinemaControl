using KinoProjektNikolaTrogrlic.Classes;
using Movies;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KinoProjektNikolaTrogrlic.AdminAPP.Category
{
    public partial class CategoryCRUD : TranslatableForm
    {
        /*SQL*/
        public DatabaseManager Db { get; set; }

        /*ELEMENTS*/
        TextBox TextBoxName { get; set; }
        TextBox TextBoxDescription { get; set; }
        public CategoryCRUD()
        {
            InitializeComponent();
        }
        public CategoryCRUD(DatabaseManager db)
        {
            InitializeComponent();
            Db = db;
        }

        protected void OnLoad(TextBox textboxName,TextBox textboxDescription,MovieCategory category = null)
        {
            TextBoxName = textboxName;
            TextBoxDescription = textboxDescription;
            if(category != null) {
                TextBoxName.Text = category.Name;
                TextBoxDescription.Text = category.Description;
            }
        }

        protected void OnVerifyCategory(Action<MovieCategory> action)
        {
            try
            {
                if (!String.IsNullOrEmpty(TextBoxName.Text))
                {
                    MovieCategory category = new MovieCategory()
                    {
                        Name = TextBoxName.Text,
                        Description = TextBoxDescription.Text
                    };
                    action(category);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

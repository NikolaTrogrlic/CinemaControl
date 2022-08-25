using ConfirmationDialog;
using KinoProjektNikolaTrogrlic.AdminAPP.Category;
using KinoProjektNikolaTrogrlic.Classes;
using Movies;
using System;
using System.Windows.Forms;

namespace KinoProjektNikolaTrogrlic.AdminAPP
{
    public partial class EditCategory : CategoryCRUD
    {
        private int Id { get; set; }
        public EditCategory(int id, DatabaseManager db): base(db)
        {
            InitializeComponent();
            Id = id;
        }

        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            OnVerifyCategory((category) =>
            {
                string result = Db.UpdateCategory(Id, category);
                MessageBox.Show(result);
            });
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            Confirm confirm = new Confirm(TranslatableString("Delete this category?","Izbrisati ovu kategoriju?"));
            confirm.ShowDialog();
            if (confirm.DialogResult == DialogResult.Yes)
            {
                string result = Db.DeleteFromDB(Id, "Categories");
                if (result == "Deleted")
                {
                    this.Close();
                }
            }
        }

        private void EditCategory_Load(object sender, EventArgs e)
        {
            try
            {
                OnLoad(textboxName, textboxDescription, Db.GetCategoryById(Id));
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

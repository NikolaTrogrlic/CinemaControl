using KinoProjektNikolaTrogrlic.AdminAPP.Category;
using KinoProjektNikolaTrogrlic.Classes;
using Movies;
using System;
using System.Windows.Forms;

namespace KinoProjektNikolaTrogrlic.AdminAPP
{
    public partial class AddCategory : CategoryCRUD
    {
        public AddCategory(DatabaseManager db):base(db)
        {
            InitializeComponent();
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            OnVerifyCategory((category) =>
            {
                string result = Db.AddCategoryToDB(category);
                MessageBox.Show(result);
            });
        }

        private void AddCategory_Load(object sender, EventArgs e)
        {
            OnLoad(textboxName, textboxDescription);
        }
    }
}

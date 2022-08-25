namespace KinoProjektNikolaTrogrlic.AdminAPP
{
    partial class AddCategory
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCategory));
            this.textboxDescription = new System.Windows.Forms.TextBox();
            this.labelMovieDescription = new System.Windows.Forms.Label();
            this.textboxName = new System.Windows.Forms.TextBox();
            this.labelMovieTitle = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textboxDescription
            // 
            resources.ApplyResources(this.textboxDescription, "textboxDescription");
            this.textboxDescription.Name = "textboxDescription";
            // 
            // labelMovieDescription
            // 
            resources.ApplyResources(this.labelMovieDescription, "labelMovieDescription");
            this.labelMovieDescription.Name = "labelMovieDescription";
            // 
            // textboxName
            // 
            resources.ApplyResources(this.textboxName, "textboxName");
            this.textboxName.Name = "textboxName";
            // 
            // labelMovieTitle
            // 
            resources.ApplyResources(this.labelMovieTitle, "labelMovieTitle");
            this.labelMovieTitle.Name = "labelMovieTitle";
            // 
            // buttonAdd
            // 
            resources.ApplyResources(this.buttonAdd, "buttonAdd");
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // AddCategory
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textboxDescription);
            this.Controls.Add(this.labelMovieDescription);
            this.Controls.Add(this.textboxName);
            this.Controls.Add(this.labelMovieTitle);
            this.Name = "AddCategory";
            this.Load += new System.EventHandler(this.AddCategory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textboxDescription;
        private System.Windows.Forms.Label labelMovieDescription;
        private System.Windows.Forms.TextBox textboxName;
        private System.Windows.Forms.Label labelMovieTitle;
        private System.Windows.Forms.Button buttonAdd;
    }
}
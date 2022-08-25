namespace KinoProjektNikolaTrogrlic.AdminAPP
{
    partial class EditCategory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditCategory));
            this.buttonEdit = new System.Windows.Forms.Button();
            this.textboxDescription = new System.Windows.Forms.TextBox();
            this.labelMovieDescription = new System.Windows.Forms.Label();
            this.textboxName = new System.Windows.Forms.TextBox();
            this.labelMovieTitle = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonEdit
            // 
            resources.ApplyResources(this.buttonEdit, "buttonEdit");
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.ButtonEdit_Click);
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
            // buttonDelete
            // 
            resources.ApplyResources(this.buttonDelete, "buttonDelete");
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // EditCategory
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.textboxDescription);
            this.Controls.Add(this.labelMovieDescription);
            this.Controls.Add(this.textboxName);
            this.Controls.Add(this.labelMovieTitle);
            this.Name = "EditCategory";
            this.Load += new System.EventHandler(this.EditCategory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.TextBox textboxDescription;
        private System.Windows.Forms.Label labelMovieDescription;
        private System.Windows.Forms.TextBox textboxName;
        private System.Windows.Forms.Label labelMovieTitle;
        private System.Windows.Forms.Button buttonDelete;
    }
}
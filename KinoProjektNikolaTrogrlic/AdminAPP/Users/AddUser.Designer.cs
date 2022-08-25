namespace KinoProjektNikolaTrogrlic.AdminAPP
{
    partial class AddUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUser));
            this.labelUsername = new System.Windows.Forms.Label();
            this.textboxUser = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textboxPassword = new System.Windows.Forms.TextBox();
            this.textboxFirstName = new System.Windows.Forms.TextBox();
            this.labelLastName = new System.Windows.Forms.Label();
            this.textboxLastName = new System.Windows.Forms.TextBox();
            this.labelPassword2 = new System.Windows.Forms.Label();
            this.textboxPassword2 = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.comboboxGender = new System.Windows.Forms.ComboBox();
            this.labelGender = new System.Windows.Forms.Label();
            this.pictureboxUser = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxUser)).BeginInit();
            this.SuspendLayout();
            // 
            // labelUsername
            // 
            resources.ApplyResources(this.labelUsername, "labelUsername");
            this.labelUsername.Name = "labelUsername";
            // 
            // textboxUser
            // 
            resources.ApplyResources(this.textboxUser, "textboxUser");
            this.textboxUser.Name = "textboxUser";
            // 
            // labelPassword
            // 
            resources.ApplyResources(this.labelPassword, "labelPassword");
            this.labelPassword.Name = "labelPassword";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // textboxPassword
            // 
            resources.ApplyResources(this.textboxPassword, "textboxPassword");
            this.textboxPassword.Name = "textboxPassword";
            // 
            // textboxFirstName
            // 
            resources.ApplyResources(this.textboxFirstName, "textboxFirstName");
            this.textboxFirstName.Name = "textboxFirstName";
            // 
            // labelLastName
            // 
            resources.ApplyResources(this.labelLastName, "labelLastName");
            this.labelLastName.Name = "labelLastName";
            // 
            // textboxLastName
            // 
            resources.ApplyResources(this.textboxLastName, "textboxLastName");
            this.textboxLastName.Name = "textboxLastName";
            // 
            // labelPassword2
            // 
            resources.ApplyResources(this.labelPassword2, "labelPassword2");
            this.labelPassword2.Name = "labelPassword2";
            // 
            // textboxPassword2
            // 
            resources.ApplyResources(this.textboxPassword2, "textboxPassword2");
            this.textboxPassword2.Name = "textboxPassword2";
            // 
            // buttonAdd
            // 
            resources.ApplyResources(this.buttonAdd, "buttonAdd");
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // comboboxGender
            // 
            this.comboboxGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboboxGender.FormattingEnabled = true;
            resources.ApplyResources(this.comboboxGender, "comboboxGender");
            this.comboboxGender.Name = "comboboxGender";
            // 
            // labelGender
            // 
            resources.ApplyResources(this.labelGender, "labelGender");
            this.labelGender.Name = "labelGender";
            // 
            // pictureboxUser
            // 
            this.pictureboxUser.Image = global::KinoProjektNikolaTrogrlic.Properties.Resources.Upload_PNG_Picture_3882195671;
            resources.ApplyResources(this.pictureboxUser, "pictureboxUser");
            this.pictureboxUser.Name = "pictureboxUser";
            this.pictureboxUser.TabStop = false;
            this.pictureboxUser.Click += new System.EventHandler(this.PictureboxUser_Click);
            // 
            // AddUser
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureboxUser);
            this.Controls.Add(this.labelGender);
            this.Controls.Add(this.comboboxGender);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textboxPassword2);
            this.Controls.Add(this.labelPassword2);
            this.Controls.Add(this.textboxLastName);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.textboxFirstName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textboxPassword);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.textboxUser);
            this.Controls.Add(this.labelUsername);
            this.Name = "AddUser";
            this.Load += new System.EventHandler(this.AddUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.TextBox textboxUser;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textboxPassword;
        private System.Windows.Forms.TextBox textboxFirstName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.TextBox textboxLastName;
        private System.Windows.Forms.Label labelPassword2;
        private System.Windows.Forms.TextBox textboxPassword2;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ComboBox comboboxGender;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.PictureBox pictureboxUser;
    }
}
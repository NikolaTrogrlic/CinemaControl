namespace KinoProjektNikolaTrogrlic.AdminAPP
{
    partial class EditUser
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
            this.labelGender = new System.Windows.Forms.Label();
            this.comboboxGender = new System.Windows.Forms.ComboBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.textboxPassword2 = new System.Windows.Forms.TextBox();
            this.labelPassword2 = new System.Windows.Forms.Label();
            this.textboxLastName = new System.Windows.Forms.TextBox();
            this.labelLastName = new System.Windows.Forms.Label();
            this.textboxFirstName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textboxPassword = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textboxUser = new System.Windows.Forms.TextBox();
            this.labelUsername = new System.Windows.Forms.Label();
            this.groupPass = new System.Windows.Forms.GroupBox();
            this.buttonUpdatePass = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.checkboxValidated = new System.Windows.Forms.CheckBox();
            this.pictureboxUser = new System.Windows.Forms.PictureBox();
            this.buttonPictureUpdate = new System.Windows.Forms.Button();
            this.groupPass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxUser)).BeginInit();
            this.SuspendLayout();
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelGender.Location = new System.Drawing.Point(72, 183);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(69, 20);
            this.labelGender.TabIndex = 30;
            this.labelGender.Text = "Gender:";
            // 
            // comboboxGender
            // 
            this.comboboxGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboboxGender.FormattingEnabled = true;
            this.comboboxGender.Location = new System.Drawing.Point(175, 180);
            this.comboboxGender.Name = "comboboxGender";
            this.comboboxGender.Size = new System.Drawing.Size(212, 28);
            this.comboboxGender.TabIndex = 26;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonUpdate.Location = new System.Drawing.Point(175, 270);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(147, 28);
            this.buttonUpdate.TabIndex = 28;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.ButtonUpdate_Click);
            // 
            // textboxPassword2
            // 
            this.textboxPassword2.Location = new System.Drawing.Point(11, 154);
            this.textboxPassword2.MaxLength = 1000;
            this.textboxPassword2.Name = "textboxPassword2";
            this.textboxPassword2.PasswordChar = '*';
            this.textboxPassword2.Size = new System.Drawing.Size(212, 27);
            this.textboxPassword2.TabIndex = 25;
            // 
            // labelPassword2
            // 
            this.labelPassword2.AutoSize = true;
            this.labelPassword2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.labelPassword2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelPassword2.Location = new System.Drawing.Point(7, 118);
            this.labelPassword2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPassword2.Name = "labelPassword2";
            this.labelPassword2.Size = new System.Drawing.Size(152, 20);
            this.labelPassword2.TabIndex = 29;
            this.labelPassword2.Text = "Confirm Password:";
            // 
            // textboxLastName
            // 
            this.textboxLastName.Location = new System.Drawing.Point(175, 128);
            this.textboxLastName.MaxLength = 1000;
            this.textboxLastName.Name = "textboxLastName";
            this.textboxLastName.Size = new System.Drawing.Size(212, 27);
            this.textboxLastName.TabIndex = 22;
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.labelLastName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelLastName.Location = new System.Drawing.Point(50, 131);
            this.labelLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(96, 20);
            this.labelLastName.TabIndex = 27;
            this.labelLastName.Text = "Last Name:";
            // 
            // textboxFirstName
            // 
            this.textboxFirstName.Location = new System.Drawing.Point(175, 82);
            this.textboxFirstName.MaxLength = 1000;
            this.textboxFirstName.Name = "textboxFirstName";
            this.textboxFirstName.Size = new System.Drawing.Size(212, 27);
            this.textboxFirstName.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(50, 85);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "First Name:";
            // 
            // textboxPassword
            // 
            this.textboxPassword.Location = new System.Drawing.Point(11, 73);
            this.textboxPassword.MaxLength = 1000;
            this.textboxPassword.Name = "textboxPassword";
            this.textboxPassword.PasswordChar = '*';
            this.textboxPassword.Size = new System.Drawing.Size(212, 27);
            this.textboxPassword.TabIndex = 24;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.labelPassword.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelPassword.Location = new System.Drawing.Point(7, 36);
            this.labelPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(88, 20);
            this.labelPassword.TabIndex = 21;
            this.labelPassword.Text = "Password:";
            // 
            // textboxUser
            // 
            this.textboxUser.Location = new System.Drawing.Point(175, 32);
            this.textboxUser.MaxLength = 300;
            this.textboxUser.Name = "textboxUser";
            this.textboxUser.Size = new System.Drawing.Size(212, 27);
            this.textboxUser.TabIndex = 19;
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.labelUsername.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelUsername.Location = new System.Drawing.Point(50, 35);
            this.labelUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(91, 20);
            this.labelUsername.TabIndex = 18;
            this.labelUsername.Text = "Username:";
            // 
            // groupPass
            // 
            this.groupPass.Controls.Add(this.buttonUpdatePass);
            this.groupPass.Controls.Add(this.labelPassword2);
            this.groupPass.Controls.Add(this.textboxPassword2);
            this.groupPass.Controls.Add(this.textboxPassword);
            this.groupPass.Controls.Add(this.labelPassword);
            this.groupPass.Location = new System.Drawing.Point(414, 32);
            this.groupPass.Name = "groupPass";
            this.groupPass.Size = new System.Drawing.Size(346, 237);
            this.groupPass.TabIndex = 32;
            this.groupPass.TabStop = false;
            this.groupPass.Text = "New Password:";
            // 
            // buttonUpdatePass
            // 
            this.buttonUpdatePass.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonUpdatePass.Location = new System.Drawing.Point(11, 195);
            this.buttonUpdatePass.Name = "buttonUpdatePass";
            this.buttonUpdatePass.Size = new System.Drawing.Size(298, 28);
            this.buttonUpdatePass.TabIndex = 36;
            this.buttonUpdatePass.Text = "Update Password";
            this.buttonUpdatePass.UseVisualStyleBackColor = true;
            this.buttonUpdatePass.Click += new System.EventHandler(this.ButtonUpdatePass_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonDelete.Location = new System.Drawing.Point(175, 320);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(147, 28);
            this.buttonDelete.TabIndex = 34;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // checkboxValidated
            // 
            this.checkboxValidated.AutoSize = true;
            this.checkboxValidated.Location = new System.Drawing.Point(175, 227);
            this.checkboxValidated.Name = "checkboxValidated";
            this.checkboxValidated.Size = new System.Drawing.Size(100, 24);
            this.checkboxValidated.TabIndex = 35;
            this.checkboxValidated.Text = "Validated";
            this.checkboxValidated.UseVisualStyleBackColor = true;
            // 
            // pictureboxUser
            // 
            this.pictureboxUser.Image = global::KinoProjektNikolaTrogrlic.Properties.Resources.Upload_PNG_Picture_3882195671;
            this.pictureboxUser.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureboxUser.Location = new System.Drawing.Point(511, 275);
            this.pictureboxUser.Name = "pictureboxUser";
            this.pictureboxUser.Size = new System.Drawing.Size(125, 125);
            this.pictureboxUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureboxUser.TabIndex = 36;
            this.pictureboxUser.TabStop = false;
            this.pictureboxUser.Click += new System.EventHandler(this.PictureboxUser_Click);
            // 
            // buttonPictureUpdate
            // 
            this.buttonPictureUpdate.Location = new System.Drawing.Point(483, 406);
            this.buttonPictureUpdate.Name = "buttonPictureUpdate";
            this.buttonPictureUpdate.Size = new System.Drawing.Size(179, 35);
            this.buttonPictureUpdate.TabIndex = 37;
            this.buttonPictureUpdate.Text = "Update Picture";
            this.buttonPictureUpdate.UseVisualStyleBackColor = true;
            this.buttonPictureUpdate.Click += new System.EventHandler(this.ButtonPictureUpdate_Click);
            // 
            // EditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.buttonPictureUpdate);
            this.Controls.Add(this.pictureboxUser);
            this.Controls.Add(this.checkboxValidated);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.groupPass);
            this.Controls.Add(this.labelGender);
            this.Controls.Add(this.comboboxGender);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.textboxLastName);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.textboxFirstName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textboxUser);
            this.Controls.Add(this.labelUsername);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EditUser";
            this.Text = "EditUser";
            this.Load += new System.EventHandler(this.EditUser_Load);
            this.groupPass.ResumeLayout(false);
            this.groupPass.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.ComboBox comboboxGender;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.TextBox textboxPassword2;
        private System.Windows.Forms.Label labelPassword2;
        private System.Windows.Forms.TextBox textboxLastName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.TextBox textboxFirstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textboxPassword;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textboxUser;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.GroupBox groupPass;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.CheckBox checkboxValidated;
        private System.Windows.Forms.Button buttonUpdatePass;
        private System.Windows.Forms.PictureBox pictureboxUser;
        private System.Windows.Forms.Button buttonPictureUpdate;
    }
}
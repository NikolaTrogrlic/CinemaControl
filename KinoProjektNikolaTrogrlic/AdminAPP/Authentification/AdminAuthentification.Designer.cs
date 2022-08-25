namespace KinoProjektNikolaTrogrlic
{
    partial class AdminAuthentification
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminAuthentification));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.textboxDB = new System.Windows.Forms.TextBox();
            this.labelDB = new System.Windows.Forms.Label();
            this.labelInfo = new System.Windows.Forms.Label();
            this.textboxDBPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textboxDBUser = new System.Windows.Forms.TextBox();
            this.labelDatabaseUser = new System.Windows.Forms.Label();
            this.textboxDBName = new System.Windows.Forms.TextBox();
            this.labelDatabaseName = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textboxDB);
            this.panel1.Controls.Add(this.labelDB);
            this.panel1.Controls.Add(this.labelInfo);
            this.panel1.Controls.Add(this.textboxDBPassword);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textboxDBUser);
            this.panel1.Controls.Add(this.labelDatabaseUser);
            this.panel1.Controls.Add(this.textboxDBName);
            this.panel1.Controls.Add(this.labelDatabaseName);
            this.panel1.Controls.Add(this.buttonLogin);
            this.panel1.Name = "panel1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // textboxDB
            // 
            resources.ApplyResources(this.textboxDB, "textboxDB");
            this.textboxDB.Name = "textboxDB";
            // 
            // labelDB
            // 
            resources.ApplyResources(this.labelDB, "labelDB");
            this.labelDB.Name = "labelDB";
            // 
            // labelInfo
            // 
            resources.ApplyResources(this.labelInfo, "labelInfo");
            this.labelInfo.Name = "labelInfo";
            // 
            // textboxDBPassword
            // 
            resources.ApplyResources(this.textboxDBPassword, "textboxDBPassword");
            this.textboxDBPassword.Name = "textboxDBPassword";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // textboxDBUser
            // 
            resources.ApplyResources(this.textboxDBUser, "textboxDBUser");
            this.textboxDBUser.Name = "textboxDBUser";
            // 
            // labelDatabaseUser
            // 
            resources.ApplyResources(this.labelDatabaseUser, "labelDatabaseUser");
            this.labelDatabaseUser.Name = "labelDatabaseUser";
            // 
            // textboxDBName
            // 
            resources.ApplyResources(this.textboxDBName, "textboxDBName");
            this.textboxDBName.Name = "textboxDBName";
            // 
            // labelDatabaseName
            // 
            resources.ApplyResources(this.labelDatabaseName, "labelDatabaseName");
            this.labelDatabaseName.Name = "labelDatabaseName";
            // 
            // buttonLogin
            // 
            resources.ApplyResources(this.buttonLogin, "buttonLogin");
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.ButtonLogin_Click);
            // 
            // AdminAuthentification
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "AdminAuthentification";
            this.Load += new System.EventHandler(this.AdminAuthentification_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Label labelDatabaseName;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.TextBox textboxDBPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textboxDBUser;
        private System.Windows.Forms.Label labelDatabaseUser;
        private System.Windows.Forms.TextBox textboxDBName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textboxDB;
        private System.Windows.Forms.Label labelDB;
    }
}
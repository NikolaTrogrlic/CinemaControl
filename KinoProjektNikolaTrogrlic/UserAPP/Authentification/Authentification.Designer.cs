namespace KinoProjektNikolaTrogrlic
{
    partial class Authentification
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Authentification));
            this.labelName = new System.Windows.Forms.Label();
            this.textboxUsername = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textboxPassword = new System.Windows.Forms.TextBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.Register = new System.Windows.Forms.Button();
            this.textboxAddress = new System.Windows.Forms.TextBox();
            this.labelAddress = new System.Windows.Forms.Label();
            this.textboxPort = new System.Windows.Forms.TextBox();
            this.labelPort = new System.Windows.Forms.Label();
            this.checkboxPortAddress = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // labelName
            // 
            resources.ApplyResources(this.labelName, "labelName");
            this.labelName.Name = "labelName";
            // 
            // textboxUsername
            // 
            resources.ApplyResources(this.textboxUsername, "textboxUsername");
            this.textboxUsername.Name = "textboxUsername";
            // 
            // labelPassword
            // 
            resources.ApplyResources(this.labelPassword, "labelPassword");
            this.labelPassword.Name = "labelPassword";
            // 
            // textboxPassword
            // 
            resources.ApplyResources(this.textboxPassword, "textboxPassword");
            this.textboxPassword.Name = "textboxPassword";
            // 
            // buttonLogin
            // 
            resources.ApplyResources(this.buttonLogin, "buttonLogin");
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.ButtonLogin_Click);
            // 
            // Register
            // 
            resources.ApplyResources(this.Register, "Register");
            this.Register.Name = "Register";
            this.Register.UseVisualStyleBackColor = true;
            this.Register.Click += new System.EventHandler(this.Register_Click);
            // 
            // textboxAddress
            // 
            resources.ApplyResources(this.textboxAddress, "textboxAddress");
            this.textboxAddress.Name = "textboxAddress";
            // 
            // labelAddress
            // 
            resources.ApplyResources(this.labelAddress, "labelAddress");
            this.labelAddress.Name = "labelAddress";
            // 
            // textboxPort
            // 
            resources.ApplyResources(this.textboxPort, "textboxPort");
            this.textboxPort.Name = "textboxPort";
            // 
            // labelPort
            // 
            resources.ApplyResources(this.labelPort, "labelPort");
            this.labelPort.Name = "labelPort";
            // 
            // checkboxPortAddress
            // 
            resources.ApplyResources(this.checkboxPortAddress, "checkboxPortAddress");
            this.checkboxPortAddress.Name = "checkboxPortAddress";
            this.checkboxPortAddress.UseVisualStyleBackColor = true;
            // 
            // Authentification
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.checkboxPortAddress);
            this.Controls.Add(this.textboxAddress);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.textboxPort);
            this.Controls.Add(this.labelPort);
            this.Controls.Add(this.Register);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.textboxPassword);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.textboxUsername);
            this.Controls.Add(this.labelName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Authentification";
            this.Load += new System.EventHandler(this.Authentification_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textboxUsername;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textboxPassword;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button Register;
        private System.Windows.Forms.TextBox textboxAddress;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.TextBox textboxPort;
        private System.Windows.Forms.Label labelPort;
        private System.Windows.Forms.CheckBox checkboxPortAddress;
    }
}


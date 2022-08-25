namespace KinoProjektNikolaTrogrlic
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.comboboxLanguage = new System.Windows.Forms.ComboBox();
            this.labelLanguage = new System.Windows.Forms.Label();
            this.labelNote1 = new System.Windows.Forms.Label();
            this.checkboxSkip = new System.Windows.Forms.CheckBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.comboboxStart = new System.Windows.Forms.ComboBox();
            this.labelStart = new System.Windows.Forms.Label();
            this.checkboxApp = new System.Windows.Forms.CheckBox();
            this.buttonAuthor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboboxLanguage
            // 
            this.comboboxLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboboxLanguage.FormattingEnabled = true;
            resources.ApplyResources(this.comboboxLanguage, "comboboxLanguage");
            this.comboboxLanguage.Name = "comboboxLanguage";
            this.comboboxLanguage.SelectedIndexChanged += new System.EventHandler(this.ComboboxLanguage_SelectedIndexChanged);
            // 
            // labelLanguage
            // 
            resources.ApplyResources(this.labelLanguage, "labelLanguage");
            this.labelLanguage.Name = "labelLanguage";
            // 
            // labelNote1
            // 
            resources.ApplyResources(this.labelNote1, "labelNote1");
            this.labelNote1.Name = "labelNote1";
            // 
            // checkboxSkip
            // 
            resources.ApplyResources(this.checkboxSkip, "checkboxSkip");
            this.checkboxSkip.Name = "checkboxSkip";
            this.checkboxSkip.UseVisualStyleBackColor = true;
            this.checkboxSkip.CheckedChanged += new System.EventHandler(this.CheckboxSkip_CheckedChanged);
            // 
            // comboboxStart
            // 
            this.comboboxStart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.comboboxStart, "comboboxStart");
            this.comboboxStart.FormattingEnabled = true;
            this.comboboxStart.Name = "comboboxStart";
            this.comboboxStart.SelectedIndexChanged += new System.EventHandler(this.ComboboxStart_SelectedIndexChanged);
            // 
            // labelStart
            // 
            resources.ApplyResources(this.labelStart, "labelStart");
            this.labelStart.Name = "labelStart";
            // 
            // checkboxApp
            // 
            resources.ApplyResources(this.checkboxApp, "checkboxApp");
            this.checkboxApp.Name = "checkboxApp";
            this.checkboxApp.UseVisualStyleBackColor = true;
            this.checkboxApp.CheckedChanged += new System.EventHandler(this.CheckboxApp_CheckedChanged);
            // 
            // buttonAuthor
            // 
            resources.ApplyResources(this.buttonAuthor, "buttonAuthor");
            this.buttonAuthor.Name = "buttonAuthor";
            this.buttonAuthor.UseVisualStyleBackColor = true;
            this.buttonAuthor.Click += new System.EventHandler(this.ButtonAuthor_Click);
            // 
            // Settings
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonAuthor);
            this.Controls.Add(this.checkboxApp);
            this.Controls.Add(this.labelStart);
            this.Controls.Add(this.comboboxStart);
            this.Controls.Add(this.checkboxSkip);
            this.Controls.Add(this.labelNote1);
            this.Controls.Add(this.labelLanguage);
            this.Controls.Add(this.comboboxLanguage);
            this.Name = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboboxLanguage;
        private System.Windows.Forms.Label labelLanguage;
        private System.Windows.Forms.Label labelNote1;
        private System.Windows.Forms.CheckBox checkboxSkip;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox comboboxStart;
        private System.Windows.Forms.Label labelStart;
        private System.Windows.Forms.CheckBox checkboxApp;
        private System.Windows.Forms.Button buttonAuthor;
    }
}
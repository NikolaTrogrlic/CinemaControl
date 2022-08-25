namespace KinoProjektNikolaTrogrlic
{
    partial class AddMovie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddMovie));
            this.labelMovieTitle = new System.Windows.Forms.Label();
            this.textboxTitle = new System.Windows.Forms.TextBox();
            this.labelMovieDescription = new System.Windows.Forms.Label();
            this.textboxDescription = new System.Windows.Forms.TextBox();
            this.labelMovieCategory = new System.Windows.Forms.Label();
            this.comboboxCategory = new System.Windows.Forms.ComboBox();
            this.labelMovieDuration = new System.Windows.Forms.Label();
            this.numericHours = new System.Windows.Forms.NumericUpDown();
            this.numericMinutes = new System.Windows.Forms.NumericUpDown();
            this.numericSeconds = new System.Windows.Forms.NumericUpDown();
            this.labelHours = new System.Windows.Forms.Label();
            this.labelMinutes = new System.Windows.Forms.Label();
            this.labelSeconds = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonLookup = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSeconds)).BeginInit();
            this.SuspendLayout();
            // 
            // labelMovieTitle
            // 
            resources.ApplyResources(this.labelMovieTitle, "labelMovieTitle");
            this.labelMovieTitle.Name = "labelMovieTitle";
            // 
            // textboxTitle
            // 
            resources.ApplyResources(this.textboxTitle, "textboxTitle");
            this.textboxTitle.Name = "textboxTitle";
            // 
            // labelMovieDescription
            // 
            resources.ApplyResources(this.labelMovieDescription, "labelMovieDescription");
            this.labelMovieDescription.Name = "labelMovieDescription";
            // 
            // textboxDescription
            // 
            resources.ApplyResources(this.textboxDescription, "textboxDescription");
            this.textboxDescription.Name = "textboxDescription";
            // 
            // labelMovieCategory
            // 
            resources.ApplyResources(this.labelMovieCategory, "labelMovieCategory");
            this.labelMovieCategory.Name = "labelMovieCategory";
            // 
            // comboboxCategory
            // 
            this.comboboxCategory.FormattingEnabled = true;
            resources.ApplyResources(this.comboboxCategory, "comboboxCategory");
            this.comboboxCategory.Name = "comboboxCategory";
            // 
            // labelMovieDuration
            // 
            resources.ApplyResources(this.labelMovieDuration, "labelMovieDuration");
            this.labelMovieDuration.Name = "labelMovieDuration";
            // 
            // numericHours
            // 
            resources.ApplyResources(this.numericHours, "numericHours");
            this.numericHours.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericHours.Name = "numericHours";
            // 
            // numericMinutes
            // 
            resources.ApplyResources(this.numericMinutes, "numericMinutes");
            this.numericMinutes.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numericMinutes.Name = "numericMinutes";
            // 
            // numericSeconds
            // 
            resources.ApplyResources(this.numericSeconds, "numericSeconds");
            this.numericSeconds.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numericSeconds.Name = "numericSeconds";
            // 
            // labelHours
            // 
            resources.ApplyResources(this.labelHours, "labelHours");
            this.labelHours.Name = "labelHours";
            // 
            // labelMinutes
            // 
            resources.ApplyResources(this.labelMinutes, "labelMinutes");
            this.labelMinutes.Name = "labelMinutes";
            // 
            // labelSeconds
            // 
            resources.ApplyResources(this.labelSeconds, "labelSeconds");
            this.labelSeconds.Name = "labelSeconds";
            // 
            // buttonAdd
            // 
            resources.ApplyResources(this.buttonAdd, "buttonAdd");
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // buttonLookup
            // 
            resources.ApplyResources(this.buttonLookup, "buttonLookup");
            this.buttonLookup.Name = "buttonLookup";
            this.buttonLookup.UseVisualStyleBackColor = true;
            this.buttonLookup.Click += new System.EventHandler(this.ButtonLookup_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // AddMovie
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonLookup);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelSeconds);
            this.Controls.Add(this.labelMinutes);
            this.Controls.Add(this.labelHours);
            this.Controls.Add(this.numericSeconds);
            this.Controls.Add(this.numericMinutes);
            this.Controls.Add(this.numericHours);
            this.Controls.Add(this.labelMovieDuration);
            this.Controls.Add(this.comboboxCategory);
            this.Controls.Add(this.labelMovieCategory);
            this.Controls.Add(this.textboxDescription);
            this.Controls.Add(this.labelMovieDescription);
            this.Controls.Add(this.textboxTitle);
            this.Controls.Add(this.labelMovieTitle);
            this.Name = "AddMovie";
            this.Load += new System.EventHandler(this.AddMovie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSeconds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMovieTitle;
        private System.Windows.Forms.TextBox textboxTitle;
        private System.Windows.Forms.Label labelMovieDescription;
        private System.Windows.Forms.TextBox textboxDescription;
        private System.Windows.Forms.Label labelMovieCategory;
        private System.Windows.Forms.ComboBox comboboxCategory;
        private System.Windows.Forms.Label labelMovieDuration;
        private System.Windows.Forms.NumericUpDown numericHours;
        private System.Windows.Forms.NumericUpDown numericMinutes;
        private System.Windows.Forms.NumericUpDown numericSeconds;
        private System.Windows.Forms.Label labelHours;
        private System.Windows.Forms.Label labelMinutes;
        private System.Windows.Forms.Label labelSeconds;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonLookup;
        private System.Windows.Forms.Label label1;
    }
}
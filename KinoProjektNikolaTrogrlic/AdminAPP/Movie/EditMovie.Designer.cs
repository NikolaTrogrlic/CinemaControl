namespace KinoProjektNikolaTrogrlic
{
    partial class EditMovie
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
            this.buttonEdit = new System.Windows.Forms.Button();
            this.labelSeconds = new System.Windows.Forms.Label();
            this.labelMinutes = new System.Windows.Forms.Label();
            this.labelHours = new System.Windows.Forms.Label();
            this.numericSeconds = new System.Windows.Forms.NumericUpDown();
            this.numericMinutes = new System.Windows.Forms.NumericUpDown();
            this.numericHours = new System.Windows.Forms.NumericUpDown();
            this.labelMovieDuration = new System.Windows.Forms.Label();
            this.comboboxCategory = new System.Windows.Forms.ComboBox();
            this.labelMovieCategory = new System.Windows.Forms.Label();
            this.textboxDescription = new System.Windows.Forms.TextBox();
            this.labelMovieDescription = new System.Windows.Forms.Label();
            this.textboxTitle = new System.Windows.Forms.TextBox();
            this.labelMovieTitle = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonLookup = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericSeconds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericHours)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonEdit
            // 
            this.buttonEdit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonEdit.Location = new System.Drawing.Point(63, 446);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(147, 28);
            this.buttonEdit.TabIndex = 28;
            this.buttonEdit.Text = "Update";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.ButtonEdit_Click);
            // 
            // labelSeconds
            // 
            this.labelSeconds.AutoSize = true;
            this.labelSeconds.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelSeconds.Location = new System.Drawing.Point(488, 396);
            this.labelSeconds.Name = "labelSeconds";
            this.labelSeconds.Size = new System.Drawing.Size(61, 16);
            this.labelSeconds.TabIndex = 27;
            this.labelSeconds.Text = "Seconds";
            // 
            // labelMinutes
            // 
            this.labelMinutes.AutoSize = true;
            this.labelMinutes.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelMinutes.Location = new System.Drawing.Point(358, 396);
            this.labelMinutes.Name = "labelMinutes";
            this.labelMinutes.Size = new System.Drawing.Size(53, 16);
            this.labelMinutes.TabIndex = 26;
            this.labelMinutes.Text = "Minutes";
            // 
            // labelHours
            // 
            this.labelHours.AutoSize = true;
            this.labelHours.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelHours.Location = new System.Drawing.Point(228, 396);
            this.labelHours.Name = "labelHours";
            this.labelHours.Size = new System.Drawing.Size(43, 16);
            this.labelHours.TabIndex = 25;
            this.labelHours.Text = "Hours";
            // 
            // numericSeconds
            // 
            this.numericSeconds.Location = new System.Drawing.Point(470, 371);
            this.numericSeconds.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numericSeconds.Name = "numericSeconds";
            this.numericSeconds.Size = new System.Drawing.Size(120, 22);
            this.numericSeconds.TabIndex = 24;
            // 
            // numericMinutes
            // 
            this.numericMinutes.Location = new System.Drawing.Point(331, 371);
            this.numericMinutes.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numericMinutes.Name = "numericMinutes";
            this.numericMinutes.Size = new System.Drawing.Size(120, 22);
            this.numericMinutes.TabIndex = 23;
            // 
            // numericHours
            // 
            this.numericHours.Location = new System.Drawing.Point(195, 371);
            this.numericHours.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericHours.Name = "numericHours";
            this.numericHours.Size = new System.Drawing.Size(120, 22);
            this.numericHours.TabIndex = 22;
            // 
            // labelMovieDuration
            // 
            this.labelMovieDuration.AutoSize = true;
            this.labelMovieDuration.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelMovieDuration.Location = new System.Drawing.Point(60, 371);
            this.labelMovieDuration.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMovieDuration.Name = "labelMovieDuration";
            this.labelMovieDuration.Size = new System.Drawing.Size(100, 16);
            this.labelMovieDuration.TabIndex = 21;
            this.labelMovieDuration.Text = "Movie Duration:";
            // 
            // comboboxCategory
            // 
            this.comboboxCategory.FormattingEnabled = true;
            this.comboboxCategory.Location = new System.Drawing.Point(168, 309);
            this.comboboxCategory.Name = "comboboxCategory";
            this.comboboxCategory.Size = new System.Drawing.Size(268, 24);
            this.comboboxCategory.TabIndex = 20;
            // 
            // labelMovieCategory
            // 
            this.labelMovieCategory.AutoSize = true;
            this.labelMovieCategory.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelMovieCategory.Location = new System.Drawing.Point(60, 314);
            this.labelMovieCategory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMovieCategory.Name = "labelMovieCategory";
            this.labelMovieCategory.Size = new System.Drawing.Size(65, 16);
            this.labelMovieCategory.TabIndex = 19;
            this.labelMovieCategory.Text = "Category:";
            // 
            // textboxDescription
            // 
            this.textboxDescription.Location = new System.Drawing.Point(168, 69);
            this.textboxDescription.MaxLength = 1000;
            this.textboxDescription.Multiline = true;
            this.textboxDescription.Name = "textboxDescription";
            this.textboxDescription.Size = new System.Drawing.Size(394, 214);
            this.textboxDescription.TabIndex = 18;
            // 
            // labelMovieDescription
            // 
            this.labelMovieDescription.AutoSize = true;
            this.labelMovieDescription.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelMovieDescription.Location = new System.Drawing.Point(46, 69);
            this.labelMovieDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMovieDescription.Name = "labelMovieDescription";
            this.labelMovieDescription.Size = new System.Drawing.Size(78, 16);
            this.labelMovieDescription.TabIndex = 17;
            this.labelMovieDescription.Text = "Description:";
            // 
            // textboxTitle
            // 
            this.textboxTitle.Location = new System.Drawing.Point(168, 28);
            this.textboxTitle.MaxLength = 300;
            this.textboxTitle.Name = "textboxTitle";
            this.textboxTitle.Size = new System.Drawing.Size(268, 22);
            this.textboxTitle.TabIndex = 16;
            // 
            // labelMovieTitle
            // 
            this.labelMovieTitle.AutoSize = true;
            this.labelMovieTitle.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelMovieTitle.Location = new System.Drawing.Point(46, 31);
            this.labelMovieTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMovieTitle.Name = "labelMovieTitle";
            this.labelMovieTitle.Size = new System.Drawing.Size(76, 16);
            this.labelMovieTitle.TabIndex = 15;
            this.labelMovieTitle.Text = "Movie Title:";
            // 
            // buttonDelete
            // 
            this.buttonDelete.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonDelete.Location = new System.Drawing.Point(415, 446);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(147, 28);
            this.buttonDelete.TabIndex = 29;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(539, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 16);
            this.label1.TabIndex = 31;
            this.label1.Text = "Input movie title before filling";
            // 
            // buttonLookup
            // 
            this.buttonLookup.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonLookup.Location = new System.Drawing.Point(608, 47);
            this.buttonLookup.Name = "buttonLookup";
            this.buttonLookup.Size = new System.Drawing.Size(153, 61);
            this.buttonLookup.TabIndex = 30;
            this.buttonLookup.Text = "IMDB Fill";
            this.buttonLookup.UseVisualStyleBackColor = true;
            this.buttonLookup.Click += new System.EventHandler(this.ButtonLookup_Click);
            // 
            // EditMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 503);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonLookup);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonEdit);
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
            this.Name = "EditMovie";
            this.Text = "EditMovie";
            this.Load += new System.EventHandler(this.EditMovie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericSeconds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericHours)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Label labelSeconds;
        private System.Windows.Forms.Label labelMinutes;
        private System.Windows.Forms.Label labelHours;
        private System.Windows.Forms.NumericUpDown numericSeconds;
        private System.Windows.Forms.NumericUpDown numericMinutes;
        private System.Windows.Forms.NumericUpDown numericHours;
        private System.Windows.Forms.Label labelMovieDuration;
        private System.Windows.Forms.ComboBox comboboxCategory;
        private System.Windows.Forms.Label labelMovieCategory;
        private System.Windows.Forms.TextBox textboxDescription;
        private System.Windows.Forms.Label labelMovieDescription;
        private System.Windows.Forms.TextBox textboxTitle;
        private System.Windows.Forms.Label labelMovieTitle;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonLookup;
    }
}
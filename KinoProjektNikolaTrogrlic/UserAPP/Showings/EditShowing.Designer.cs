namespace KinoProjektNikolaTrogrlic.UserAPP
{
    partial class EditShowing
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
            this.buttonAddShowing = new System.Windows.Forms.Button();
            this.labelStartTime = new System.Windows.Forms.Label();
            this.datetimePicker = new System.Windows.Forms.DateTimePicker();
            this.textboxTicketPrice = new System.Windows.Forms.TextBox();
            this.labelTicketPrice = new System.Windows.Forms.Label();
            this.buttonGetMovies = new System.Windows.Forms.Button();
            this.comboboxMovie = new System.Windows.Forms.ComboBox();
            this.label = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAddShowing
            // 
            this.buttonAddShowing.Location = new System.Drawing.Point(256, 202);
            this.buttonAddShowing.Name = "buttonAddShowing";
            this.buttonAddShowing.Size = new System.Drawing.Size(132, 41);
            this.buttonAddShowing.TabIndex = 15;
            this.buttonAddShowing.Text = "Confirm Changes";
            this.buttonAddShowing.UseVisualStyleBackColor = true;
            this.buttonAddShowing.Click += new System.EventHandler(this.ButtonAddClick);
            // 
            // labelStartTime
            // 
            this.labelStartTime.AutoSize = true;
            this.labelStartTime.Location = new System.Drawing.Point(129, 154);
            this.labelStartTime.Name = "labelStartTime";
            this.labelStartTime.Size = new System.Drawing.Size(111, 16);
            this.labelStartTime.TabIndex = 14;
            this.labelStartTime.Text = "Movie Start Time:";
            // 
            // datetimePicker
            // 
            this.datetimePicker.Checked = false;
            this.datetimePicker.Location = new System.Drawing.Point(256, 149);
            this.datetimePicker.Name = "datetimePicker";
            this.datetimePicker.Size = new System.Drawing.Size(258, 22);
            this.datetimePicker.TabIndex = 13;
            // 
            // textboxTicketPrice
            // 
            this.textboxTicketPrice.Location = new System.Drawing.Point(256, 102);
            this.textboxTicketPrice.Name = "textboxTicketPrice";
            this.textboxTicketPrice.Size = new System.Drawing.Size(258, 22);
            this.textboxTicketPrice.TabIndex = 12;
            // 
            // labelTicketPrice
            // 
            this.labelTicketPrice.AutoSize = true;
            this.labelTicketPrice.Location = new System.Drawing.Point(159, 108);
            this.labelTicketPrice.Name = "labelTicketPrice";
            this.labelTicketPrice.Size = new System.Drawing.Size(81, 16);
            this.labelTicketPrice.TabIndex = 11;
            this.labelTicketPrice.Text = "Ticket Price:";
            // 
            // buttonGetMovies
            // 
            this.buttonGetMovies.Location = new System.Drawing.Point(536, 57);
            this.buttonGetMovies.Name = "buttonGetMovies";
            this.buttonGetMovies.Size = new System.Drawing.Size(164, 28);
            this.buttonGetMovies.TabIndex = 10;
            this.buttonGetMovies.Text = "Fetch from Database";
            this.buttonGetMovies.UseVisualStyleBackColor = true;
            this.buttonGetMovies.Click += new System.EventHandler(this.ButtonMoviesClick);
            // 
            // comboboxMovie
            // 
            this.comboboxMovie.FormattingEnabled = true;
            this.comboboxMovie.Location = new System.Drawing.Point(256, 60);
            this.comboboxMovie.Name = "comboboxMovie";
            this.comboboxMovie.Size = new System.Drawing.Size(258, 24);
            this.comboboxMovie.TabIndex = 9;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(62, 63);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(178, 16);
            this.label.TabIndex = 8;
            this.label.Text = "Select movie from database:";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(394, 202);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(132, 41);
            this.buttonDelete.TabIndex = 16;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.ButtonDeleteClick);
            // 
            // EditShowing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 353);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAddShowing);
            this.Controls.Add(this.labelStartTime);
            this.Controls.Add(this.datetimePicker);
            this.Controls.Add(this.textboxTicketPrice);
            this.Controls.Add(this.labelTicketPrice);
            this.Controls.Add(this.buttonGetMovies);
            this.Controls.Add(this.comboboxMovie);
            this.Controls.Add(this.label);
            this.Name = "EditShowing";
            this.Text = "EditShowing";
            this.Load += new System.EventHandler(this.EditShowing_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAddShowing;
        private System.Windows.Forms.Label labelStartTime;
        private System.Windows.Forms.DateTimePicker datetimePicker;
        private System.Windows.Forms.TextBox textboxTicketPrice;
        private System.Windows.Forms.Label labelTicketPrice;
        private System.Windows.Forms.Button buttonGetMovies;
        private System.Windows.Forms.ComboBox comboboxMovie;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button buttonDelete;
    }
}
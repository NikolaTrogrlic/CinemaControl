namespace KinoProjektNikolaTrogrlic.UserAPP
{
    partial class AddShowing
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
            this.label = new System.Windows.Forms.Label();
            this.comboboxMovie = new System.Windows.Forms.ComboBox();
            this.buttonGetMovies = new System.Windows.Forms.Button();
            this.labelTicketPrice = new System.Windows.Forms.Label();
            this.textboxTicketPrice = new System.Windows.Forms.TextBox();
            this.datetimePicker = new System.Windows.Forms.DateTimePicker();
            this.labelStartTime = new System.Windows.Forms.Label();
            this.buttonAddShowing = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(64, 56);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(178, 16);
            this.label.TabIndex = 0;
            this.label.Text = "Select movie from database:";
            // 
            // comboboxMovie
            // 
            this.comboboxMovie.FormattingEnabled = true;
            this.comboboxMovie.Location = new System.Drawing.Point(258, 53);
            this.comboboxMovie.Name = "comboboxMovie";
            this.comboboxMovie.Size = new System.Drawing.Size(258, 24);
            this.comboboxMovie.TabIndex = 1;
            // 
            // buttonGetMovies
            // 
            this.buttonGetMovies.Location = new System.Drawing.Point(538, 50);
            this.buttonGetMovies.Name = "buttonGetMovies";
            this.buttonGetMovies.Size = new System.Drawing.Size(164, 28);
            this.buttonGetMovies.TabIndex = 2;
            this.buttonGetMovies.Text = "Fetch from Database";
            this.buttonGetMovies.UseVisualStyleBackColor = true;
            this.buttonGetMovies.Click += new System.EventHandler(this.ButtonMoviesClick);
            // 
            // labelTicketPrice
            // 
            this.labelTicketPrice.AutoSize = true;
            this.labelTicketPrice.Location = new System.Drawing.Point(161, 101);
            this.labelTicketPrice.Name = "labelTicketPrice";
            this.labelTicketPrice.Size = new System.Drawing.Size(81, 16);
            this.labelTicketPrice.TabIndex = 3;
            this.labelTicketPrice.Text = "Ticket Price:";
            // 
            // textboxTicketPrice
            // 
            this.textboxTicketPrice.Location = new System.Drawing.Point(258, 95);
            this.textboxTicketPrice.Name = "textboxTicketPrice";
            this.textboxTicketPrice.Size = new System.Drawing.Size(258, 22);
            this.textboxTicketPrice.TabIndex = 4;
            // 
            // datetimePicker
            // 
            this.datetimePicker.Checked = false;
            this.datetimePicker.Location = new System.Drawing.Point(258, 142);
            this.datetimePicker.Name = "datetimePicker";
            this.datetimePicker.Size = new System.Drawing.Size(258, 22);
            this.datetimePicker.TabIndex = 5;
            // 
            // labelStartTime
            // 
            this.labelStartTime.AutoSize = true;
            this.labelStartTime.Location = new System.Drawing.Point(131, 147);
            this.labelStartTime.Name = "labelStartTime";
            this.labelStartTime.Size = new System.Drawing.Size(111, 16);
            this.labelStartTime.TabIndex = 6;
            this.labelStartTime.Text = "Movie Start Time:";
            // 
            // buttonAddShowing
            // 
            this.buttonAddShowing.Location = new System.Drawing.Point(258, 195);
            this.buttonAddShowing.Name = "buttonAddShowing";
            this.buttonAddShowing.Size = new System.Drawing.Size(132, 41);
            this.buttonAddShowing.TabIndex = 7;
            this.buttonAddShowing.Text = "Add Showing";
            this.buttonAddShowing.UseVisualStyleBackColor = true;
            this.buttonAddShowing.Click += new System.EventHandler(this.ButtonAddClick);
            // 
            // AddShowing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 353);
            this.Controls.Add(this.buttonAddShowing);
            this.Controls.Add(this.labelStartTime);
            this.Controls.Add(this.datetimePicker);
            this.Controls.Add(this.textboxTicketPrice);
            this.Controls.Add(this.labelTicketPrice);
            this.Controls.Add(this.buttonGetMovies);
            this.Controls.Add(this.comboboxMovie);
            this.Controls.Add(this.label);
            this.Name = "AddShowing";
            this.Text = "AddShowing";
            this.Load += new System.EventHandler(this.AddShowing_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.ComboBox comboboxMovie;
        private System.Windows.Forms.Button buttonGetMovies;
        private System.Windows.Forms.Label labelTicketPrice;
        private System.Windows.Forms.TextBox textboxTicketPrice;
        private System.Windows.Forms.DateTimePicker datetimePicker;
        private System.Windows.Forms.Label labelStartTime;
        private System.Windows.Forms.Button buttonAddShowing;
    }
}
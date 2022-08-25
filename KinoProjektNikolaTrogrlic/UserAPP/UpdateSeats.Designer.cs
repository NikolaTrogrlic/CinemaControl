namespace KinoProjektNikolaTrogrlic.UserAPP
{
    partial class UpdateSeats
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateSeats));
            this.labelSeatNumber = new System.Windows.Forms.Label();
            this.labelSeat = new System.Windows.Forms.Label();
            this.comboboxSeatStatus = new System.Windows.Forms.ComboBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelSeatNumber
            // 
            resources.ApplyResources(this.labelSeatNumber, "labelSeatNumber");
            this.labelSeatNumber.Name = "labelSeatNumber";
            // 
            // labelSeat
            // 
            resources.ApplyResources(this.labelSeat, "labelSeat");
            this.labelSeat.Name = "labelSeat";
            // 
            // comboboxSeatStatus
            // 
            this.comboboxSeatStatus.FormattingEnabled = true;
            resources.ApplyResources(this.comboboxSeatStatus, "comboboxSeatStatus");
            this.comboboxSeatStatus.Name = "comboboxSeatStatus";
            // 
            // buttonUpdate
            // 
            resources.ApplyResources(this.buttonUpdate, "buttonUpdate");
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.ButtonUpdate_Click);
            // 
            // UpdateSeats
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.comboboxSeatStatus);
            this.Controls.Add(this.labelSeat);
            this.Controls.Add(this.labelSeatNumber);
            this.Name = "UpdateSeats";
            this.Load += new System.EventHandler(this.UpdateSeats_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSeatNumber;
        private System.Windows.Forms.Label labelSeat;
        private System.Windows.Forms.ComboBox comboboxSeatStatus;
        private System.Windows.Forms.Button buttonUpdate;
    }
}
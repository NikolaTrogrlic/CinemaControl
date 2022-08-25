namespace KinoProjektNikolaTrogrlic.UserAPP
{
    partial class ViewShowings
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
            this.datagridviewShowings = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewShowings)).BeginInit();
            this.SuspendLayout();
            // 
            // datagridviewShowings
            // 
            this.datagridviewShowings.AllowUserToAddRows = false;
            this.datagridviewShowings.AllowUserToDeleteRows = false;
            this.datagridviewShowings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridviewShowings.Location = new System.Drawing.Point(13, 13);
            this.datagridviewShowings.Name = "datagridviewShowings";
            this.datagridviewShowings.ReadOnly = true;
            this.datagridviewShowings.RowHeadersWidth = 51;
            this.datagridviewShowings.RowTemplate.Height = 24;
            this.datagridviewShowings.Size = new System.Drawing.Size(848, 428);
            this.datagridviewShowings.TabIndex = 0;
            this.datagridviewShowings.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DatagridviewShowings_RowHeaderDoubleClick);
            // 
            // ViewShowings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 453);
            this.Controls.Add(this.datagridviewShowings);
            this.Name = "ViewShowings";
            this.Text = "ViewShowings";
            this.Load += new System.EventHandler(this.ViewShowings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewShowings)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView datagridviewShowings;
    }
}
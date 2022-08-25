namespace KinoProjektNikolaTrogrlic
{
    partial class AdminManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminManagement));
            this.ManagmentTabs = new System.Windows.Forms.TabControl();
            this.tabMovies = new System.Windows.Forms.TabPage();
            this.buttonFilter = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textboxSearch = new System.Windows.Forms.TextBox();
            this.gridviewMovies = new System.Windows.Forms.DataGridView();
            this.buttonAddMovie = new System.Windows.Forms.Button();
            this.tabCategories = new System.Windows.Forms.TabPage();
            this.buttonCategory = new System.Windows.Forms.Button();
            this.gridviewCategories = new System.Windows.Forms.DataGridView();
            this.tabUsers = new System.Windows.Forms.TabPage();
            this.buttonValidate = new System.Windows.Forms.Button();
            this.buttonUnvalidated = new System.Windows.Forms.Button();
            this.buttonCalculateGender = new System.Windows.Forms.Button();
            this.buttonUser = new System.Windows.Forms.Button();
            this.gridviewUsers = new System.Windows.Forms.DataGridView();
            this.tabSettings = new System.Windows.Forms.TabPage();
            this.buttonSave = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textboxKey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textboxServerDatabase = new System.Windows.Forms.TextBox();
            this.textboxServerPassword = new System.Windows.Forms.TextBox();
            this.textboxServerUser = new System.Windows.Forms.TextBox();
            this.textboxServerName = new System.Windows.Forms.TextBox();
            this.checkboxEnter = new System.Windows.Forms.CheckBox();
            this.labelDefaultDatabase = new System.Windows.Forms.Label();
            this.labelServerUser = new System.Windows.Forms.Label();
            this.labelServerPassword = new System.Windows.Forms.Label();
            this.labelServerName = new System.Windows.Forms.Label();
            this.textboxApiKey = new System.Windows.Forms.TextBox();
            this.labelAPIKey = new System.Windows.Forms.Label();
            this.tabHost = new System.Windows.Forms.TabPage();
            this.textboxLog = new System.Windows.Forms.RichTextBox();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.textboxAddress = new System.Windows.Forms.TextBox();
            this.labelAddress = new System.Windows.Forms.Label();
            this.textboxPort = new System.Windows.Forms.TextBox();
            this.labelPort = new System.Windows.Forms.Label();
            this.ManagmentTabs.SuspendLayout();
            this.tabMovies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewMovies)).BeginInit();
            this.tabCategories.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewCategories)).BeginInit();
            this.tabUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewUsers)).BeginInit();
            this.tabSettings.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabHost.SuspendLayout();
            this.SuspendLayout();
            // 
            // ManagmentTabs
            // 
            resources.ApplyResources(this.ManagmentTabs, "ManagmentTabs");
            this.ManagmentTabs.Controls.Add(this.tabMovies);
            this.ManagmentTabs.Controls.Add(this.tabCategories);
            this.ManagmentTabs.Controls.Add(this.tabUsers);
            this.ManagmentTabs.Controls.Add(this.tabSettings);
            this.ManagmentTabs.Controls.Add(this.tabHost);
            this.ManagmentTabs.Name = "ManagmentTabs";
            this.ManagmentTabs.SelectedIndex = 0;
            this.ManagmentTabs.SelectedIndexChanged += new System.EventHandler(this.ManagmentTabs_SelectedIndexChanged);
            // 
            // tabMovies
            // 
            resources.ApplyResources(this.tabMovies, "tabMovies");
            this.tabMovies.Controls.Add(this.buttonFilter);
            this.tabMovies.Controls.Add(this.buttonSearch);
            this.tabMovies.Controls.Add(this.textboxSearch);
            this.tabMovies.Controls.Add(this.gridviewMovies);
            this.tabMovies.Controls.Add(this.buttonAddMovie);
            this.tabMovies.Name = "tabMovies";
            this.tabMovies.UseVisualStyleBackColor = true;
            // 
            // buttonFilter
            // 
            resources.ApplyResources(this.buttonFilter, "buttonFilter");
            this.buttonFilter.Name = "buttonFilter";
            this.buttonFilter.UseVisualStyleBackColor = true;
            this.buttonFilter.Click += new System.EventHandler(this.ButtonFilter_Click);
            // 
            // buttonSearch
            // 
            resources.ApplyResources(this.buttonSearch, "buttonSearch");
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // textboxSearch
            // 
            resources.ApplyResources(this.textboxSearch, "textboxSearch");
            this.textboxSearch.Name = "textboxSearch";
            // 
            // gridviewMovies
            // 
            resources.ApplyResources(this.gridviewMovies, "gridviewMovies");
            this.gridviewMovies.AllowUserToAddRows = false;
            this.gridviewMovies.AllowUserToDeleteRows = false;
            this.gridviewMovies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridviewMovies.Name = "gridviewMovies";
            this.gridviewMovies.ReadOnly = true;
            this.gridviewMovies.RowTemplate.Height = 24;
            this.gridviewMovies.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GridviewMovies_RowHeaderDoubleClick);
            // 
            // buttonAddMovie
            // 
            resources.ApplyResources(this.buttonAddMovie, "buttonAddMovie");
            this.buttonAddMovie.Name = "buttonAddMovie";
            this.buttonAddMovie.UseVisualStyleBackColor = true;
            this.buttonAddMovie.Click += new System.EventHandler(this.ButtonAddMovie_Click);
            // 
            // tabCategories
            // 
            resources.ApplyResources(this.tabCategories, "tabCategories");
            this.tabCategories.Controls.Add(this.buttonCategory);
            this.tabCategories.Controls.Add(this.gridviewCategories);
            this.tabCategories.Name = "tabCategories";
            this.tabCategories.UseVisualStyleBackColor = true;
            // 
            // buttonCategory
            // 
            resources.ApplyResources(this.buttonCategory, "buttonCategory");
            this.buttonCategory.Name = "buttonCategory";
            this.buttonCategory.UseVisualStyleBackColor = true;
            this.buttonCategory.Click += new System.EventHandler(this.ButtonCategory_Click);
            // 
            // gridviewCategories
            // 
            resources.ApplyResources(this.gridviewCategories, "gridviewCategories");
            this.gridviewCategories.AllowUserToAddRows = false;
            this.gridviewCategories.AllowUserToDeleteRows = false;
            this.gridviewCategories.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridviewCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridviewCategories.Name = "gridviewCategories";
            this.gridviewCategories.ReadOnly = true;
            this.gridviewCategories.RowTemplate.Height = 24;
            this.gridviewCategories.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GridviewCategories_RowHeaderDoubleClick);
            // 
            // tabUsers
            // 
            resources.ApplyResources(this.tabUsers, "tabUsers");
            this.tabUsers.Controls.Add(this.buttonValidate);
            this.tabUsers.Controls.Add(this.buttonUnvalidated);
            this.tabUsers.Controls.Add(this.buttonCalculateGender);
            this.tabUsers.Controls.Add(this.buttonUser);
            this.tabUsers.Controls.Add(this.gridviewUsers);
            this.tabUsers.Name = "tabUsers";
            this.tabUsers.UseVisualStyleBackColor = true;
            // 
            // buttonValidate
            // 
            resources.ApplyResources(this.buttonValidate, "buttonValidate");
            this.buttonValidate.Name = "buttonValidate";
            this.buttonValidate.UseVisualStyleBackColor = true;
            this.buttonValidate.Click += new System.EventHandler(this.ButtonValidate_Click);
            // 
            // buttonUnvalidated
            // 
            resources.ApplyResources(this.buttonUnvalidated, "buttonUnvalidated");
            this.buttonUnvalidated.Name = "buttonUnvalidated";
            this.buttonUnvalidated.UseVisualStyleBackColor = true;
            this.buttonUnvalidated.Click += new System.EventHandler(this.ButtonUnvalidated_Click);
            // 
            // buttonCalculateGender
            // 
            resources.ApplyResources(this.buttonCalculateGender, "buttonCalculateGender");
            this.buttonCalculateGender.Name = "buttonCalculateGender";
            this.buttonCalculateGender.UseVisualStyleBackColor = true;
            this.buttonCalculateGender.Click += new System.EventHandler(this.ButtonCalculateGender_Click);
            // 
            // buttonUser
            // 
            resources.ApplyResources(this.buttonUser, "buttonUser");
            this.buttonUser.Name = "buttonUser";
            this.buttonUser.UseVisualStyleBackColor = true;
            this.buttonUser.Click += new System.EventHandler(this.ButtonUser_Click);
            // 
            // gridviewUsers
            // 
            resources.ApplyResources(this.gridviewUsers, "gridviewUsers");
            this.gridviewUsers.AllowUserToAddRows = false;
            this.gridviewUsers.AllowUserToDeleteRows = false;
            this.gridviewUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridviewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridviewUsers.Name = "gridviewUsers";
            this.gridviewUsers.ReadOnly = true;
            this.gridviewUsers.RowTemplate.Height = 24;
            this.gridviewUsers.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GridviewUsers_RowHeaderDoubleClick);
            // 
            // tabSettings
            // 
            resources.ApplyResources(this.tabSettings, "tabSettings");
            this.tabSettings.Controls.Add(this.buttonSave);
            this.tabSettings.Controls.Add(this.panel1);
            this.tabSettings.Controls.Add(this.textboxApiKey);
            this.tabSettings.Controls.Add(this.labelAPIKey);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            resources.ApplyResources(this.buttonSave, "buttonSave");
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(this.textboxKey);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textboxServerDatabase);
            this.panel1.Controls.Add(this.textboxServerPassword);
            this.panel1.Controls.Add(this.textboxServerUser);
            this.panel1.Controls.Add(this.textboxServerName);
            this.panel1.Controls.Add(this.checkboxEnter);
            this.panel1.Controls.Add(this.labelDefaultDatabase);
            this.panel1.Controls.Add(this.labelServerUser);
            this.panel1.Controls.Add(this.labelServerPassword);
            this.panel1.Controls.Add(this.labelServerName);
            this.panel1.Name = "panel1";
            // 
            // textboxKey
            // 
            resources.ApplyResources(this.textboxKey, "textboxKey");
            this.textboxKey.Name = "textboxKey";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // textboxServerDatabase
            // 
            resources.ApplyResources(this.textboxServerDatabase, "textboxServerDatabase");
            this.textboxServerDatabase.Name = "textboxServerDatabase";
            // 
            // textboxServerPassword
            // 
            resources.ApplyResources(this.textboxServerPassword, "textboxServerPassword");
            this.textboxServerPassword.Name = "textboxServerPassword";
            // 
            // textboxServerUser
            // 
            resources.ApplyResources(this.textboxServerUser, "textboxServerUser");
            this.textboxServerUser.Name = "textboxServerUser";
            // 
            // textboxServerName
            // 
            resources.ApplyResources(this.textboxServerName, "textboxServerName");
            this.textboxServerName.Name = "textboxServerName";
            // 
            // checkboxEnter
            // 
            resources.ApplyResources(this.checkboxEnter, "checkboxEnter");
            this.checkboxEnter.Name = "checkboxEnter";
            this.checkboxEnter.UseVisualStyleBackColor = true;
            this.checkboxEnter.CheckedChanged += new System.EventHandler(this.CheckboxEnter_CheckedChanged);
            // 
            // labelDefaultDatabase
            // 
            resources.ApplyResources(this.labelDefaultDatabase, "labelDefaultDatabase");
            this.labelDefaultDatabase.Name = "labelDefaultDatabase";
            // 
            // labelServerUser
            // 
            resources.ApplyResources(this.labelServerUser, "labelServerUser");
            this.labelServerUser.Name = "labelServerUser";
            // 
            // labelServerPassword
            // 
            resources.ApplyResources(this.labelServerPassword, "labelServerPassword");
            this.labelServerPassword.Name = "labelServerPassword";
            // 
            // labelServerName
            // 
            resources.ApplyResources(this.labelServerName, "labelServerName");
            this.labelServerName.Name = "labelServerName";
            // 
            // textboxApiKey
            // 
            resources.ApplyResources(this.textboxApiKey, "textboxApiKey");
            this.textboxApiKey.Name = "textboxApiKey";
            // 
            // labelAPIKey
            // 
            resources.ApplyResources(this.labelAPIKey, "labelAPIKey");
            this.labelAPIKey.Name = "labelAPIKey";
            // 
            // tabHost
            // 
            resources.ApplyResources(this.tabHost, "tabHost");
            this.tabHost.Controls.Add(this.textboxLog);
            this.tabHost.Controls.Add(this.buttonStop);
            this.tabHost.Controls.Add(this.buttonStart);
            this.tabHost.Controls.Add(this.textboxAddress);
            this.tabHost.Controls.Add(this.labelAddress);
            this.tabHost.Controls.Add(this.textboxPort);
            this.tabHost.Controls.Add(this.labelPort);
            this.tabHost.Name = "tabHost";
            this.tabHost.UseVisualStyleBackColor = true;
            // 
            // textboxLog
            // 
            resources.ApplyResources(this.textboxLog, "textboxLog");
            this.textboxLog.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.textboxLog.Name = "textboxLog";
            this.textboxLog.ReadOnly = true;
            // 
            // buttonStop
            // 
            resources.ApplyResources(this.buttonStop, "buttonStop");
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.ButtonStop_Click);
            // 
            // buttonStart
            // 
            resources.ApplyResources(this.buttonStart, "buttonStart");
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.ButtonStart_Click);
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
            // AdminManagement
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ManagmentTabs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AdminManagement";
            this.Load += new System.EventHandler(this.AdminManagement_Load);
            this.ManagmentTabs.ResumeLayout(false);
            this.tabMovies.ResumeLayout(false);
            this.tabMovies.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewMovies)).EndInit();
            this.tabCategories.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridviewCategories)).EndInit();
            this.tabUsers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridviewUsers)).EndInit();
            this.tabSettings.ResumeLayout(false);
            this.tabSettings.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabHost.ResumeLayout(false);
            this.tabHost.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl ManagmentTabs;
        private System.Windows.Forms.TabPage tabMovies;
        private System.Windows.Forms.TabPage tabCategories;
        private System.Windows.Forms.TabPage tabUsers;
        private System.Windows.Forms.Button buttonAddMovie;
        private System.Windows.Forms.DataGridView gridviewMovies;
        private System.Windows.Forms.DataGridView gridviewCategories;
        private System.Windows.Forms.Button buttonCategory;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textboxSearch;
        private System.Windows.Forms.Button buttonFilter;
        private System.Windows.Forms.TabPage tabSettings;
        private System.Windows.Forms.Label labelAPIKey;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textboxServerDatabase;
        private System.Windows.Forms.TextBox textboxServerPassword;
        private System.Windows.Forms.TextBox textboxServerUser;
        private System.Windows.Forms.TextBox textboxServerName;
        private System.Windows.Forms.CheckBox checkboxEnter;
        private System.Windows.Forms.Label labelDefaultDatabase;
        private System.Windows.Forms.Label labelServerUser;
        private System.Windows.Forms.Label labelServerPassword;
        private System.Windows.Forms.Label labelServerName;
        private System.Windows.Forms.TextBox textboxApiKey;
        private System.Windows.Forms.TextBox textboxKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCalculateGender;
        private System.Windows.Forms.Button buttonUser;
        private System.Windows.Forms.DataGridView gridviewUsers;
        private System.Windows.Forms.Button buttonUnvalidated;
        private System.Windows.Forms.Button buttonValidate;
        private System.Windows.Forms.TabPage tabHost;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.TextBox textboxAddress;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.TextBox textboxPort;
        private System.Windows.Forms.Label labelPort;
        private System.Windows.Forms.RichTextBox textboxLog;
    }
}
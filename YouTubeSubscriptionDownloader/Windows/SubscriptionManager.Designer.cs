﻿namespace YouTubeSubscriptionDownloader
{
    partial class SubscriptionManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubscriptionManager));
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelPlaylistOverview = new System.Windows.Forms.Label();
            this.labelPlaylistURL = new System.Windows.Forms.Label();
            this.textBoxPlaylistURL = new System.Windows.Forms.TextBox();
            this.textBoxRegex = new System.Windows.Forms.TextBox();
            this.labelRegex = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBoxManualSub = new System.Windows.Forms.GroupBox();
            this.pictureBoxAdd = new System.Windows.Forms.PictureBox();
            this.buttonGetYTSubscriptions = new System.Windows.Forms.Button();
            this.gridPlaylists = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBoxManualSub.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPlaylists)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.Location = new System.Drawing.Point(613, 4);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 3;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.Location = new System.Drawing.Point(694, 4);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelPlaylistOverview
            // 
            this.labelPlaylistOverview.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelPlaylistOverview.Location = new System.Drawing.Point(0, 0);
            this.labelPlaylistOverview.Name = "labelPlaylistOverview";
            this.labelPlaylistOverview.Size = new System.Drawing.Size(781, 32);
            this.labelPlaylistOverview.TabIndex = 4;
            this.labelPlaylistOverview.Text = "Manage the playlists (your YouTube subscriptions and other YouTube playlists) tha" +
    "t will be watched for new uploads";
            // 
            // labelPlaylistURL
            // 
            this.labelPlaylistURL.AutoSize = true;
            this.labelPlaylistURL.Location = new System.Drawing.Point(9, 22);
            this.labelPlaylistURL.Name = "labelPlaylistURL";
            this.labelPlaylistURL.Size = new System.Drawing.Size(67, 13);
            this.labelPlaylistURL.TabIndex = 5;
            this.labelPlaylistURL.Text = "Playlist URL:";
            // 
            // textBoxPlaylistURL
            // 
            this.textBoxPlaylistURL.Location = new System.Drawing.Point(82, 19);
            this.textBoxPlaylistURL.Name = "textBoxPlaylistURL";
            this.textBoxPlaylistURL.Size = new System.Drawing.Size(658, 20);
            this.textBoxPlaylistURL.TabIndex = 6;
            // 
            // textBoxRegex
            // 
            this.textBoxRegex.Location = new System.Drawing.Point(122, 42);
            this.textBoxRegex.Name = "textBoxRegex";
            this.textBoxRegex.Size = new System.Drawing.Size(618, 20);
            this.textBoxRegex.TabIndex = 9;
            // 
            // labelRegex
            // 
            this.labelRegex.AutoSize = true;
            this.labelRegex.Location = new System.Drawing.Point(9, 45);
            this.labelRegex.Name = "labelRegex";
            this.labelRegex.Size = new System.Drawing.Size(107, 13);
            this.labelRegex.TabIndex = 10;
            this.labelRegex.Text = "Filter regex (optional):";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonCancel);
            this.panel1.Controls.Add(this.buttonSave);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 545);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(781, 39);
            this.panel1.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBoxManualSub);
            this.panel2.Controls.Add(this.buttonGetYTSubscriptions);
            this.panel2.Controls.Add(this.gridPlaylists);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(781, 513);
            this.panel2.TabIndex = 12;
            // 
            // groupBoxManualSub
            // 
            this.groupBoxManualSub.Controls.Add(this.textBoxRegex);
            this.groupBoxManualSub.Controls.Add(this.pictureBoxAdd);
            this.groupBoxManualSub.Controls.Add(this.textBoxPlaylistURL);
            this.groupBoxManualSub.Controls.Add(this.labelPlaylistURL);
            this.groupBoxManualSub.Controls.Add(this.labelRegex);
            this.groupBoxManualSub.Location = new System.Drawing.Point(6, 443);
            this.groupBoxManualSub.Name = "groupBoxManualSub";
            this.groupBoxManualSub.Size = new System.Drawing.Size(772, 68);
            this.groupBoxManualSub.TabIndex = 13;
            this.groupBoxManualSub.TabStop = false;
            this.groupBoxManualSub.Text = "Manual Subscription";
            // 
            // pictureBoxAdd
            // 
            this.pictureBoxAdd.Image = global::YouTubeSubscriptionDownloader.Properties.Resources.plus_black_symbol;
            this.pictureBoxAdd.Location = new System.Drawing.Point(746, 19);
            this.pictureBoxAdd.Name = "pictureBoxAdd";
            this.pictureBoxAdd.Size = new System.Drawing.Size(20, 20);
            this.pictureBoxAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxAdd.TabIndex = 7;
            this.pictureBoxAdd.TabStop = false;
            this.pictureBoxAdd.Click += new System.EventHandler(this.pictureBoxAdd_Click);
            // 
            // buttonGetYTSubscriptions
            // 
            this.buttonGetYTSubscriptions.Location = new System.Drawing.Point(591, 402);
            this.buttonGetYTSubscriptions.Name = "buttonGetYTSubscriptions";
            this.buttonGetYTSubscriptions.Size = new System.Drawing.Size(178, 23);
            this.buttonGetYTSubscriptions.TabIndex = 12;
            this.buttonGetYTSubscriptions.Text = "Get Subscriptions From YouTube";
            this.buttonGetYTSubscriptions.UseVisualStyleBackColor = true;
            this.buttonGetYTSubscriptions.Click += new System.EventHandler(this.ButtonGetYTSubscriptions_Click);
            // 
            // gridPlaylists
            // 
            this.gridPlaylists.AllowUserToAddRows = false;
            this.gridPlaylists.AllowUserToResizeColumns = false;
            this.gridPlaylists.AllowUserToResizeRows = false;
            this.gridPlaylists.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridPlaylists.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPlaylists.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.gridPlaylists.Location = new System.Drawing.Point(3, 0);
            this.gridPlaylists.MultiSelect = false;
            this.gridPlaylists.Name = "gridPlaylists";
            this.gridPlaylists.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridPlaylists.RowHeadersVisible = false;
            this.gridPlaylists.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridPlaylists.Size = new System.Drawing.Size(775, 396);
            this.gridPlaylists.TabIndex = 11;
            this.gridPlaylists.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GridPlaylists_KeyDown);
            this.gridPlaylists.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GridPlaylists_MouseDown);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Playlist";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Search Regex";
            this.Column2.Name = "Column2";
            // 
            // PlaylistManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 584);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelPlaylistOverview);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(420, 349);
            this.Name = "PlaylistManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Subscription Manager";
            this.Resize += new System.EventHandler(this.PlaylistManager_Resize);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBoxManualSub.ResumeLayout(false);
            this.groupBoxManualSub.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPlaylists)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelPlaylistOverview;
        private System.Windows.Forms.Label labelPlaylistURL;
        private System.Windows.Forms.TextBox textBoxPlaylistURL;
        private System.Windows.Forms.TextBox textBoxRegex;
        private System.Windows.Forms.Label labelRegex;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView gridPlaylists;
        private System.Windows.Forms.GroupBox groupBoxManualSub;
        private System.Windows.Forms.PictureBox pictureBoxAdd;
        private System.Windows.Forms.Button buttonGetYTSubscriptions;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}
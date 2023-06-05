namespace musilla
{
    partial class kitaplik
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.calmalisteleriDGV = new System.Windows.Forms.DataGridView();
            this.SelectedPlaylist = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.OpenList = new Guna.UI2.WinForms.Guna2Button();
            this.RefreshList = new Guna.UI2.WinForms.Guna2Button();
            this.EditList = new Guna.UI2.WinForms.Guna2Button();
            this.DeleteList = new Guna.UI2.WinForms.Guna2Button();
            this.CreateList = new Guna.UI2.WinForms.Guna2Button();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.playlistID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.baslik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aciklama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.calmalisteleriDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // calmalisteleriDGV
            // 
            this.calmalisteleriDGV.AllowUserToAddRows = false;
            this.calmalisteleriDGV.AllowUserToDeleteRows = false;
            this.calmalisteleriDGV.AllowUserToResizeColumns = false;
            this.calmalisteleriDGV.AllowUserToResizeRows = false;
            this.calmalisteleriDGV.BackgroundColor = System.Drawing.SystemColors.Control;
            this.calmalisteleriDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.calmalisteleriDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(222)))), ((int)(((byte)(177)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.calmalisteleriDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.calmalisteleriDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.calmalisteleriDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.playlistID,
            this.baslik,
            this.aciklama});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(222)))), ((int)(((byte)(177)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.calmalisteleriDGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.calmalisteleriDGV.GridColor = System.Drawing.Color.White;
            this.calmalisteleriDGV.Location = new System.Drawing.Point(12, 40);
            this.calmalisteleriDGV.MultiSelect = false;
            this.calmalisteleriDGV.Name = "calmalisteleriDGV";
            this.calmalisteleriDGV.ReadOnly = true;
            this.calmalisteleriDGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(222)))), ((int)(((byte)(177)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.calmalisteleriDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.calmalisteleriDGV.RowHeadersVisible = false;
            this.calmalisteleriDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(222)))), ((int)(((byte)(177)))));
            this.calmalisteleriDGV.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.calmalisteleriDGV.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.calmalisteleriDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.calmalisteleriDGV.Size = new System.Drawing.Size(826, 550);
            this.calmalisteleriDGV.TabIndex = 9;
            this.calmalisteleriDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.calmalisteleriDGV_CellClick);
            // 
            // SelectedPlaylist
            // 
            this.SelectedPlaylist.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SelectedPlaylist.DefaultText = "";
            this.SelectedPlaylist.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.SelectedPlaylist.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.SelectedPlaylist.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SelectedPlaylist.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SelectedPlaylist.Enabled = false;
            this.SelectedPlaylist.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SelectedPlaylist.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SelectedPlaylist.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SelectedPlaylist.Location = new System.Drawing.Point(653, 612);
            this.SelectedPlaylist.Name = "SelectedPlaylist";
            this.SelectedPlaylist.PasswordChar = '\0';
            this.SelectedPlaylist.PlaceholderText = "";
            this.SelectedPlaylist.SelectedText = "";
            this.SelectedPlaylist.Size = new System.Drawing.Size(185, 26);
            this.SelectedPlaylist.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(653, 593);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Seçilen Liste";
            // 
            // OpenList
            // 
            this.OpenList.AutoRoundedCorners = true;
            this.OpenList.BorderRadius = 21;
            this.OpenList.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.OpenList.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.OpenList.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.OpenList.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.OpenList.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(222)))), ((int)(((byte)(177)))));
            this.OpenList.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.OpenList.ForeColor = System.Drawing.Color.White;
            this.OpenList.Image = global::musilla.Properties.Resources.icons8_playlist_50;
            this.OpenList.ImageSize = new System.Drawing.Size(25, 25);
            this.OpenList.Location = new System.Drawing.Point(296, 593);
            this.OpenList.Name = "OpenList";
            this.OpenList.Size = new System.Drawing.Size(136, 45);
            this.OpenList.TabIndex = 16;
            this.OpenList.Text = "Listeyi Aç";
            this.OpenList.Click += new System.EventHandler(this.OpenList_Click);
            // 
            // RefreshList
            // 
            this.RefreshList.Animated = true;
            this.RefreshList.AutoRoundedCorners = true;
            this.RefreshList.BackColor = System.Drawing.Color.Transparent;
            this.RefreshList.BorderRadius = 21;
            this.RefreshList.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.RefreshList.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.RefreshList.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.RefreshList.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.RefreshList.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(222)))), ((int)(((byte)(177)))));
            this.RefreshList.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.RefreshList.ForeColor = System.Drawing.Color.White;
            this.RefreshList.Image = global::musilla.Properties.Resources.icons8_refresh_50;
            this.RefreshList.ImageSize = new System.Drawing.Size(25, 25);
            this.RefreshList.Location = new System.Drawing.Point(596, 593);
            this.RefreshList.Name = "RefreshList";
            this.RefreshList.Size = new System.Drawing.Size(51, 45);
            this.RefreshList.TabIndex = 15;
            this.RefreshList.Click += new System.EventHandler(this.RefreshList_Click);
            // 
            // EditList
            // 
            this.EditList.AutoRoundedCorners = true;
            this.EditList.BorderRadius = 21;
            this.EditList.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.EditList.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.EditList.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.EditList.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.EditList.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(222)))), ((int)(((byte)(177)))));
            this.EditList.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.EditList.ForeColor = System.Drawing.Color.White;
            this.EditList.Image = global::musilla.Properties.Resources.icons8_create_52;
            this.EditList.ImageSize = new System.Drawing.Size(25, 25);
            this.EditList.Location = new System.Drawing.Point(438, 593);
            this.EditList.Name = "EditList";
            this.EditList.Size = new System.Drawing.Size(152, 45);
            this.EditList.TabIndex = 14;
            this.EditList.Text = "Listeyi Düzenle";
            this.EditList.Click += new System.EventHandler(this.EditList_Click);
            // 
            // DeleteList
            // 
            this.DeleteList.AutoRoundedCorners = true;
            this.DeleteList.BorderRadius = 21;
            this.DeleteList.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.DeleteList.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.DeleteList.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DeleteList.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.DeleteList.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(222)))), ((int)(((byte)(177)))));
            this.DeleteList.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.DeleteList.ForeColor = System.Drawing.Color.White;
            this.DeleteList.Image = global::musilla.Properties.Resources.icons8_minus_50;
            this.DeleteList.ImageSize = new System.Drawing.Size(25, 25);
            this.DeleteList.Location = new System.Drawing.Point(154, 593);
            this.DeleteList.Name = "DeleteList";
            this.DeleteList.Size = new System.Drawing.Size(136, 45);
            this.DeleteList.TabIndex = 13;
            this.DeleteList.Text = "Listeyi Sil";
            this.DeleteList.Click += new System.EventHandler(this.DeleteList_Click);
            // 
            // CreateList
            // 
            this.CreateList.AutoRoundedCorners = true;
            this.CreateList.BorderRadius = 21;
            this.CreateList.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.CreateList.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.CreateList.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.CreateList.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.CreateList.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(222)))), ((int)(((byte)(177)))));
            this.CreateList.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CreateList.ForeColor = System.Drawing.Color.White;
            this.CreateList.Image = global::musilla.Properties.Resources.icons8_add_50;
            this.CreateList.ImageSize = new System.Drawing.Size(25, 25);
            this.CreateList.Location = new System.Drawing.Point(12, 593);
            this.CreateList.Name = "CreateList";
            this.CreateList.Size = new System.Drawing.Size(136, 45);
            this.CreateList.TabIndex = 12;
            this.CreateList.Text = "Liste Oluştur";
            this.CreateList.Click += new System.EventHandler(this.CreateList_Click);
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox1.Location = new System.Drawing.Point(12, 61);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(826, 2);
            this.guna2GroupBox1.TabIndex = 19;
            this.guna2GroupBox1.Text = "guna2GroupBox1";
            // 
            // playlistID
            // 
            this.playlistID.HeaderText = "playlistID";
            this.playlistID.Name = "playlistID";
            this.playlistID.ReadOnly = true;
            this.playlistID.Visible = false;
            // 
            // baslik
            // 
            this.baslik.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.baslik.FillWeight = 50F;
            this.baslik.HeaderText = "Başlık";
            this.baslik.Name = "baslik";
            this.baslik.ReadOnly = true;
            // 
            // aciklama
            // 
            this.aciklama.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.aciklama.HeaderText = "Açıklama";
            this.aciklama.Name = "aciklama";
            this.aciklama.ReadOnly = true;
            this.aciklama.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // kitaplik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 650);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SelectedPlaylist);
            this.Controls.Add(this.OpenList);
            this.Controls.Add(this.RefreshList);
            this.Controls.Add(this.EditList);
            this.Controls.Add(this.DeleteList);
            this.Controls.Add(this.CreateList);
            this.Controls.Add(this.calmalisteleriDGV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "kitaplik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "kitaplik";
            this.Load += new System.EventHandler(this.kitaplik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.calmalisteleriDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView calmalisteleriDGV;
        private Guna.UI2.WinForms.Guna2Button CreateList;
        private Guna.UI2.WinForms.Guna2Button DeleteList;
        private Guna.UI2.WinForms.Guna2Button EditList;
        private Guna.UI2.WinForms.Guna2Button RefreshList;
        private Guna.UI2.WinForms.Guna2Button OpenList;
        private Guna.UI2.WinForms.Guna2TextBox SelectedPlaylist;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn playlistID;
        private System.Windows.Forms.DataGridViewTextBoxColumn baslik;
        private System.Windows.Forms.DataGridViewTextBoxColumn aciklama;
    }
}
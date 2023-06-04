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
            this.kitapliksecilenlisteyiduzenleme = new System.Windows.Forms.Button();
            this.kitapliklisteyisil = new System.Windows.Forms.Button();
            this.kitapliklisteekle = new System.Windows.Forms.Button();
            this.calmalisteleriDGV = new System.Windows.Forms.DataGridView();
            this.kitaplikyenile = new System.Windows.Forms.Button();
            this.kitapliklisteyiac = new System.Windows.Forms.Button();
            this.playlistID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.baslik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aciklama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.calmalisteleriDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // kitapliksecilenlisteyiduzenleme
            // 
            this.kitapliksecilenlisteyiduzenleme.Location = new System.Drawing.Point(731, 70);
            this.kitapliksecilenlisteyiduzenleme.Name = "kitapliksecilenlisteyiduzenleme";
            this.kitapliksecilenlisteyiduzenleme.Size = new System.Drawing.Size(107, 34);
            this.kitapliksecilenlisteyiduzenleme.TabIndex = 5;
            this.kitapliksecilenlisteyiduzenleme.Text = "Seçilen Listeyi Düzenle";
            this.kitapliksecilenlisteyiduzenleme.UseVisualStyleBackColor = true;
            this.kitapliksecilenlisteyiduzenleme.Click += new System.EventHandler(this.kitapliksecilenlisteyiduzenleme_Click);
            // 
            // kitapliklisteyisil
            // 
            this.kitapliklisteyisil.Location = new System.Drawing.Point(731, 110);
            this.kitapliklisteyisil.Name = "kitapliklisteyisil";
            this.kitapliklisteyisil.Size = new System.Drawing.Size(107, 34);
            this.kitapliklisteyisil.TabIndex = 6;
            this.kitapliklisteyisil.Text = "Seçilen Listeyi Sil";
            this.kitapliklisteyisil.UseVisualStyleBackColor = true;
            this.kitapliklisteyisil.Click += new System.EventHandler(this.kitapliklisteyisil_Click);
            // 
            // kitapliklisteekle
            // 
            this.kitapliklisteekle.Location = new System.Drawing.Point(731, 150);
            this.kitapliklisteekle.Name = "kitapliklisteekle";
            this.kitapliklisteekle.Size = new System.Drawing.Size(107, 34);
            this.kitapliklisteekle.TabIndex = 7;
            this.kitapliklisteekle.Text = "Yeni Liste Ekle";
            this.kitapliklisteekle.UseVisualStyleBackColor = true;
            this.kitapliklisteekle.Click += new System.EventHandler(this.kitapliklisteekle_Click);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(222)))), ((int)(((byte)(177)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
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
            this.calmalisteleriDGV.Location = new System.Drawing.Point(12, 12);
            this.calmalisteleriDGV.Name = "calmalisteleriDGV";
            this.calmalisteleriDGV.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
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
            this.calmalisteleriDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.calmalisteleriDGV.Size = new System.Drawing.Size(660, 532);
            this.calmalisteleriDGV.TabIndex = 9;
            this.calmalisteleriDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.calmalisteleriDGV_CellClick);
            this.calmalisteleriDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.calmalisteleriDGV_CellContentClick);
            this.calmalisteleriDGV.SelectionChanged += new System.EventHandler(this.calmalisteleriDGV_SelectionChanged);
            // 
            // kitaplikyenile
            // 
            this.kitaplikyenile.Location = new System.Drawing.Point(731, 301);
            this.kitaplikyenile.Name = "kitaplikyenile";
            this.kitaplikyenile.Size = new System.Drawing.Size(107, 34);
            this.kitaplikyenile.TabIndex = 10;
            this.kitaplikyenile.Text = "Listeleri Yenile";
            this.kitaplikyenile.UseVisualStyleBackColor = true;
            this.kitaplikyenile.Click += new System.EventHandler(this.kitaplikyenile_Click);
            // 
            // kitapliklisteyiac
            // 
            this.kitapliklisteyiac.Location = new System.Drawing.Point(731, 190);
            this.kitapliklisteyiac.Name = "kitapliklisteyiac";
            this.kitapliklisteyiac.Size = new System.Drawing.Size(107, 34);
            this.kitapliklisteyiac.TabIndex = 11;
            this.kitapliklisteyiac.Text = "Listeyi Aç";
            this.kitapliklisteyiac.UseVisualStyleBackColor = true;
            this.kitapliklisteyiac.Click += new System.EventHandler(this.kitapliklisteyiac_Click);
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
            // 
            // guna2Button1
            // 
            this.guna2Button1.AutoRoundedCorners = true;
            this.guna2Button1.BorderRadius = 21;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(222)))), ((int)(((byte)(177)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Image = global::musilla.Properties.Resources.icons8_add_50;
            this.guna2Button1.ImageSize = new System.Drawing.Size(25, 25);
            this.guna2Button1.Location = new System.Drawing.Point(12, 593);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(162, 45);
            this.guna2Button1.TabIndex = 12;
            this.guna2Button1.Text = "Yeni Liste Oluştur";
            // 
            // guna2Button2
            // 
            this.guna2Button2.AutoRoundedCorners = true;
            this.guna2Button2.BorderRadius = 21;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(222)))), ((int)(((byte)(177)))));
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Image = global::musilla.Properties.Resources.icons8_add_50;
            this.guna2Button2.ImageSize = new System.Drawing.Size(25, 25);
            this.guna2Button2.Location = new System.Drawing.Point(180, 593);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(162, 45);
            this.guna2Button2.TabIndex = 13;
            this.guna2Button2.Text = "Yeni Liste Oluştur";
            // 
            // guna2Button3
            // 
            this.guna2Button3.AutoRoundedCorners = true;
            this.guna2Button3.BorderRadius = 21;
            this.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(222)))), ((int)(((byte)(177)))));
            this.guna2Button3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guna2Button3.ForeColor = System.Drawing.Color.White;
            this.guna2Button3.Image = global::musilla.Properties.Resources.icons8_add_50;
            this.guna2Button3.ImageSize = new System.Drawing.Size(25, 25);
            this.guna2Button3.Location = new System.Drawing.Point(348, 593);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.Size = new System.Drawing.Size(162, 45);
            this.guna2Button3.TabIndex = 14;
            this.guna2Button3.Text = "Yeni Liste Oluştur";
            // 
            // kitaplik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 650);
            this.Controls.Add(this.guna2Button3);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.kitapliklisteyiac);
            this.Controls.Add(this.kitaplikyenile);
            this.Controls.Add(this.calmalisteleriDGV);
            this.Controls.Add(this.kitapliklisteekle);
            this.Controls.Add(this.kitapliklisteyisil);
            this.Controls.Add(this.kitapliksecilenlisteyiduzenleme);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "kitaplik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "kitaplik";
            this.Load += new System.EventHandler(this.kitaplik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.calmalisteleriDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button kitapliksecilenlisteyiduzenleme;
        private System.Windows.Forms.Button kitapliklisteyisil;
        private System.Windows.Forms.Button kitapliklisteekle;
        private System.Windows.Forms.DataGridView calmalisteleriDGV;
        private System.Windows.Forms.Button kitaplikyenile;
        private System.Windows.Forms.Button kitapliklisteyiac;
        private System.Windows.Forms.DataGridViewTextBoxColumn playlistID;
        private System.Windows.Forms.DataGridViewTextBoxColumn baslik;
        private System.Windows.Forms.DataGridViewTextBoxColumn aciklama;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
    }
}
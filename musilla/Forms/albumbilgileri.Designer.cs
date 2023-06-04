namespace musilla
{
    partial class albumbilgileri
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
            this.NameLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.AboutLabel = new System.Windows.Forms.Label();
            this.AlbumSongDGV = new System.Windows.Forms.DataGridView();
            this.albumbilgilerigeri = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Şarkılar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sanatçılar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tür = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Süre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlbumSongDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Gotham", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(168, 112);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(161, 39);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "*********";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::musilla.Properties.Resources.Ekran_görüntüsü_2023_04_23_041627;
            this.pictureBox1.Location = new System.Drawing.Point(12, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // AboutLabel
            // 
            this.AboutLabel.AutoSize = true;
            this.AboutLabel.Location = new System.Drawing.Point(168, 173);
            this.AboutLabel.Name = "AboutLabel";
            this.AboutLabel.Size = new System.Drawing.Size(88, 13);
            this.AboutLabel.TabIndex = 2;
            this.AboutLabel.Text = "----- • ----- • ----- • ";
            // 
            // AlbumSongDGV
            // 
            this.AlbumSongDGV.AllowUserToAddRows = false;
            this.AlbumSongDGV.AllowUserToDeleteRows = false;
            this.AlbumSongDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.AlbumSongDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Şarkılar,
            this.Sanatçılar,
            this.Tür,
            this.Süre});
            this.AlbumSongDGV.Location = new System.Drawing.Point(11, 202);
            this.AlbumSongDGV.Name = "AlbumSongDGV";
            this.AlbumSongDGV.ReadOnly = true;
            this.AlbumSongDGV.RowHeadersVisible = false;
            this.AlbumSongDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.AlbumSongDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AlbumSongDGV.Size = new System.Drawing.Size(860, 236);
            this.AlbumSongDGV.TabIndex = 3;
            this.AlbumSongDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AlbumSongDGV_CellClick);
            this.AlbumSongDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AlbumSongDGV_CellContentClick);
            // 
            // albumbilgilerigeri
            // 
            this.albumbilgilerigeri.Location = new System.Drawing.Point(12, 8);
            this.albumbilgilerigeri.Name = "albumbilgilerigeri";
            this.albumbilgilerigeri.Size = new System.Drawing.Size(75, 25);
            this.albumbilgilerigeri.TabIndex = 4;
            this.albumbilgilerigeri.Text = "Geri";
            this.albumbilgilerigeri.UseVisualStyleBackColor = true;
            this.albumbilgilerigeri.Click += new System.EventHandler(this.albumbilgilerigeri_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(168, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Albüm";
            // 
            // Şarkılar
            // 
            this.Şarkılar.HeaderText = "Şarkılar";
            this.Şarkılar.Name = "Şarkılar";
            this.Şarkılar.ReadOnly = true;
            this.Şarkılar.Width = 405;
            // 
            // Sanatçılar
            // 
            this.Sanatçılar.HeaderText = "Sanatçılar";
            this.Sanatçılar.Name = "Sanatçılar";
            this.Sanatçılar.ReadOnly = true;
            this.Sanatçılar.Width = 224;
            // 
            // Tür
            // 
            this.Tür.HeaderText = "Tür";
            this.Tür.Name = "Tür";
            this.Tür.ReadOnly = true;
            this.Tür.Width = 124;
            // 
            // Süre
            // 
            this.Süre.HeaderText = "Süre";
            this.Süre.Name = "Süre";
            this.Süre.ReadOnly = true;
            // 
            // albumbilgileri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.albumbilgilerigeri);
            this.Controls.Add(this.AlbumSongDGV);
            this.Controls.Add(this.AboutLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.NameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "albumbilgileri";
            this.Text = "albumbilgileri";
            this.Load += new System.EventHandler(this.albumbilgileri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlbumSongDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label AboutLabel;
        private System.Windows.Forms.DataGridView AlbumSongDGV;
        private System.Windows.Forms.Button albumbilgilerigeri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Şarkılar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sanatçılar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tür;
        private System.Windows.Forms.DataGridViewTextBoxColumn Süre;
    }
}
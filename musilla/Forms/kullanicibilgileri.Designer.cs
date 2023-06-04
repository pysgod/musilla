namespace musilla.Forms
{
    partial class kullanicibilgileri
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
            this.albumbilgilerigeri = new System.Windows.Forms.Button();
            this.UserDGV = new System.Windows.Forms.DataGridView();
            this.AboutLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.calmalisteleri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aciklama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.UserDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // albumbilgilerigeri
            // 
            this.albumbilgilerigeri.Location = new System.Drawing.Point(12, 8);
            this.albumbilgilerigeri.Name = "albumbilgilerigeri";
            this.albumbilgilerigeri.Size = new System.Drawing.Size(75, 25);
            this.albumbilgilerigeri.TabIndex = 10;
            this.albumbilgilerigeri.Text = "Geri";
            this.albumbilgilerigeri.UseVisualStyleBackColor = true;
            this.albumbilgilerigeri.Click += new System.EventHandler(this.albumbilgilerigeri_Click);
            // 
            // UserDGV
            // 
            this.UserDGV.AllowUserToAddRows = false;
            this.UserDGV.AllowUserToDeleteRows = false;
            this.UserDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.UserDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.calmalisteleri,
            this.aciklama});
            this.UserDGV.Location = new System.Drawing.Point(11, 202);
            this.UserDGV.Name = "UserDGV";
            this.UserDGV.ReadOnly = true;
            this.UserDGV.RowHeadersVisible = false;
            this.UserDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.UserDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.UserDGV.Size = new System.Drawing.Size(860, 240);
            this.UserDGV.TabIndex = 9;
            // 
            // AboutLabel
            // 
            this.AboutLabel.AutoSize = true;
            this.AboutLabel.Location = new System.Drawing.Point(168, 173);
            this.AboutLabel.Name = "AboutLabel";
            this.AboutLabel.Size = new System.Drawing.Size(88, 13);
            this.AboutLabel.TabIndex = 8;
            this.AboutLabel.Text = "----- • ----- • ----- • ";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Gotham", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(168, 112);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(161, 39);
            this.NameLabel.TabIndex = 6;
            this.NameLabel.Text = "*********";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(168, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Profil";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::musilla.Properties.Resources.Ekran_görüntüsü_2023_04_23_041627;
            this.pictureBox1.Location = new System.Drawing.Point(12, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // calmalisteleri
            // 
            this.calmalisteleri.HeaderText = "Çalma Listeleri";
            this.calmalisteleri.Name = "calmalisteleri";
            this.calmalisteleri.ReadOnly = true;
            this.calmalisteleri.Width = 145;
            // 
            // aciklama
            // 
            this.aciklama.HeaderText = "Açıklama";
            this.aciklama.Name = "aciklama";
            this.aciklama.ReadOnly = true;
            this.aciklama.Width = 710;
            // 
            // kullanicibilgileri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.albumbilgilerigeri);
            this.Controls.Add(this.UserDGV);
            this.Controls.Add(this.AboutLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.NameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "kullanicibilgileri";
            this.Text = "kullanicibilgileri";
            this.Load += new System.EventHandler(this.kullanicibilgileri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UserDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button albumbilgilerigeri;
        private System.Windows.Forms.DataGridView UserDGV;
        private System.Windows.Forms.Label AboutLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn calmalisteleri;
        private System.Windows.Forms.DataGridViewTextBoxColumn aciklama;
    }
}
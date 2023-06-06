namespace musilla.Forms
{
    partial class sanatcibilgileri
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
            this.label1 = new System.Windows.Forms.Label();
            this.songDGV = new System.Windows.Forms.DataGridView();
            this.ÇalmaListeleri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AboutLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.albumDGV = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.albumbilgilerigeri = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.songDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(168, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Sanatçı";
            // 
            // songDGV
            // 
            this.songDGV.AllowUserToAddRows = false;
            this.songDGV.AllowUserToDeleteRows = false;
            this.songDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.songDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ÇalmaListeleri,
            this.sure});
            this.songDGV.Location = new System.Drawing.Point(109, 259);
            this.songDGV.Name = "songDGV";
            this.songDGV.ReadOnly = true;
            this.songDGV.RowHeadersVisible = false;
            this.songDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.songDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.songDGV.Size = new System.Drawing.Size(417, 265);
            this.songDGV.TabIndex = 15;
            // 
            // ÇalmaListeleri
            // 
            this.ÇalmaListeleri.HeaderText = "Şarkılar";
            this.ÇalmaListeleri.Name = "ÇalmaListeleri";
            this.ÇalmaListeleri.ReadOnly = true;
            this.ÇalmaListeleri.Width = 371;
            // 
            // sure
            // 
            this.sure.HeaderText = "Süre";
            this.sure.Name = "sure";
            this.sure.ReadOnly = true;
            this.sure.Width = 41;
            // 
            // AboutLabel
            // 
            this.AboutLabel.AutoSize = true;
            this.AboutLabel.Location = new System.Drawing.Point(168, 230);
            this.AboutLabel.Name = "AboutLabel";
            this.AboutLabel.Size = new System.Drawing.Size(88, 13);
            this.AboutLabel.TabIndex = 14;
            this.AboutLabel.Text = "----- • ----- • ----- • ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::musilla.Properties.Resources.Ekran_görüntüsü_2023_04_23_041627;
            this.pictureBox1.Location = new System.Drawing.Point(12, 103);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Gotham", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(168, 169);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(161, 39);
            this.NameLabel.TabIndex = 12;
            this.NameLabel.Text = "*********";
            // 
            // albumDGV
            // 
            this.albumDGV.AllowUserToAddRows = false;
            this.albumDGV.AllowUserToDeleteRows = false;
            this.albumDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.albumDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.albumDGV.Location = new System.Drawing.Point(532, 259);
            this.albumDGV.Name = "albumDGV";
            this.albumDGV.ReadOnly = true;
            this.albumDGV.RowHeadersVisible = false;
            this.albumDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.albumDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.albumDGV.Size = new System.Drawing.Size(417, 265);
            this.albumDGV.TabIndex = 17;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Albümler";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 412;
            // 
            // albumbilgilerigeri
            // 
            this.albumbilgilerigeri.Location = new System.Drawing.Point(12, 69);
            this.albumbilgilerigeri.Name = "albumbilgilerigeri";
            this.albumbilgilerigeri.Size = new System.Drawing.Size(75, 25);
            this.albumbilgilerigeri.TabIndex = 18;
            this.albumbilgilerigeri.Text = "Geri";
            this.albumbilgilerigeri.UseVisualStyleBackColor = true;
            this.albumbilgilerigeri.Click += new System.EventHandler(this.albumbilgilerigeri_Click);
            // 
            // sanatcibilgileri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 650);
            this.Controls.Add(this.albumbilgilerigeri);
            this.Controls.Add(this.albumDGV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.songDGV);
            this.Controls.Add(this.AboutLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.NameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "sanatcibilgileri";
            this.Text = "sanatcibilgileri";
            this.Load += new System.EventHandler(this.sanatcibilgileri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.songDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView songDGV;
        private System.Windows.Forms.Label AboutLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.DataGridView albumDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ÇalmaListeleri;
        private System.Windows.Forms.DataGridViewTextBoxColumn sure;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button albumbilgilerigeri;
    }
}
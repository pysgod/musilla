namespace musilla
{
    partial class calmalistesi
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
            this.calmalistesiDGV = new System.Windows.Forms.DataGridView();
            this.sarkiID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.baslik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sanatcilar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.albumler = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteFromList = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.calmalistesiDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // calmalistesiDGV
            // 
            this.calmalistesiDGV.AllowUserToAddRows = false;
            this.calmalistesiDGV.AllowUserToDeleteRows = false;
            this.calmalistesiDGV.AllowUserToResizeColumns = false;
            this.calmalistesiDGV.AllowUserToResizeRows = false;
            this.calmalistesiDGV.BackgroundColor = System.Drawing.SystemColors.Control;
            this.calmalistesiDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.calmalistesiDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(222)))), ((int)(((byte)(177)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.calmalistesiDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.calmalistesiDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.calmalistesiDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sarkiID,
            this.baslik,
            this.sanatcilar,
            this.albumler,
            this.tur,
            this.sure});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(222)))), ((int)(((byte)(177)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.calmalistesiDGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.calmalistesiDGV.GridColor = System.Drawing.Color.White;
            this.calmalistesiDGV.Location = new System.Drawing.Point(12, 40);
            this.calmalistesiDGV.MultiSelect = false;
            this.calmalistesiDGV.Name = "calmalistesiDGV";
            this.calmalistesiDGV.ReadOnly = true;
            this.calmalistesiDGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(222)))), ((int)(((byte)(177)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.calmalistesiDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.calmalistesiDGV.RowHeadersVisible = false;
            this.calmalistesiDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(222)))), ((int)(((byte)(177)))));
            this.calmalistesiDGV.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.calmalistesiDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.calmalistesiDGV.Size = new System.Drawing.Size(1061, 547);
            this.calmalistesiDGV.TabIndex = 24;
            this.calmalistesiDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.calmalistesiDGV_CellClick);
            this.calmalistesiDGV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.calmalistesiDGV_CellDoubleClick);
            // 
            // sarkiID
            // 
            this.sarkiID.HeaderText = "sarkiID";
            this.sarkiID.Name = "sarkiID";
            this.sarkiID.ReadOnly = true;
            this.sarkiID.Visible = false;
            // 
            // baslik
            // 
            this.baslik.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.baslik.FillWeight = 50F;
            this.baslik.HeaderText = "Başlık";
            this.baslik.Name = "baslik";
            this.baslik.ReadOnly = true;
            // 
            // sanatcilar
            // 
            this.sanatcilar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sanatcilar.HeaderText = "Sanatcilar";
            this.sanatcilar.Name = "sanatcilar";
            this.sanatcilar.ReadOnly = true;
            // 
            // albumler
            // 
            this.albumler.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.albumler.HeaderText = "Albümler";
            this.albumler.Name = "albumler";
            this.albumler.ReadOnly = true;
            this.albumler.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // tur
            // 
            this.tur.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tur.HeaderText = "Tür";
            this.tur.Name = "tur";
            this.tur.ReadOnly = true;
            // 
            // sure
            // 
            this.sure.HeaderText = "🕒";
            this.sure.Name = "sure";
            this.sure.ReadOnly = true;
            // 
            // DeleteFromList
            // 
            this.DeleteFromList.AutoRoundedCorners = true;
            this.DeleteFromList.BorderRadius = 21;
            this.DeleteFromList.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.DeleteFromList.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.DeleteFromList.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DeleteFromList.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.DeleteFromList.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(222)))), ((int)(((byte)(177)))));
            this.DeleteFromList.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.DeleteFromList.ForeColor = System.Drawing.Color.White;
            this.DeleteFromList.Image = global::musilla.Properties.Resources.icons8_minus_50;
            this.DeleteFromList.ImageSize = new System.Drawing.Size(25, 25);
            this.DeleteFromList.Location = new System.Drawing.Point(12, 593);
            this.DeleteFromList.Name = "DeleteFromList";
            this.DeleteFromList.Size = new System.Drawing.Size(136, 45);
            this.DeleteFromList.TabIndex = 25;
            this.DeleteFromList.Text = "Listeden Çıkar";
            this.DeleteFromList.Click += new System.EventHandler(this.DeleteFromList_Click);
            // 
            // calmalistesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1085, 650);
            this.Controls.Add(this.DeleteFromList);
            this.Controls.Add(this.calmalistesiDGV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "calmalistesi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "calmalistesi";
            this.Load += new System.EventHandler(this.calmalistesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.calmalistesiDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.DataGridView calmalistesiDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn sarkiID;
        private System.Windows.Forms.DataGridViewTextBoxColumn baslik;
        private System.Windows.Forms.DataGridViewTextBoxColumn sanatcilar;
        private System.Windows.Forms.DataGridViewTextBoxColumn albumler;
        private System.Windows.Forms.DataGridViewTextBoxColumn tur;
        private System.Windows.Forms.DataGridViewTextBoxColumn sure;
        private Guna.UI2.WinForms.Guna2Button DeleteFromList;
    }
}
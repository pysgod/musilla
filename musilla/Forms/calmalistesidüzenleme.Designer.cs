namespace musilla
{
    partial class calmalistesidüzenleme
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
            this.cldcalmalistesiadi = new System.Windows.Forms.TextBox();
            this.cldcalmalistesiaciklamasi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.EditList = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // cldcalmalistesiadi
            // 
            this.cldcalmalistesiadi.Location = new System.Drawing.Point(138, 12);
            this.cldcalmalistesiadi.Name = "cldcalmalistesiadi";
            this.cldcalmalistesiadi.Size = new System.Drawing.Size(145, 20);
            this.cldcalmalistesiadi.TabIndex = 0;
            // 
            // cldcalmalistesiaciklamasi
            // 
            this.cldcalmalistesiaciklamasi.Location = new System.Drawing.Point(138, 38);
            this.cldcalmalistesiaciklamasi.Name = "cldcalmalistesiaciklamasi";
            this.cldcalmalistesiaciklamasi.Size = new System.Drawing.Size(145, 20);
            this.cldcalmalistesiaciklamasi.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Çalma Listesi Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Çalma Listesi Açıklaması:";
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
            this.EditList.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.EditList.ForeColor = System.Drawing.Color.White;
            this.EditList.Image = global::musilla.Properties.Resources.icons8_save_52;
            this.EditList.ImageSize = new System.Drawing.Size(25, 25);
            this.EditList.Location = new System.Drawing.Point(11, 64);
            this.EditList.Name = "EditList";
            this.EditList.Size = new System.Drawing.Size(276, 45);
            this.EditList.TabIndex = 15;
            this.EditList.Text = " Kaydet";
            this.EditList.Click += new System.EventHandler(this.EditList_Click);
            // 
            // calmalistesidüzenleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 115);
            this.Controls.Add(this.EditList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cldcalmalistesiaciklamasi);
            this.Controls.Add(this.cldcalmalistesiadi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "calmalistesidüzenleme";
            this.Text = "Çalma Listesi Düzenleme";
            this.Load += new System.EventHandler(this.calmalistesidüzenleme_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox cldcalmalistesiadi;
        public System.Windows.Forms.TextBox cldcalmalistesiaciklamasi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button EditList;
    }
}
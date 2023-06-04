namespace musilla
{
    partial class anasayfa
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.LibraryPageButton = new Guna.UI2.WinForms.Guna2Button();
            this.MainPageButton = new Guna.UI2.WinForms.Guna2Button();
            this.SettingsPageButton = new Guna.UI2.WinForms.Guna2Button();
            this.SearchPageButton = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.PagesPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.LibraryPageButton, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.MainPageButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.SettingsPageButton, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.SearchPageButton, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 146);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(188, 176);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // LibraryPageButton
            // 
            this.LibraryPageButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LibraryPageButton.AutoRoundedCorners = true;
            this.LibraryPageButton.BorderColor = System.Drawing.Color.White;
            this.LibraryPageButton.BorderRadius = 18;
            this.LibraryPageButton.BorderThickness = 2;
            this.LibraryPageButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.LibraryPageButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.LibraryPageButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.LibraryPageButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.LibraryPageButton.FillColor = System.Drawing.Color.Transparent;
            this.LibraryPageButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.LibraryPageButton.ForeColor = System.Drawing.Color.White;
            this.LibraryPageButton.Image = global::musilla.Properties.Resources.icons8_music_library_64;
            this.LibraryPageButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.LibraryPageButton.ImageSize = new System.Drawing.Size(30, 30);
            this.LibraryPageButton.Location = new System.Drawing.Point(3, 47);
            this.LibraryPageButton.Name = "LibraryPageButton";
            this.LibraryPageButton.Size = new System.Drawing.Size(182, 38);
            this.LibraryPageButton.TabIndex = 5;
            this.LibraryPageButton.Text = "Kitaplık";
            this.LibraryPageButton.Click += new System.EventHandler(this.LibraryPageButton_Click);
            // 
            // MainPageButton
            // 
            this.MainPageButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainPageButton.AutoRoundedCorners = true;
            this.MainPageButton.BorderColor = System.Drawing.Color.White;
            this.MainPageButton.BorderRadius = 18;
            this.MainPageButton.BorderThickness = 2;
            this.MainPageButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.MainPageButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.MainPageButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.MainPageButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.MainPageButton.FillColor = System.Drawing.Color.Transparent;
            this.MainPageButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.MainPageButton.ForeColor = System.Drawing.Color.White;
            this.MainPageButton.Image = global::musilla.Properties.Resources.icons8_home_52;
            this.MainPageButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.MainPageButton.ImageOffset = new System.Drawing.Point(5, 0);
            this.MainPageButton.ImageSize = new System.Drawing.Size(25, 25);
            this.MainPageButton.Location = new System.Drawing.Point(3, 3);
            this.MainPageButton.Name = "MainPageButton";
            this.MainPageButton.Size = new System.Drawing.Size(182, 38);
            this.MainPageButton.TabIndex = 0;
            this.MainPageButton.Text = "Ana Sayfa";
            this.MainPageButton.Click += new System.EventHandler(this.MainPageButton_Click);
            // 
            // SettingsPageButton
            // 
            this.SettingsPageButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SettingsPageButton.AutoRoundedCorners = true;
            this.SettingsPageButton.BorderColor = System.Drawing.Color.White;
            this.SettingsPageButton.BorderRadius = 18;
            this.SettingsPageButton.BorderThickness = 2;
            this.SettingsPageButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SettingsPageButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SettingsPageButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SettingsPageButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SettingsPageButton.FillColor = System.Drawing.Color.Transparent;
            this.SettingsPageButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.SettingsPageButton.ForeColor = System.Drawing.Color.White;
            this.SettingsPageButton.Image = global::musilla.Properties.Resources.icons8_settings_50;
            this.SettingsPageButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.SettingsPageButton.ImageOffset = new System.Drawing.Point(5, 0);
            this.SettingsPageButton.ImageSize = new System.Drawing.Size(25, 25);
            this.SettingsPageButton.Location = new System.Drawing.Point(3, 135);
            this.SettingsPageButton.Name = "SettingsPageButton";
            this.SettingsPageButton.Size = new System.Drawing.Size(182, 38);
            this.SettingsPageButton.TabIndex = 3;
            this.SettingsPageButton.Text = "Ayarlar";
            // 
            // SearchPageButton
            // 
            this.SearchPageButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchPageButton.AutoRoundedCorners = true;
            this.SearchPageButton.BorderColor = System.Drawing.Color.White;
            this.SearchPageButton.BorderRadius = 18;
            this.SearchPageButton.BorderThickness = 2;
            this.SearchPageButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SearchPageButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SearchPageButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SearchPageButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SearchPageButton.FillColor = System.Drawing.Color.Transparent;
            this.SearchPageButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.SearchPageButton.ForeColor = System.Drawing.Color.White;
            this.SearchPageButton.Image = global::musilla.Properties.Resources.icons8_search_52;
            this.SearchPageButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.SearchPageButton.ImageOffset = new System.Drawing.Point(5, 0);
            this.SearchPageButton.ImageSize = new System.Drawing.Size(25, 25);
            this.SearchPageButton.Location = new System.Drawing.Point(3, 91);
            this.SearchPageButton.Name = "SearchPageButton";
            this.SearchPageButton.Size = new System.Drawing.Size(182, 38);
            this.SearchPageButton.TabIndex = 2;
            this.SearchPageButton.Text = "Arama";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 37);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ana Sayfa";
            // 
            // PagesPanel
            // 
            this.PagesPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.PagesPanel.Location = new System.Drawing.Point(190, 0);
            this.PagesPanel.Name = "PagesPanel";
            this.PagesPanel.Size = new System.Drawing.Size(850, 650);
            this.PagesPanel.TabIndex = 8;
            // 
            // anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::musilla.Properties.Resources.beautiful_shapes_abstract_background_free_video;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1040, 650);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PagesPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "anasayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "anasayfa";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Guna.UI2.WinForms.Guna2Button MainPageButton;
        private Guna.UI2.WinForms.Guna2Button SearchPageButton;
        private Guna.UI2.WinForms.Guna2Button SettingsPageButton;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Panel PagesPanel;
        private Guna.UI2.WinForms.Guna2Button LibraryPageButton;
    }
}
namespace musilla
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.grsuyarilbl = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.RegisterLabel = new System.Windows.Forms.Label();
            this.PassShowHide = new Guna.UI2.WinForms.Guna2CheckBox();
            this.grspassbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.grsmailbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.LoginButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.AdminLogin = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.FormBorderStylePanel = new Guna.UI2.WinForms.Guna2Panel();
            this.CloseButton = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.FormBorderStylePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // grsuyarilbl
            // 
            this.grsuyarilbl.AutoSize = true;
            this.grsuyarilbl.ForeColor = System.Drawing.Color.Red;
            this.grsuyarilbl.Location = new System.Drawing.Point(40, 152);
            this.grsuyarilbl.Name = "grsuyarilbl";
            this.grsuyarilbl.Size = new System.Drawing.Size(0, 13);
            this.grsuyarilbl.TabIndex = 5;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guna2Panel1.BorderRadius = 30;
            this.guna2Panel1.Controls.Add(this.guna2PictureBox1);
            this.guna2Panel1.Controls.Add(this.RegisterLabel);
            this.guna2Panel1.Controls.Add(this.grsuyarilbl);
            this.guna2Panel1.Controls.Add(this.PassShowHide);
            this.guna2Panel1.Controls.Add(this.grspassbox);
            this.guna2Panel1.Controls.Add(this.grsmailbox);
            this.guna2Panel1.Controls.Add(this.LoginButton);
            this.guna2Panel1.FillColor = System.Drawing.Color.WhiteSmoke;
            this.guna2Panel1.Location = new System.Drawing.Point(102, 123);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(358, 432);
            this.guna2Panel1.TabIndex = 10;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::musilla.Properties.Resources._317699_P975AH_778;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(118, 17);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(123, 98);
            this.guna2PictureBox1.TabIndex = 10;
            this.guna2PictureBox1.TabStop = false;
            // 
            // RegisterLabel
            // 
            this.RegisterLabel.AutoSize = true;
            this.RegisterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.RegisterLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(222)))), ((int)(((byte)(177)))));
            this.RegisterLabel.Location = new System.Drawing.Point(152, 397);
            this.RegisterLabel.Name = "RegisterLabel";
            this.RegisterLabel.Size = new System.Drawing.Size(55, 16);
            this.RegisterLabel.TabIndex = 9;
            this.RegisterLabel.Text = "Kayıt Ol!";
            this.RegisterLabel.Click += new System.EventHandler(this.RegisterLabel_Click);
            // 
            // PassShowHide
            // 
            this.PassShowHide.AutoSize = true;
            this.PassShowHide.CheckedState.BorderColor = System.Drawing.Color.Transparent;
            this.PassShowHide.CheckedState.BorderRadius = 0;
            this.PassShowHide.CheckedState.BorderThickness = 0;
            this.PassShowHide.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(222)))), ((int)(((byte)(177)))));
            this.PassShowHide.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.PassShowHide.Location = new System.Drawing.Point(279, 281);
            this.PassShowHide.Name = "PassShowHide";
            this.PassShowHide.Size = new System.Drawing.Size(57, 17);
            this.PassShowHide.TabIndex = 8;
            this.PassShowHide.Text = "Göster";
            this.PassShowHide.UncheckedState.BorderColor = System.Drawing.Color.Transparent;
            this.PassShowHide.UncheckedState.BorderRadius = 0;
            this.PassShowHide.UncheckedState.BorderThickness = 0;
            this.PassShowHide.UncheckedState.FillColor = System.Drawing.Color.Silver;
            this.PassShowHide.CheckedChanged += new System.EventHandler(this.PassShowHide_CheckedChanged);
            // 
            // grspassbox
            // 
            this.grspassbox.AutoRoundedCorners = true;
            this.grspassbox.BackColor = System.Drawing.Color.Transparent;
            this.grspassbox.BorderColor = System.Drawing.Color.Transparent;
            this.grspassbox.BorderRadius = 20;
            this.grspassbox.BorderThickness = 0;
            this.grspassbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.grspassbox.DefaultText = "";
            this.grspassbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.grspassbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.grspassbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.grspassbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.grspassbox.FillColor = System.Drawing.Color.SkyBlue;
            this.grspassbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.grspassbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.grspassbox.ForeColor = System.Drawing.Color.White;
            this.grspassbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.grspassbox.IconLeft = global::musilla.Properties.Resources.icons8_secure_100;
            this.grspassbox.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.grspassbox.IconLeftSize = new System.Drawing.Size(30, 30);
            this.grspassbox.Location = new System.Drawing.Point(22, 232);
            this.grspassbox.Name = "grspassbox";
            this.grspassbox.PasswordChar = '•';
            this.grspassbox.PlaceholderForeColor = System.Drawing.Color.Transparent;
            this.grspassbox.PlaceholderText = "";
            this.grspassbox.SelectedText = "";
            this.grspassbox.Size = new System.Drawing.Size(314, 43);
            this.grspassbox.TabIndex = 7;
            // 
            // grsmailbox
            // 
            this.grsmailbox.AutoRoundedCorners = true;
            this.grsmailbox.BackColor = System.Drawing.Color.Transparent;
            this.grsmailbox.BorderColor = System.Drawing.Color.Transparent;
            this.grsmailbox.BorderRadius = 20;
            this.grsmailbox.BorderThickness = 0;
            this.grsmailbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.grsmailbox.DefaultText = "";
            this.grsmailbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.grsmailbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.grsmailbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.grsmailbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.grsmailbox.FillColor = System.Drawing.Color.SkyBlue;
            this.grsmailbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.grsmailbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.grsmailbox.ForeColor = System.Drawing.Color.White;
            this.grsmailbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.grsmailbox.IconLeft = global::musilla.Properties.Resources.icons8_mail_501;
            this.grsmailbox.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.grsmailbox.IconLeftSize = new System.Drawing.Size(30, 30);
            this.grsmailbox.Location = new System.Drawing.Point(22, 172);
            this.grsmailbox.Name = "grsmailbox";
            this.grsmailbox.PasswordChar = '\0';
            this.grsmailbox.PlaceholderForeColor = System.Drawing.Color.Transparent;
            this.grsmailbox.PlaceholderText = "";
            this.grsmailbox.SelectedText = "";
            this.grsmailbox.Size = new System.Drawing.Size(314, 43);
            this.grsmailbox.TabIndex = 6;
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.Transparent;
            this.LoginButton.BorderRadius = 15;
            this.LoginButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.LoginButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.LoginButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.LoginButton.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.LoginButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.LoginButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(222)))), ((int)(((byte)(177)))));
            this.LoginButton.FillColor2 = System.Drawing.Color.SkyBlue;
            this.LoginButton.FocusedColor = System.Drawing.Color.Transparent;
            this.LoginButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LoginButton.ForeColor = System.Drawing.Color.White;
            this.LoginButton.Location = new System.Drawing.Point(65, 339);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(229, 45);
            this.LoginButton.TabIndex = 5;
            this.LoginButton.Text = "Giriş";
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // AdminLogin
            // 
            this.AdminLogin.BackColor = System.Drawing.Color.Transparent;
            this.AdminLogin.BackgroundImage = global::musilla.Properties.Resources.icons8_admin_50;
            this.AdminLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.AdminLogin.BorderColor = System.Drawing.Color.White;
            this.AdminLogin.BorderRadius = 15;
            this.AdminLogin.BorderThickness = 2;
            this.AdminLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AdminLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AdminLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AdminLogin.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AdminLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AdminLogin.FillColor = System.Drawing.Color.Transparent;
            this.AdminLogin.FillColor2 = System.Drawing.Color.Transparent;
            this.AdminLogin.FocusedColor = System.Drawing.Color.Transparent;
            this.AdminLogin.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.AdminLogin.ForeColor = System.Drawing.Color.White;
            this.AdminLogin.Location = new System.Drawing.Point(12, 606);
            this.AdminLogin.Name = "AdminLogin";
            this.AdminLogin.Size = new System.Drawing.Size(63, 60);
            this.AdminLogin.TabIndex = 11;
            this.AdminLogin.Click += new System.EventHandler(this.AdminLogin_Click);
            // 
            // guna2GradientButton1
            // 
            this.guna2GradientButton1.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientButton1.BackgroundImage = global::musilla.Properties.Resources.icons8_sound_50;
            this.guna2GradientButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.guna2GradientButton1.BorderColor = System.Drawing.Color.White;
            this.guna2GradientButton1.BorderRadius = 15;
            this.guna2GradientButton1.BorderThickness = 2;
            this.guna2GradientButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton1.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButton1.FillColor = System.Drawing.Color.Transparent;
            this.guna2GradientButton1.FillColor2 = System.Drawing.Color.Transparent;
            this.guna2GradientButton1.FocusedColor = System.Drawing.Color.Transparent;
            this.guna2GradientButton1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.guna2GradientButton1.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton1.Location = new System.Drawing.Point(79, 606);
            this.guna2GradientButton1.Name = "guna2GradientButton1";
            this.guna2GradientButton1.Size = new System.Drawing.Size(63, 60);
            this.guna2GradientButton1.TabIndex = 12;
            // 
            // FormBorderStylePanel
            // 
            this.FormBorderStylePanel.BackColor = System.Drawing.Color.Transparent;
            this.FormBorderStylePanel.Controls.Add(this.CloseButton);
            this.FormBorderStylePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.FormBorderStylePanel.Location = new System.Drawing.Point(0, 0);
            this.FormBorderStylePanel.Name = "FormBorderStylePanel";
            this.FormBorderStylePanel.Size = new System.Drawing.Size(562, 30);
            this.FormBorderStylePanel.TabIndex = 13;
            this.FormBorderStylePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.FormBorderStylePanel_Paint);
            this.FormBorderStylePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormBorderStylePanel_MouseMove);
            // 
            // CloseButton
            // 
            this.CloseButton.BackgroundImage = global::musilla.Properties.Resources.icons8_cancel_50;
            this.CloseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CloseButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.CloseButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.CloseButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.CloseButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.CloseButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.CloseButton.FillColor = System.Drawing.Color.Transparent;
            this.CloseButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CloseButton.ForeColor = System.Drawing.Color.White;
            this.CloseButton.Location = new System.Drawing.Point(523, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(39, 30);
            this.CloseButton.TabIndex = 1;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::musilla.Properties.Resources.beautiful_shapes_abstract_background_free_video;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(562, 678);
            this.Controls.Add(this.FormBorderStylePanel);
            this.Controls.Add(this.guna2GradientButton1);
            this.Controls.Add(this.AdminLogin);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.FormBorderStylePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label grsuyarilbl;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label RegisterLabel;
        private Guna.UI2.WinForms.Guna2CheckBox PassShowHide;
        public Guna.UI2.WinForms.Guna2TextBox grspassbox;
        public Guna.UI2.WinForms.Guna2TextBox grsmailbox;
        private Guna.UI2.WinForms.Guna2GradientButton LoginButton;
        private Guna.UI2.WinForms.Guna2GradientButton AdminLogin;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton1;
        private Guna.UI2.WinForms.Guna2Panel FormBorderStylePanel;
        private Guna.UI2.WinForms.Guna2Button CloseButton;
    }
}


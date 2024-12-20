namespace Git_Helper
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.exit = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.username = new Guna.UI2.WinForms.Guna2TextBox();
            this.password = new Guna.UI2.WinForms.Guna2TextBox();
            this.loginButton = new Guna.UI2.WinForms.Guna2Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.discord = new Guna.UI2.WinForms.Guna2Button();
            this.whatsapp = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // exit
            // 
            this.exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exit.Animated = true;
            this.exit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.exit.FillColor = System.Drawing.Color.Black;
            this.exit.HoverState.FillColor = System.Drawing.Color.Black;
            this.exit.IconColor = System.Drawing.Color.White;
            this.exit.Location = new System.Drawing.Point(267, 0);
            this.exit.Name = "exit";
            this.exit.PressedColor = System.Drawing.Color.Red;
            this.exit.PressedDepth = 60;
            this.exit.Size = new System.Drawing.Size(45, 29);
            this.exit.TabIndex = 0;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.DragStartTransparencyValue = 1D;
            this.guna2DragControl1.TargetControl = this;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(0, 0);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(86, 15);
            this.guna2HtmlLabel1.TabIndex = 1;
            this.guna2HtmlLabel1.Text = "guna2HtmlLabel1";
            // 
            // username
            // 
            this.username.Animated = true;
            this.username.BorderColor = System.Drawing.Color.White;
            this.username.BorderRadius = 10;
            this.username.BorderThickness = 2;
            this.username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.username.DefaultText = "";
            this.username.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.username.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.username.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.username.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.username.FillColor = System.Drawing.Color.Transparent;
            this.username.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.username.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.ForeColor = System.Drawing.Color.White;
            this.username.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.username.Location = new System.Drawing.Point(41, 260);
            this.username.MaxLength = 10;
            this.username.Name = "username";
            this.username.PasswordChar = '\0';
            this.username.PlaceholderText = "Enter Username";
            this.username.SelectedText = "";
            this.username.Size = new System.Drawing.Size(229, 38);
            this.username.TabIndex = 3;
            // 
            // password
            // 
            this.password.Animated = true;
            this.password.BorderColor = System.Drawing.Color.White;
            this.password.BorderRadius = 10;
            this.password.BorderThickness = 2;
            this.password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.password.DefaultText = "";
            this.password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.password.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.password.FillColor = System.Drawing.Color.Transparent;
            this.password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.password.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.password.ForeColor = System.Drawing.Color.White;
            this.password.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.password.Location = new System.Drawing.Point(41, 317);
            this.password.MaxLength = 10;
            this.password.Name = "password";
            this.password.PasswordChar = '\0';
            this.password.PlaceholderText = "Enter Key";
            this.password.SelectedText = "";
            this.password.Size = new System.Drawing.Size(229, 38);
            this.password.TabIndex = 4;
            this.password.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            // 
            // loginButton
            // 
            this.loginButton.Animated = true;
            this.loginButton.BackColor = System.Drawing.Color.Transparent;
            this.loginButton.BorderThickness = 2;
            this.loginButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.loginButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.loginButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.loginButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.loginButton.FillColor = System.Drawing.Color.Black;
            this.loginButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.loginButton.ForeColor = System.Drawing.Color.White;
            this.loginButton.Location = new System.Drawing.Point(89, 378);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(133, 37);
            this.loginButton.TabIndex = 5;
            this.loginButton.Text = "Enter";
            this.loginButton.UseTransparentBackground = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // discord
            // 
            this.discord.Animated = true;
            this.discord.BackColor = System.Drawing.Color.Transparent;
            this.discord.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("discord.BackgroundImage")));
            this.discord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.discord.BorderRadius = 25;
            this.discord.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.discord.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.discord.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.discord.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.discord.FillColor = System.Drawing.Color.Transparent;
            this.discord.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.discord.ForeColor = System.Drawing.Color.Transparent;
            this.discord.Location = new System.Drawing.Point(156, 469);
            this.discord.Name = "discord";
            this.discord.Size = new System.Drawing.Size(29, 29);
            this.discord.TabIndex = 6;
            this.discord.UseTransparentBackground = true;
            this.discord.Click += new System.EventHandler(this.discord_Click);
            // 
            // whatsapp
            // 
            this.whatsapp.Animated = true;
            this.whatsapp.BackColor = System.Drawing.Color.Transparent;
            this.whatsapp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("whatsapp.BackgroundImage")));
            this.whatsapp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.whatsapp.BorderRadius = 25;
            this.whatsapp.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.whatsapp.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.whatsapp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.whatsapp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.whatsapp.FillColor = System.Drawing.Color.Transparent;
            this.whatsapp.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.whatsapp.ForeColor = System.Drawing.Color.Transparent;
            this.whatsapp.Location = new System.Drawing.Point(121, 469);
            this.whatsapp.Name = "whatsapp";
            this.whatsapp.Size = new System.Drawing.Size(29, 29);
            this.whatsapp.TabIndex = 7;
            this.whatsapp.UseTransparentBackground = true;
            this.whatsapp.Click += new System.EventHandler(this.whatsapp_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(311, 510);
            this.Controls.Add(this.whatsapp);
            this.Controls.Add(this.discord);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.exit);
            this.Cursor = System.Windows.Forms.Cursors.PanNorth;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LogIn";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ControlBox exit;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2TextBox username;
        private Guna.UI2.WinForms.Guna2TextBox password;
        private Guna.UI2.WinForms.Guna2Button loginButton;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2Button whatsapp;
        private Guna.UI2.WinForms.Guna2Button discord;
    }
}


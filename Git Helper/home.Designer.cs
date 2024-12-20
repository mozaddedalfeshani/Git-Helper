namespace Git_Helper
{
    partial class home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(home));
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.desktopUserName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.ramInfo = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.refresh = new Guna.UI2.WinForms.Guna2Button();
            this.optimized = new Guna.UI2.WinForms.Guna2Button();
            this.DeepClean = new Guna.UI2.WinForms.Guna2Button();
            this.scanClean = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.discord = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // guna2AnimateWindow1
            // 
            this.guna2AnimateWindow1.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_ACTIVATE;
            this.guna2AnimateWindow1.Interval = 1000;
            this.guna2AnimateWindow1.TargetForm = this;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.Animated = true;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(516, -1);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 0;
            this.guna2ControlBox1.Click += new System.EventHandler(this.guna2ControlBox1_Click);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // desktopUserName
            // 
            this.desktopUserName.BackColor = System.Drawing.Color.Transparent;
            this.desktopUserName.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desktopUserName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.desktopUserName.Location = new System.Drawing.Point(250, 145);
            this.desktopUserName.Name = "desktopUserName";
            this.desktopUserName.Size = new System.Drawing.Size(52, 20);
            this.desktopUserName.TabIndex = 1;
            this.desktopUserName.Text = "Murad";
            this.desktopUserName.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.desktopUserName.Click += new System.EventHandler(this.guna2HtmlLabel1_Click_1);
            // 
            // ramInfo
            // 
            this.ramInfo.BackColor = System.Drawing.Color.Transparent;
            this.ramInfo.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ramInfo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ramInfo.Location = new System.Drawing.Point(224, 171);
            this.ramInfo.Name = "ramInfo";
            this.ramInfo.Size = new System.Drawing.Size(97, 16);
            this.ramInfo.TabIndex = 2;
            this.ramInfo.Text = "Ram : 12/64GB";
            this.ramInfo.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.ramInfo.Click += new System.EventHandler(this.ramInfo_Click);
            // 
            // refresh
            // 
            this.refresh.Animated = true;
            this.refresh.BackColor = System.Drawing.Color.Transparent;
            this.refresh.BorderColor = System.Drawing.Color.White;
            this.refresh.BorderRadius = 12;
            this.refresh.BorderThickness = 1;
            this.refresh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.refresh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.refresh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.refresh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.refresh.FillColor = System.Drawing.Color.Empty;
            this.refresh.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.refresh.ForeColor = System.Drawing.Color.White;
            this.refresh.HoverState.BorderColor = System.Drawing.Color.Red;
            this.refresh.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.refresh.HoverState.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refresh.HoverState.ForeColor = System.Drawing.Color.Black;
            this.refresh.Location = new System.Drawing.Point(91, 234);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(155, 45);
            this.refresh.TabIndex = 3;
            this.refresh.Text = "Refresh";
            this.refresh.UseTransparentBackground = true;
            this.refresh.Click += new System.EventHandler(this.scanClean_Click);
            // 
            // optimized
            // 
            this.optimized.Animated = true;
            this.optimized.BackColor = System.Drawing.Color.Transparent;
            this.optimized.BorderColor = System.Drawing.Color.White;
            this.optimized.BorderRadius = 12;
            this.optimized.BorderThickness = 1;
            this.optimized.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.optimized.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.optimized.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.optimized.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.optimized.FillColor = System.Drawing.Color.Empty;
            this.optimized.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.optimized.ForeColor = System.Drawing.Color.White;
            this.optimized.HoverState.BorderColor = System.Drawing.Color.Red;
            this.optimized.HoverState.FillColor = System.Drawing.Color.Blue;
            this.optimized.HoverState.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optimized.HoverState.ForeColor = System.Drawing.Color.White;
            this.optimized.Location = new System.Drawing.Point(91, 324);
            this.optimized.Name = "optimized";
            this.optimized.Size = new System.Drawing.Size(155, 45);
            this.optimized.TabIndex = 4;
            this.optimized.Text = "Optimized";
            this.optimized.UseTransparentBackground = true;
            // 
            // DeepClean
            // 
            this.DeepClean.Animated = true;
            this.DeepClean.BackColor = System.Drawing.Color.Transparent;
            this.DeepClean.BorderColor = System.Drawing.Color.White;
            this.DeepClean.BorderRadius = 12;
            this.DeepClean.BorderThickness = 1;
            this.DeepClean.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.DeepClean.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.DeepClean.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DeepClean.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.DeepClean.FillColor = System.Drawing.Color.Empty;
            this.DeepClean.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.DeepClean.ForeColor = System.Drawing.Color.White;
            this.DeepClean.HoverState.BorderColor = System.Drawing.Color.Red;
            this.DeepClean.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.DeepClean.HoverState.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeepClean.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.DeepClean.Location = new System.Drawing.Point(296, 324);
            this.DeepClean.Name = "DeepClean";
            this.DeepClean.Size = new System.Drawing.Size(155, 45);
            this.DeepClean.TabIndex = 5;
            this.DeepClean.Text = "Deep Clean";
            this.DeepClean.UseTransparentBackground = true;
            this.DeepClean.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // scanClean
            // 
            this.scanClean.Animated = true;
            this.scanClean.BackColor = System.Drawing.Color.Transparent;
            this.scanClean.BorderColor = System.Drawing.Color.White;
            this.scanClean.BorderRadius = 12;
            this.scanClean.BorderThickness = 1;
            this.scanClean.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.scanClean.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.scanClean.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.scanClean.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.scanClean.FillColor = System.Drawing.Color.Empty;
            this.scanClean.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.scanClean.ForeColor = System.Drawing.Color.White;
            this.scanClean.HoverState.BorderColor = System.Drawing.Color.Red;
            this.scanClean.HoverState.FillColor = System.Drawing.Color.Lime;
            this.scanClean.HoverState.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scanClean.HoverState.ForeColor = System.Drawing.Color.Black;
            this.scanClean.Location = new System.Drawing.Point(296, 234);
            this.scanClean.Name = "scanClean";
            this.scanClean.Size = new System.Drawing.Size(155, 45);
            this.scanClean.TabIndex = 6;
            this.scanClean.Text = "Scan and Clean";
            this.scanClean.UseTransparentBackground = true;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(218, 471);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(103, 15);
            this.guna2HtmlLabel1.TabIndex = 7;
            this.guna2HtmlLabel1.Text = "Developed By Murad";
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
            this.discord.Location = new System.Drawing.Point(516, 457);
            this.discord.Name = "discord";
            this.discord.Size = new System.Drawing.Size(29, 29);
            this.discord.TabIndex = 8;
            this.discord.UseTransparentBackground = true;
            this.discord.Click += new System.EventHandler(this.discord_Click);
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(560, 498);
            this.Controls.Add(this.discord);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.scanClean);
            this.Controls.Add(this.DeepClean);
            this.Controls.Add(this.optimized);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.ramInfo);
            this.Controls.Add(this.desktopUserName);
            this.Controls.Add(this.guna2ControlBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "home";
            this.Text = "home";
            this.Load += new System.EventHandler(this.home_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2HtmlLabel desktopUserName;
        private Guna.UI2.WinForms.Guna2HtmlLabel ramInfo;
        private Guna.UI2.WinForms.Guna2Button scanClean;
        private Guna.UI2.WinForms.Guna2Button DeepClean;
        private Guna.UI2.WinForms.Guna2Button optimized;
        private Guna.UI2.WinForms.Guna2Button refresh;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Button discord;
    }
}
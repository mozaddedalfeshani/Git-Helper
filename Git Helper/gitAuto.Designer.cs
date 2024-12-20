namespace Git_Helper
{
    partial class gitAuto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gitAuto));
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.selectFolder = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pathValue = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.commitInput = new Guna.UI2.WinForms.Guna2TextBox();
            this.gitUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.branchName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pushtogit = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // guna2AnimateWindow1
            // 
            this.guna2AnimateWindow1.Interval = 700;
            this.guna2AnimateWindow1.TargetForm = this;
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // selectFolder
            // 
            this.selectFolder.BackColor = System.Drawing.Color.Transparent;
            this.selectFolder.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectFolder.ForeColor = System.Drawing.Color.White;
            this.selectFolder.Location = new System.Drawing.Point(58, 80);
            this.selectFolder.Name = "selectFolder";
            this.selectFolder.Size = new System.Drawing.Size(122, 20);
            this.selectFolder.TabIndex = 0;
            this.selectFolder.Text = "Select Folder :  ";
            this.selectFolder.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.selectFolder.Click += new System.EventHandler(this.guna2HtmlLabel1_Click);
            // 
            // pathValue
            // 
            this.pathValue.Animated = true;
            this.pathValue.AutoRoundedCorners = true;
            this.pathValue.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pathValue.BorderRadius = 11;
            this.pathValue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pathValue.DefaultText = "";
            this.pathValue.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.pathValue.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.pathValue.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.pathValue.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.pathValue.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.pathValue.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.pathValue.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.pathValue.Location = new System.Drawing.Point(185, 80);
            this.pathValue.Name = "pathValue";
            this.pathValue.PasswordChar = '\0';
            this.pathValue.PlaceholderText = "";
            this.pathValue.SelectedText = "";
            this.pathValue.Size = new System.Drawing.Size(540, 25);
            this.pathValue.TabIndex = 1;
            // 
            // guna2Button1
            // 
            this.guna2Button1.Animated = true;
            this.guna2Button1.BorderColor = System.Drawing.Color.White;
            this.guna2Button1.BorderRadius = 10;
            this.guna2Button1.BorderThickness = 1;
            this.guna2Button1.DefaultAutoSize = true;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.Empty;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.IndicateFocus = true;
            this.guna2Button1.Location = new System.Drawing.Point(731, 80);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(38, 27);
            this.guna2Button1.TabIndex = 2;
            this.guna2Button1.Text = "...";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // commitInput
            // 
            this.commitInput.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.commitInput.BorderRadius = 10;
            this.commitInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.commitInput.DefaultText = "";
            this.commitInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.commitInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.commitInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.commitInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.commitInput.FillColor = System.Drawing.Color.Transparent;
            this.commitInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.commitInput.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.commitInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.commitInput.Location = new System.Drawing.Point(58, 134);
            this.commitInput.Name = "commitInput";
            this.commitInput.PasswordChar = '\0';
            this.commitInput.PlaceholderText = "Enter Your Commit";
            this.commitInput.SelectedText = "";
            this.commitInput.Size = new System.Drawing.Size(711, 222);
            this.commitInput.TabIndex = 3;
            this.commitInput.TextChanged += new System.EventHandler(this.guna2TextBox2_TextChanged);
            // 
            // gitUpdate
            // 
            this.gitUpdate.Animated = true;
            this.gitUpdate.AutoRoundedCorners = true;
            this.gitUpdate.BackColor = System.Drawing.Color.Transparent;
            this.gitUpdate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gitUpdate.BorderRadius = 23;
            this.gitUpdate.BorderThickness = 1;
            this.gitUpdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.gitUpdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gitUpdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gitUpdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.gitUpdate.FillColor = System.Drawing.Color.Empty;
            this.gitUpdate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gitUpdate.ForeColor = System.Drawing.Color.White;
            this.gitUpdate.Location = new System.Drawing.Point(185, 387);
            this.gitUpdate.Name = "gitUpdate";
            this.gitUpdate.Size = new System.Drawing.Size(185, 49);
            this.gitUpdate.TabIndex = 4;
            this.gitUpdate.Text = "Add Commit";
            this.gitUpdate.UseTransparentBackground = true;
            this.gitUpdate.Click += new System.EventHandler(this.gitUpdate_Click);
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(752, 2);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 5;
            this.guna2ControlBox1.Click += new System.EventHandler(this.guna2ControlBox1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(0, 0);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(86, 15);
            this.guna2HtmlLabel1.TabIndex = 6;
            this.guna2HtmlLabel1.Text = "guna2HtmlLabel1";
            // 
            // branchName
            // 
            this.branchName.BackColor = System.Drawing.Color.Transparent;
            this.branchName.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.branchName.ForeColor = System.Drawing.Color.White;
            this.branchName.Location = new System.Drawing.Point(12, 482);
            this.branchName.Name = "branchName";
            this.branchName.Size = new System.Drawing.Size(103, 20);
            this.branchName.TabIndex = 7;
            this.branchName.Text = "Branch Name";
            this.branchName.Click += new System.EventHandler(this.guna2HtmlLabel2_Click);
            // 
            // pushtogit
            // 
            this.pushtogit.Animated = true;
            this.pushtogit.AutoRoundedCorners = true;
            this.pushtogit.BackColor = System.Drawing.Color.Transparent;
            this.pushtogit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pushtogit.BorderRadius = 23;
            this.pushtogit.BorderThickness = 1;
            this.pushtogit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.pushtogit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.pushtogit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.pushtogit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.pushtogit.FillColor = System.Drawing.Color.Empty;
            this.pushtogit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.pushtogit.ForeColor = System.Drawing.Color.White;
            this.pushtogit.Location = new System.Drawing.Point(438, 387);
            this.pushtogit.Name = "pushtogit";
            this.pushtogit.PressedColor = System.Drawing.Color.IndianRed;
            this.pushtogit.Size = new System.Drawing.Size(185, 49);
            this.pushtogit.TabIndex = 8;
            this.pushtogit.Text = "Push";
            this.pushtogit.UseTransparentBackground = true;
            this.pushtogit.Click += new System.EventHandler(this.pushtogit_Click);
            // 
            // gitAuto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 514);
            this.Controls.Add(this.pushtogit);
            this.Controls.Add(this.branchName);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.gitUpdate);
            this.Controls.Add(this.commitInput);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.pathValue);
            this.Controls.Add(this.selectFolder);
            this.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "gitAuto";
            this.Opacity = 0.8D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "gitAuto";
            this.Load += new System.EventHandler(this.gitAuto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2TextBox pathValue;
        private Guna.UI2.WinForms.Guna2HtmlLabel selectFolder;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2Button gitUpdate;
        private Guna.UI2.WinForms.Guna2TextBox commitInput;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private Guna.UI2.WinForms.Guna2HtmlLabel branchName;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Button pushtogit;
    }
}
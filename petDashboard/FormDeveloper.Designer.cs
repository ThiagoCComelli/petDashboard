namespace petDashboard
{
    partial class FormDeveloper
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.permissaoLabel = new System.Windows.Forms.Label();
            this.whatsIcon = new FontAwesome.Sharp.IconButton();
            this.githubIcon = new FontAwesome.Sharp.IconButton();
            this.linkedinIcon = new FontAwesome.Sharp.IconButton();
            this.logoutIcon = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(12, 114);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(776, 59);
            this.label1.TabIndex = 0;
            this.label1.Text = "Programa desenvolvido por: Thiago Comelli";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.logoutIcon);
            this.panel1.Controls.Add(this.permissaoLabel);
            this.panel1.Controls.Add(this.whatsIcon);
            this.panel1.Controls.Add(this.githubIcon);
            this.panel1.Controls.Add(this.linkedinIcon);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 1;
            // 
            // permissaoLabel
            // 
            this.permissaoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.permissaoLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.permissaoLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.permissaoLabel.Location = new System.Drawing.Point(12, 55);
            this.permissaoLabel.Name = "permissaoLabel";
            this.permissaoLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.permissaoLabel.Size = new System.Drawing.Size(776, 59);
            this.permissaoLabel.TabIndex = 4;
            this.permissaoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // whatsIcon
            // 
            this.whatsIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.whatsIcon.FlatAppearance.BorderSize = 0;
            this.whatsIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.whatsIcon.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.whatsIcon.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.whatsIcon.ForeColor = System.Drawing.Color.Gainsboro;
            this.whatsIcon.IconChar = FontAwesome.Sharp.IconChar.Whatsapp;
            this.whatsIcon.IconColor = System.Drawing.Color.Gainsboro;
            this.whatsIcon.IconSize = 24;
            this.whatsIcon.Location = new System.Drawing.Point(0, 254);
            this.whatsIcon.Name = "whatsIcon";
            this.whatsIcon.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.whatsIcon.Rotation = 0D;
            this.whatsIcon.Size = new System.Drawing.Size(800, 33);
            this.whatsIcon.TabIndex = 3;
            this.whatsIcon.Text = " 9603-0226 9 (048) 55+";
            this.whatsIcon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.whatsIcon.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.whatsIcon.UseVisualStyleBackColor = true;
            this.whatsIcon.Click += new System.EventHandler(this.whatsIcon_Click);
            // 
            // githubIcon
            // 
            this.githubIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.githubIcon.FlatAppearance.BorderSize = 0;
            this.githubIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.githubIcon.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.githubIcon.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.githubIcon.ForeColor = System.Drawing.Color.Gainsboro;
            this.githubIcon.IconChar = FontAwesome.Sharp.IconChar.Github;
            this.githubIcon.IconColor = System.Drawing.Color.Gainsboro;
            this.githubIcon.IconSize = 24;
            this.githubIcon.Location = new System.Drawing.Point(0, 215);
            this.githubIcon.Name = "githubIcon";
            this.githubIcon.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.githubIcon.Rotation = 0D;
            this.githubIcon.Size = new System.Drawing.Size(800, 33);
            this.githubIcon.TabIndex = 2;
            this.githubIcon.Text = "ThiagoCComelli/";
            this.githubIcon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.githubIcon.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.githubIcon.UseVisualStyleBackColor = true;
            this.githubIcon.Click += new System.EventHandler(this.githubIcon_Click);
            // 
            // linkedinIcon
            // 
            this.linkedinIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.linkedinIcon.FlatAppearance.BorderSize = 0;
            this.linkedinIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.linkedinIcon.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.linkedinIcon.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkedinIcon.ForeColor = System.Drawing.Color.Gainsboro;
            this.linkedinIcon.IconChar = FontAwesome.Sharp.IconChar.Linkedin;
            this.linkedinIcon.IconColor = System.Drawing.Color.Gainsboro;
            this.linkedinIcon.IconSize = 24;
            this.linkedinIcon.Location = new System.Drawing.Point(0, 176);
            this.linkedinIcon.Name = "linkedinIcon";
            this.linkedinIcon.Rotation = 0D;
            this.linkedinIcon.Size = new System.Drawing.Size(800, 33);
            this.linkedinIcon.TabIndex = 1;
            this.linkedinIcon.Text = "thiagocomelli@";
            this.linkedinIcon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkedinIcon.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.linkedinIcon.UseVisualStyleBackColor = true;
            this.linkedinIcon.Click += new System.EventHandler(this.linkedinIcon_Click);
            // 
            // logoutIcon
            // 
            this.logoutIcon.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.logoutIcon.FlatAppearance.BorderSize = 0;
            this.logoutIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutIcon.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.logoutIcon.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutIcon.ForeColor = System.Drawing.Color.Gainsboro;
            this.logoutIcon.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.logoutIcon.IconColor = System.Drawing.Color.Gainsboro;
            this.logoutIcon.IconSize = 24;
            this.logoutIcon.Location = new System.Drawing.Point(0, 417);
            this.logoutIcon.Name = "logoutIcon";
            this.logoutIcon.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.logoutIcon.Rotation = 0D;
            this.logoutIcon.Size = new System.Drawing.Size(800, 33);
            this.logoutIcon.TabIndex = 5;
            this.logoutIcon.Text = "Logout";
            this.logoutIcon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.logoutIcon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.logoutIcon.UseVisualStyleBackColor = true;
            this.logoutIcon.Click += new System.EventHandler(this.logoutIcon_Click);
            // 
            // FormDeveloper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "FormDeveloper";
            this.Text = "FormDeveloper";
            this.Load += new System.EventHandler(this.FormDeveloper_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton linkedinIcon;
        private FontAwesome.Sharp.IconButton githubIcon;
        private FontAwesome.Sharp.IconButton whatsIcon;
        private System.Windows.Forms.Label permissaoLabel;
        private FontAwesome.Sharp.IconButton logoutIcon;
    }
}
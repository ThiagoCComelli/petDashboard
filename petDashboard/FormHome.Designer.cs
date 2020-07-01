namespace petDashboard
{
    partial class FormHome
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.petIcon = new FontAwesome.Sharp.IconButton();
            this.logoutIcon = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::petDashboard.Properties.Resources.logo_petcomp_1_;
            this.pictureBox1.Location = new System.Drawing.Point(103, 79);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(556, 132);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // petIcon
            // 
            this.petIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.petIcon.FlatAppearance.BorderSize = 0;
            this.petIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.petIcon.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.petIcon.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.petIcon.ForeColor = System.Drawing.Color.Gainsboro;
            this.petIcon.IconChar = FontAwesome.Sharp.IconChar.LaptopCode;
            this.petIcon.IconColor = System.Drawing.Color.Gainsboro;
            this.petIcon.IconSize = 24;
            this.petIcon.Location = new System.Drawing.Point(-6, 234);
            this.petIcon.Name = "petIcon";
            this.petIcon.Rotation = 0D;
            this.petIcon.Size = new System.Drawing.Size(754, 33);
            this.petIcon.TabIndex = 2;
            this.petIcon.Text = "Pet Computação - UFSC";
            this.petIcon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.petIcon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.petIcon.UseVisualStyleBackColor = true;
            this.petIcon.Click += new System.EventHandler(this.petIcon_Click);
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
            this.logoutIcon.Location = new System.Drawing.Point(0, 405);
            this.logoutIcon.Name = "logoutIcon";
            this.logoutIcon.Rotation = 0D;
            this.logoutIcon.Size = new System.Drawing.Size(742, 33);
            this.logoutIcon.TabIndex = 3;
            this.logoutIcon.Text = "Logout";
            this.logoutIcon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.logoutIcon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.logoutIcon.UseVisualStyleBackColor = true;
            this.logoutIcon.Click += new System.EventHandler(this.logoutIcon_Click);
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(742, 438);
            this.Controls.Add(this.logoutIcon);
            this.Controls.Add(this.petIcon);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormHome";
            this.Text = "FormHome";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton petIcon;
        private FontAwesome.Sharp.IconButton logoutIcon;
    }
}
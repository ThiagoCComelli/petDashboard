namespace petDashboard
{
    partial class FormLogin
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.closeIcon = new FontAwesome.Sharp.IconPictureBox();
            this.minimizeIcon = new FontAwesome.Sharp.IconPictureBox();
            this.centralPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(354, 36);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseDown);
            // 
            // closeIcon
            // 
            this.closeIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.closeIcon.ForeColor = System.Drawing.Color.Gainsboro;
            this.closeIcon.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.closeIcon.IconColor = System.Drawing.Color.Gainsboro;
            this.closeIcon.IconSize = 18;
            this.closeIcon.Location = new System.Drawing.Point(333, 5);
            this.closeIcon.Name = "closeIcon";
            this.closeIcon.Size = new System.Drawing.Size(18, 18);
            this.closeIcon.TabIndex = 5;
            this.closeIcon.TabStop = false;
            this.closeIcon.Click += new System.EventHandler(this.closeIcon_Click);
            // 
            // minimizeIcon
            // 
            this.minimizeIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizeIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.minimizeIcon.ForeColor = System.Drawing.Color.Gainsboro;
            this.minimizeIcon.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.minimizeIcon.IconColor = System.Drawing.Color.Gainsboro;
            this.minimizeIcon.IconSize = 18;
            this.minimizeIcon.Location = new System.Drawing.Point(309, 5);
            this.minimizeIcon.Name = "minimizeIcon";
            this.minimizeIcon.Size = new System.Drawing.Size(18, 18);
            this.minimizeIcon.TabIndex = 3;
            this.minimizeIcon.TabStop = false;
            this.minimizeIcon.Click += new System.EventHandler(this.minimizeIcon_Click);
            // 
            // centralPanel
            // 
            this.centralPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.centralPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.centralPanel.Location = new System.Drawing.Point(25, 177);
            this.centralPanel.Name = "centralPanel";
            this.centralPanel.Size = new System.Drawing.Size(305, 298);
            this.centralPanel.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::petDashboard.Properties.Resources.logo_petcomp;
            this.pictureBox1.Location = new System.Drawing.Point(25, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.pictureBox1.Size = new System.Drawing.Size(305, 115);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(354, 497);
            this.ControlBox = false;
            this.Controls.Add(this.centralPanel);
            this.Controls.Add(this.closeIcon);
            this.Controls.Add(this.minimizeIcon);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(370, 513);
            this.MinimumSize = new System.Drawing.Size(370, 513);
            this.Name = "FormLogin";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private FontAwesome.Sharp.IconPictureBox closeIcon;
        private FontAwesome.Sharp.IconPictureBox minimizeIcon;
        private System.Windows.Forms.Panel centralPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
namespace petDashboard
{
    partial class UserProfileItem
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.info = new System.Windows.Forms.Label();
            this.avatarIcon = new FontAwesome.Sharp.IconPictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.modo = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatarIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.modo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.info);
            this.panel1.Controls.Add(this.avatarIcon);
            this.panel1.Location = new System.Drawing.Point(4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(219, 268);
            this.panel1.TabIndex = 0;
            // 
            // info
            // 
            this.info.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.info.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info.ForeColor = System.Drawing.Color.Gainsboro;
            this.info.Location = new System.Drawing.Point(0, 180);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(217, 70);
            this.info.TabIndex = 1;
            this.info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // avatarIcon
            // 
            this.avatarIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.avatarIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.avatarIcon.ForeColor = System.Drawing.Color.Gainsboro;
            this.avatarIcon.IconChar = FontAwesome.Sharp.IconChar.User;
            this.avatarIcon.IconColor = System.Drawing.Color.Gainsboro;
            this.avatarIcon.IconSize = 142;
            this.avatarIcon.Location = new System.Drawing.Point(41, 35);
            this.avatarIcon.Name = "avatarIcon";
            this.avatarIcon.Size = new System.Drawing.Size(143, 142);
            this.avatarIcon.TabIndex = 0;
            this.avatarIcon.TabStop = false;
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(4, 251);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mode:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // modo
            // 
            this.modo.AutoSize = true;
            this.modo.ForeColor = System.Drawing.Color.Gainsboro;
            this.modo.Location = new System.Drawing.Point(38, 251);
            this.modo.Name = "modo";
            this.modo.Size = new System.Drawing.Size(0, 13);
            this.modo.TabIndex = 3;
            // 
            // UserProfileItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.Controls.Add(this.panel1);
            this.Name = "UserProfileItem";
            this.Size = new System.Drawing.Size(226, 274);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatarIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconPictureBox avatarIcon;
        private System.Windows.Forms.Label info;
        private System.Windows.Forms.Label modo;
        private System.Windows.Forms.Label label1;
    }
}

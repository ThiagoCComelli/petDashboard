namespace petDashboard
{
    partial class MeetingItem
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
            this.saveIcon = new FontAwesome.Sharp.IconPictureBox();
            this.radioPublic = new System.Windows.Forms.RadioButton();
            this.radioPrivate = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.conteudo = new System.Windows.Forms.TextBox();
            this.deleteIcon = new FontAwesome.Sharp.IconPictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.categoria = new System.Windows.Forms.DomainUpDown();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.saveIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deleteIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.saveIcon);
            this.panel1.Controls.Add(this.radioPublic);
            this.panel1.Controls.Add(this.radioPrivate);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.conteudo);
            this.panel1.Controls.Add(this.deleteIcon);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.categoria);
            this.panel1.Location = new System.Drawing.Point(4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(730, 145);
            this.panel1.TabIndex = 0;
            // 
            // saveIcon
            // 
            this.saveIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.saveIcon.ForeColor = System.Drawing.Color.Green;
            this.saveIcon.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.saveIcon.IconColor = System.Drawing.Color.Green;
            this.saveIcon.IconSize = 21;
            this.saveIcon.Location = new System.Drawing.Point(34, 118);
            this.saveIcon.Name = "saveIcon";
            this.saveIcon.Size = new System.Drawing.Size(21, 21);
            this.saveIcon.TabIndex = 7;
            this.saveIcon.TabStop = false;
            this.saveIcon.Click += new System.EventHandler(this.saveIcon_Click);
            // 
            // radioPublic
            // 
            this.radioPublic.AutoSize = true;
            this.radioPublic.Checked = true;
            this.radioPublic.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioPublic.ForeColor = System.Drawing.Color.Gainsboro;
            this.radioPublic.Location = new System.Drawing.Point(631, 9);
            this.radioPublic.Name = "radioPublic";
            this.radioPublic.Size = new System.Drawing.Size(66, 20);
            this.radioPublic.TabIndex = 6;
            this.radioPublic.TabStop = true;
            this.radioPublic.Text = "Publico";
            this.radioPublic.UseVisualStyleBackColor = true;
            this.radioPublic.CheckedChanged += new System.EventHandler(this.radioPublic_CheckedChanged);
            // 
            // radioPrivate
            // 
            this.radioPrivate.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioPrivate.ForeColor = System.Drawing.Color.Gainsboro;
            this.radioPrivate.Location = new System.Drawing.Point(554, 9);
            this.radioPrivate.Name = "radioPrivate";
            this.radioPrivate.Size = new System.Drawing.Size(71, 20);
            this.radioPrivate.TabIndex = 5;
            this.radioPrivate.Text = "Privado";
            this.radioPrivate.UseVisualStyleBackColor = true;
            this.radioPrivate.CheckedChanged += new System.EventHandler(this.radioPrivate_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(422, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Privacidade:";
            // 
            // conteudo
            // 
            this.conteudo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.conteudo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.conteudo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.conteudo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conteudo.ForeColor = System.Drawing.Color.Gainsboro;
            this.conteudo.Location = new System.Drawing.Point(61, 34);
            this.conteudo.Multiline = true;
            this.conteudo.Name = "conteudo";
            this.conteudo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.conteudo.Size = new System.Drawing.Size(636, 98);
            this.conteudo.TabIndex = 3;
            // 
            // deleteIcon
            // 
            this.deleteIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.deleteIcon.ForeColor = System.Drawing.Color.Red;
            this.deleteIcon.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.deleteIcon.IconColor = System.Drawing.Color.Red;
            this.deleteIcon.IconSize = 21;
            this.deleteIcon.Location = new System.Drawing.Point(7, 118);
            this.deleteIcon.Name = "deleteIcon";
            this.deleteIcon.Size = new System.Drawing.Size(21, 21);
            this.deleteIcon.TabIndex = 2;
            this.deleteIcon.TabStop = false;
            this.deleteIcon.Click += new System.EventHandler(this.deleteIcon_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Atividade:";
            // 
            // categoria
            // 
            this.categoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.categoria.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoria.ForeColor = System.Drawing.Color.Gainsboro;
            this.categoria.Items.Add("Cinepet");
            this.categoria.Items.Add("Laboratorio");
            this.categoria.Items.Add("Aulas");
            this.categoria.Items.Add("Seminarios");
            this.categoria.Items.Add("Eventos");
            this.categoria.Items.Add("Hospital");
            this.categoria.Location = new System.Drawing.Point(116, 5);
            this.categoria.Name = "categoria";
            this.categoria.ReadOnly = true;
            this.categoria.Size = new System.Drawing.Size(120, 21);
            this.categoria.TabIndex = 0;
            this.categoria.Text = "Escolha um item";
            this.categoria.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MeetingItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.Controls.Add(this.panel1);
            this.Name = "MeetingItem";
            this.Size = new System.Drawing.Size(738, 151);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.saveIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deleteIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DomainUpDown categoria;
        private FontAwesome.Sharp.IconPictureBox deleteIcon;
        private System.Windows.Forms.TextBox conteudo;
        private System.Windows.Forms.RadioButton radioPublic;
        private System.Windows.Forms.RadioButton radioPrivate;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconPictureBox saveIcon;
    }
}

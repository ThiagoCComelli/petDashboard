namespace petDashboard
{
    partial class MeetingsInterfaceItem
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
            this.conteudo = new System.Windows.Forms.TextBox();
            this.autor = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dia = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Privacy_ = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.panel1.Controls.Add(this.Privacy_);
            this.panel1.Controls.Add(this.conteudo);
            this.panel1.Controls.Add(this.autor);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.dia);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(730, 143);
            this.panel1.TabIndex = 0;
            // 
            // conteudo
            // 
            this.conteudo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.conteudo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.conteudo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conteudo.ForeColor = System.Drawing.Color.Gainsboro;
            this.conteudo.Location = new System.Drawing.Point(3, 25);
            this.conteudo.Multiline = true;
            this.conteudo.Name = "conteudo";
            this.conteudo.ReadOnly = true;
            this.conteudo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.conteudo.Size = new System.Drawing.Size(724, 115);
            this.conteudo.TabIndex = 4;
            // 
            // autor
            // 
            this.autor.AutoSize = true;
            this.autor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autor.ForeColor = System.Drawing.Color.Gainsboro;
            this.autor.Location = new System.Drawing.Point(374, 4);
            this.autor.Name = "autor";
            this.autor.Size = new System.Drawing.Size(36, 21);
            this.autor.TabIndex = 3;
            this.autor.Text = "null";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(309, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "Autor:";
            // 
            // dia
            // 
            this.dia.AutoSize = true;
            this.dia.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dia.ForeColor = System.Drawing.Color.Gainsboro;
            this.dia.Location = new System.Drawing.Point(142, 4);
            this.dia.Name = "dia";
            this.dia.Size = new System.Drawing.Size(36, 21);
            this.dia.TabIndex = 1;
            this.dia.Text = "null";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reuniao do dia:";
            // 
            // Privacy_
            // 
            this.Privacy_.AutoSize = true;
            this.Privacy_.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Privacy_.ForeColor = System.Drawing.Color.Gainsboro;
            this.Privacy_.Location = new System.Drawing.Point(656, 4);
            this.Privacy_.Name = "Privacy_";
            this.Privacy_.Size = new System.Drawing.Size(36, 21);
            this.Privacy_.TabIndex = 5;
            this.Privacy_.Text = "null";
            // 
            // MeetingsInterfaceItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.Controls.Add(this.panel1);
            this.Name = "MeetingsInterfaceItem";
            this.Size = new System.Drawing.Size(737, 150);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox conteudo;
        private System.Windows.Forms.Label autor;
        private System.Windows.Forms.Label dia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Privacy_;
    }
}

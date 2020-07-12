namespace petDashboard
{
    partial class FormProjetos
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
            this.projeto = new System.Windows.Forms.Label();
            this.conteudo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // projeto
            // 
            this.projeto.Dock = System.Windows.Forms.DockStyle.Top;
            this.projeto.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projeto.ForeColor = System.Drawing.Color.Gainsboro;
            this.projeto.Location = new System.Drawing.Point(0, 0);
            this.projeto.Name = "projeto";
            this.projeto.Size = new System.Drawing.Size(742, 53);
            this.projeto.TabIndex = 0;
            this.projeto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // conteudo
            // 
            this.conteudo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.conteudo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.conteudo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.conteudo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conteudo.ForeColor = System.Drawing.Color.Gainsboro;
            this.conteudo.Location = new System.Drawing.Point(0, 53);
            this.conteudo.Multiline = true;
            this.conteudo.Name = "conteudo";
            this.conteudo.ReadOnly = true;
            this.conteudo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.conteudo.Size = new System.Drawing.Size(742, 385);
            this.conteudo.TabIndex = 2;
            // 
            // FormProjetos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(742, 438);
            this.Controls.Add(this.conteudo);
            this.Controls.Add(this.projeto);
            this.Name = "FormProjetos";
            this.Text = "FormProjetos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label projeto;
        private System.Windows.Forms.TextBox conteudo;
    }
}
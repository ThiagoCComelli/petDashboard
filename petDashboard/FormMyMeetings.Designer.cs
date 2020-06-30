namespace petDashboard
{
    partial class FormMyMeetings
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
            this.flowMyMeetings = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // flowMyMeetings
            // 
            this.flowMyMeetings.AutoScroll = true;
            this.flowMyMeetings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowMyMeetings.Location = new System.Drawing.Point(13, 58);
            this.flowMyMeetings.Name = "flowMyMeetings";
            this.flowMyMeetings.Size = new System.Drawing.Size(743, 302);
            this.flowMyMeetings.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(743, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Consultar reuniões / Minhas reuniões";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormMyMeetings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(768, 372);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowMyMeetings);
            this.Name = "FormMyMeetings";
            this.Text = "FormMyMeetings";
            this.Load += new System.EventHandler(this.FormMyMeetings_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowMyMeetings;
        private System.Windows.Forms.Label label1;
    }
}
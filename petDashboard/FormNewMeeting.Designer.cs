namespace petDashboard
{
    partial class FormNewMeeting
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.flowMeeting = new System.Windows.Forms.FlowLayoutPanel();
            this.addIcon = new FontAwesome.Sharp.IconButton();
            this.readyBtn = new FontAwesome.Sharp.IconButton();
            this.resultText = new System.Windows.Forms.Label();
            this.clearIcon = new FontAwesome.Sharp.IconButton();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(356, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Escrever nova reuniao:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(355, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(134, 30);
            this.panel2.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarForeColor = System.Drawing.Color.Gainsboro;
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.dateTimePicker1.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.dateTimePicker1.CalendarTitleForeColor = System.Drawing.SystemColors.ButtonFace;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(37, 10);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(89, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(3, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Dia:";
            // 
            // flowMeeting
            // 
            this.flowMeeting.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowMeeting.AutoScroll = true;
            this.flowMeeting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.flowMeeting.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowMeeting.Location = new System.Drawing.Point(12, 48);
            this.flowMeeting.Name = "flowMeeting";
            this.flowMeeting.Size = new System.Drawing.Size(744, 291);
            this.flowMeeting.TabIndex = 2;
            // 
            // addIcon
            // 
            this.addIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.addIcon.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.addIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addIcon.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.addIcon.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addIcon.ForeColor = System.Drawing.Color.Gainsboro;
            this.addIcon.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.addIcon.IconColor = System.Drawing.Color.Gainsboro;
            this.addIcon.IconSize = 16;
            this.addIcon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addIcon.Location = new System.Drawing.Point(666, 312);
            this.addIcon.Name = "addIcon";
            this.addIcon.Rotation = 0D;
            this.addIcon.Size = new System.Drawing.Size(86, 23);
            this.addIcon.TabIndex = 0;
            this.addIcon.Text = "Adicionar";
            this.addIcon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addIcon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addIcon.UseVisualStyleBackColor = false;
            this.addIcon.Click += new System.EventHandler(this.addIcon_Click);
            // 
            // readyBtn
            // 
            this.readyBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.readyBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.readyBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.readyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.readyBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.readyBtn.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readyBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.readyBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.readyBtn.IconColor = System.Drawing.Color.Black;
            this.readyBtn.IconSize = 16;
            this.readyBtn.Location = new System.Drawing.Point(674, 344);
            this.readyBtn.Name = "readyBtn";
            this.readyBtn.Rotation = 0D;
            this.readyBtn.Size = new System.Drawing.Size(82, 23);
            this.readyBtn.TabIndex = 3;
            this.readyBtn.Text = "Concluir";
            this.readyBtn.UseVisualStyleBackColor = false;
            this.readyBtn.Click += new System.EventHandler(this.readyBtn_Click);
            // 
            // resultText
            // 
            this.resultText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.resultText.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultText.ForeColor = System.Drawing.Color.Gainsboro;
            this.resultText.Location = new System.Drawing.Point(12, 344);
            this.resultText.Name = "resultText";
            this.resultText.Size = new System.Drawing.Size(656, 23);
            this.resultText.TabIndex = 4;
            this.resultText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // clearIcon
            // 
            this.clearIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.clearIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.clearIcon.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.clearIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearIcon.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.clearIcon.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearIcon.ForeColor = System.Drawing.Color.Gainsboro;
            this.clearIcon.IconChar = FontAwesome.Sharp.IconChar.MinusSquare;
            this.clearIcon.IconColor = System.Drawing.Color.Gainsboro;
            this.clearIcon.IconSize = 16;
            this.clearIcon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.clearIcon.Location = new System.Drawing.Point(589, 312);
            this.clearIcon.Name = "clearIcon";
            this.clearIcon.Rotation = 0D;
            this.clearIcon.Size = new System.Drawing.Size(71, 23);
            this.clearIcon.TabIndex = 5;
            this.clearIcon.Text = "Limpar";
            this.clearIcon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.clearIcon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.clearIcon.UseVisualStyleBackColor = false;
            this.clearIcon.Click += new System.EventHandler(this.clearIcon_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(495, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Privacidade:";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.ForeColor = System.Drawing.Color.Gainsboro;
            this.radioButton1.Location = new System.Drawing.Point(607, 23);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(76, 21);
            this.radioButton1.TabIndex = 7;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Privado";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.ForeColor = System.Drawing.Color.Gainsboro;
            this.radioButton2.Location = new System.Drawing.Point(685, 23);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(74, 21);
            this.radioButton2.TabIndex = 8;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Publico";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // FormNewMeeting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(768, 372);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.clearIcon);
            this.Controls.Add(this.resultText);
            this.Controls.Add(this.readyBtn);
            this.Controls.Add(this.addIcon);
            this.Controls.Add(this.flowMeeting);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Name = "FormNewMeeting";
            this.Text = "Form1";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flowMeeting;
        private FontAwesome.Sharp.IconButton addIcon;
        private FontAwesome.Sharp.IconButton readyBtn;
        private System.Windows.Forms.Label resultText;
        private FontAwesome.Sharp.IconButton clearIcon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
    }
}
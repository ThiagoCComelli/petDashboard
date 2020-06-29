using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace petDashboard
{
    public partial class FormNewMeeting : Form
    {
        public FormNewMeeting()
        {
            InitializeComponent();
        }

        public string privacy = "Privado";

        private void addIcon_Click(object sender, EventArgs e)
        {
            flowMeeting.Controls.Add(new MeetingItem());
        }

        private void readyBtn_Click(object sender, EventArgs e)
        {

            if(DB.newMeeting(flowMeeting, dateTimePicker1.Value,privacy))
            {
                resultText.Text = "Operacao realizada com sucesso";
                resultText.ForeColor = System.Drawing.Color.Green;
                
            } else
            {
                resultText.Text = "Falha na realizao da operacao, falta preencher alguns campos";
                resultText.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void clearIcon_Click(object sender, EventArgs e)
        {
            flowMeeting.Controls.Clear();
            resultText.Text = "";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            privacy = "Privado";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            privacy = "Publico";
        }
    }
}

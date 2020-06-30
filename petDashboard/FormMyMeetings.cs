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
    public partial class FormMyMeetings : Form
    {
        bool op;
        public FormMyMeetings(bool op)
        {
            op = op;
            InitializeComponent();
        }

        private void populate()
        {
            var results = DB.allMyMeetings();

            MeetingsInterfaceItem meeting;

            foreach (var i in results)
            {
                meeting = new MeetingsInterfaceItem();
                meeting.Conteudo = i.content;
                Console.WriteLine(i.content);
                meeting.Data = i.date.ToString();
                meeting.Author = i.author;
                flowMyMeetings.Controls.Add(meeting);
            }
        }

        private void FormMyMeetings_Load(object sender, EventArgs e)
        {
            populate();
            if (op)
            {
                label1.Text = "Consultar reuniões / Minhas reuniões";
            } else
            {
                label1.Text = "Consultar reuniões / Todas reuniões publicas";
            }
        }
    }
}

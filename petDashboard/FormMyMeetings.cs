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
        string op;
        public FormMyMeetings(string _op)
        {
            op = _op;
            InitializeComponent();
        }

        private void populate(bool _op = true)
        {
            List<Meeting> results;
            if (_op)
            {
                if (op == "allMy")
                {
                    results = DB.allMyMeetings();
                } else
                {
                    results = DB.allMeetingPublic();
                } 
            } else
            {
                results = DB.allMeetingPublicTags(categoria.Text);
            }

            MeetingsInterfaceItem meeting;

            flowMyMeetings.Controls.Clear();

            foreach (var i in results)
            {
                meeting = new MeetingsInterfaceItem();
                meeting.Conteudo = i.content;
                meeting.Data = i.date.ToString();
                meeting.Author = i.author;
                meeting.Privacy = i.privacy;
                flowMyMeetings.Controls.Add(meeting);
            }
        }

        private void FormMyMeetings_Load(object sender, EventArgs e)
        {
            if (op == "allMy")
            {
                label1.Text = "Consultar reuniões / Minhas reuniões";
            } else if (op == "allPublic")
            {
                label1.Text = "Consultar reuniões / Todas reuniões publicas";
            } else
            {
                label1.Text = "Consultar reuniões / Pesquisar por tag";
            }
            if(op != "allPerTags")
            {
                populate(true);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            populate(false);
        }
    }
}

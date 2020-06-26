using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace petDashboard
{
    public partial class FormDeveloper : Form
    {
        public FormDeveloper()
        {
            InitializeComponent();
        }

        private void FormDeveloper_Load(object sender, EventArgs e)
        {

        }

        private void linkedinIcon_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText("https://www.linkedin.com/in/thiagoccomelli/");
            Process.Start("https://www.linkedin.com/in/thiagoccomelli/");
        }

        private void githubIcon_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText("https://github.com/ThiagoCComelli");
            Process.Start("https://github.com/ThiagoCComelli");
        }

        private void whatsIcon_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText("+55048996030226");
            Process.Start("https://api.whatsapp.com/send?phone=5548996030226");
        }
    }
}

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
    public partial class FormConsult : Form
    {
        Form currentChildForm = null;
        Panel rootPanel = null;
        public FormConsult(Panel root)
        {
            rootPanel = root;
            InitializeComponent();       
        }

        private void openChildForm(Form childForm)
        {
            if (currentChildForm != null && currentChildForm.Name == childForm.Name)
            {
                currentChildForm.Close();
                currentChildForm = null;
            }
            else
            {
                if (currentChildForm != null)
                {
                    currentChildForm.Close();
                }
                
                currentChildForm = childForm;
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
                rootPanel.Controls.Add(childForm);
                rootPanel.Tag = childForm;
                childForm.BringToFront();
                childForm.Show();
            }
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            openChildForm(new FormMyMeetings(true));
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            openChildForm(new FormMyMeetings(false));
        }

        private void iconButton3_Click_1(object sender, EventArgs e)
        {

        }
    }
}

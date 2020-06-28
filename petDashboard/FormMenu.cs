using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace petDashboard
{
    public partial class FormMenu : Form
    {
        private Form currentChildForm;
        private Panel activePanel;
        
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        public FormMenu()
        {
            InitializeComponent();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            if(Global.user.mode == null)
            {
                panel1.Visible = false;
                openChildForm(new FormDeveloper());
            }
        }
        private void reset()
        {
            if(currentChildForm != null)
            {
                currentChildForm.Close();
                currentChildForm = null;
            }
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
                if(currentChildForm != null)
                {
                    currentChildForm.Close();
                }
                currentChildForm = childForm;
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
                panelDesktop.Controls.Add(childForm);
                panelDesktop.Tag = childForm;
                childForm.BringToFront();
                childForm.Show();
            }
        }

        private void switchPanel(Panel panel)
        {

            if (panel.Visible)
            {
                panel.Visible = false;
                activePanel = null;
            }
            else
            {
                if(activePanel != null)
                {
                    activePanel.Visible = false;
                }
                panel.Visible = true;
                activePanel = panel;
            }
        }
        private void projectBtn_Click(object sender, EventArgs e)
        {
            switchPanel(projectsPanel);
        }

        private void usersBtn_Click(object sender, EventArgs e)
        {
            switchPanel(usersPanel);
        }
        private void reuniaoBtn_Click(object sender, EventArgs e)
        {
            switchPanel(reuniaoPanel);
        }

        private void developerBtn_Click(object sender, EventArgs e)
        {
            openChildForm(new FormDeveloper());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
            /*FormBorderStyle = FormBorderStyle.Sizable;*/
/*            WindowState = FormWindowState.Normal;
*/        }

        private void closeIcon_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void redimensionIcon_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                /*WindowState = FormWindowState.Maximized;
                FormBorderStyle = FormBorderStyle.None;*/
            }
            else
            {
                WindowState = FormWindowState.Normal;
                /*FormBorderStyle = FormBorderStyle.Sizable;*/

            }
        }

        private void minimizeIcon_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin login = new FormLogin();
            login.ShowDialog();
            this.Close();
        }

        private void profileBtn_Click(object sender, EventArgs e)
        {
            openChildForm(new FormProfile());
        }

        private void allusersBtn_Click(object sender, EventArgs e)
        {
            openChildForm(new FormUsers());
        }
    }
}

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

namespace petDashboard
{
    public partial class FormLogin : Form
    {
        private Form currentChildForm;

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        public FormLogin()
        {
            DB.ConnectToMongoService();
            InitializeComponent();            
        }

        private void openChildForm(Form childForm)
        {
            if (currentChildForm != null || currentChildForm == childForm)
            {
                currentChildForm.Close();
                currentChildForm = null;
            }
            else if (currentChildForm != childForm)
            {
                currentChildForm = childForm;
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
                centralPanel.Controls.Add(childForm);
                centralPanel.Tag = childForm;
                childForm.BringToFront();
                childForm.Show();
            }
        }

        private void closeIcon_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimizeIcon_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            reset();
            switchPanel(registerPanel);
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (loginTextbox.Text != "" && passwdTextbox.Text != "")
            {
                if(DB.loginBD(loginTextbox.Text, passwdTextbox.Text))
                {
                    this.Hide();
                    FormMenu menu = new FormMenu();
                    menu.ShowDialog();
                    this.Close();
                } else
                {
                    resultText.ForeColor = System.Drawing.Color.Red;
                    resultText.Text = "Login não encontrado";
                }
            }
        }

        private void registerBtn1_Click(object sender, EventArgs e)
        {
            if(loginTextRegister.Text != "" && passwd1TextRegister.Text != "" && passwdTextRegister.Text == passwd1TextRegister.Text)
            {
                if (DB.registerBD(loginTextRegister.Text, passwdTextRegister.Text))
                {
                    resultText.ForeColor = System.Drawing.Color.Green;
                    resultText.Text = "Cadastro efetuado com sucesso";
                } else
                {
                    resultText.ForeColor = System.Drawing.Color.Red;
                    resultText.Text = "Falha no cadastro";
                }
            } else
            {
                resultText.ForeColor = System.Drawing.Color.Red;
                resultText.Text = "Informações incorretas";
            }
        }

        private void voltarBtn_Click(object sender, EventArgs e)
        {
            reset();
            switchPanel(panelLogin);
        }

        private void reset()
        {
            resultText.Text = "";
            loginTextbox.Text = "";
            passwdTextbox.Text = "";
            loginTextRegister.Text = "";
            passwdTextRegister.Text = "";
            passwd1TextRegister.Text = "";
        }

        private void switchPanel(Panel panel)
        {
            if(panel == registerPanel)
            {
                panelLogin.Visible = false;
                registerPanel.Visible = true;
            } else
            {
                panelLogin.Visible = true;
                registerPanel.Visible = false;
            }
        }

    }
}

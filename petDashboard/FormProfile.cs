using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace petDashboard
{
    public partial class FormProfile : Form
    {
        public FormProfile()
        {
            InitializeComponent();
            setup();
        }

        private void setup()
        {
            loadAvatar();
            changeInfo();
        }

        private void loadAvatar()
        {
            try
            {
                WebRequest request = WebRequest.Create(Global.user.fotoLink);
                using (var response = request.GetResponse())
                {
                    using (var str = response.GetResponseStream())
                    {
                        avatarImage.Image = Bitmap.FromStream(str);
                    }
                }
            } catch
            {
                
            }
        }
        private void changeInfo()
        {
            nameLabel.Text = Global.user.nome;
            emailLabel.Text = Global.user.email;
            periodoLabel.Text = Global.user.periodo;
            loginLabel.Text = Global.user._id;
            permissaoLabel.Text = Global.user.password;
            fotoLabel.Text = Global.user.fotoLink;

            nome.Text = Global.user.nome;
            email.Text = Global.user.email;
            foto.Text = Global.user.fotoLink;
            senha.Text = Global.user.password;
            login.Text = Global.user._id;
            periodo.Text = Global.user.periodo;
        }
        private void switchPanel(Panel panel)
        {
            if (panel == editPanel)
            {
                profilePanel.Visible = false;
                editPanel.Visible = true;
            }
            else
            {
                profilePanel.Visible = true;
                editPanel.Visible = false;
            }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            changeInfo();
            switchPanel(editPanel);    
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            changeInfo();
            switchPanel(profilePanel);
        }

        private void editConfirmBtn_Click(object sender, EventArgs e)
        {
            if(DB.updateInfo(nome.Text,email.Text, foto.Text, senha.Text, periodo.Text))
            {
                label7.ForeColor = System.Drawing.Color.Green;
                label7.Text = "Operação realizada com sucesso!";
                changeInfo();
                switchPanel(profilePanel);
            } else
            {
                label7.ForeColor = System.Drawing.Color.Red;
                label7.Text = "Falha na realização da operação!";
            }

        }
    }
}

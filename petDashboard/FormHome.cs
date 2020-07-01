using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;

namespace petDashboard
{
    public partial class FormHome : Form
    {
        FormMenu root;
        public FormHome(FormMenu _root)
        {
            root = _root;
            InitializeComponent();
        }

        private void petIcon_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText("https://petcomputacao.ufsc.br/");
            Process.Start("https://petcomputacao.ufsc.br/");
        }

        private void logoutIcon_Click(object sender, EventArgs e)
        {
            root.Hide();
            FormLogin login = new FormLogin();
            login.ShowDialog();
            root.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace petDashboard
{
    public partial class MeetingItem : UserControl
    {
        public MeetingItem()
        {
            InitializeComponent();
        }

        private void deleteIcon_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        #region Properties
        private string _conteudo;
        private string _categoria;
        private string _privacy = null;

        [Category("Custom Props")]
        public string Conteudo
        {
            get { return _conteudo; }
            set { _conteudo = value; conteudo.Text = value; }
        }

        [Category("Custom Props")]
        public string Categoria
        {
            get { return _categoria; }
            set { _categoria = value; categoria.Text = value; }
        }
        [Category("Custom Props")]
        public string Privacy
        {
            get { return _privacy; }
            set { _privacy = value; }
        }
        #endregion

        public void update()
        {
            this.Conteudo = conteudo.Text;
            this.Categoria = categoria.Text;
        }
        private void saveIcon_Click(object sender, EventArgs e)
        {
            this.Conteudo = conteudo.Text;
            this.Categoria = categoria.Text;
        }

        private void radioPrivate_CheckedChanged(object sender, EventArgs e)
        {
            _privacy = "Privado";
        }

        private void radioPublic_CheckedChanged(object sender, EventArgs e)
        {
            _privacy = "Publico";
        }
    }
}

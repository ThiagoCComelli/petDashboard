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
    public partial class MeetingsInterfaceItem : UserControl
    {
        public MeetingsInterfaceItem()
        {
            InitializeComponent();
        }

        #region Properties
        private string _conteudo;
        private string _data;
        private string _author;
        private string _privacy;

        [Category("Custom Props")]
        public string Conteudo
        {
            get { return _conteudo; }
            set { _conteudo = value; conteudo.Text = value; }
        }

        [Category("Custom Props")]
        public string Data
        {
            get { return _data; }
            set { _data = value; dia.Text = value; }
        }

        [Category("Custom Props")]
        public string Author
        {
            get { return _author; }
            set { _author = value; autor.Text = value; }
        }

        [Category("Custom Props")]
        public string Privacy
        {
            get { return _privacy; }
            set { _privacy = value; Privacy_.Text = value; }
        }
        #endregion
    }
}

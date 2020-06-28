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
    public partial class UserProfileItem : UserControl
    {
        public UserProfileItem()
        {
            InitializeComponent();
        }

        #region Properties
        private string _message;
        private string _mode;

        private User _user;

        [Category("Custom Props")]
        public string Message
        {
            get { return _message; }
            set { _message = value; info.Text = value; }
        }

        [Category("Custom Props")]
        public string Mode
        {
            get { return _mode; }
            set { _mode = value; modo.Text = value; }
        }

        [Category("Custom Props")]
        public User User
        {
            get { return _user; }
            set { _user = value; }
        }
        #endregion

        private void label1_Click(object sender, EventArgs e)
        {
            if(Global.user.mode == "SuperUser" && Global.user._id != _user._id)
            {
                if(_user.mode == "Normal")
                {
                    _user = DB.updateUserMode(_user, "SuperUser");
                    modo.Text = _user.mode;

                } else
                {
                    _user = DB.updateUserMode(_user, "Normal");
                    modo.Text = _user.mode;
                }
            }
        }
    }
}

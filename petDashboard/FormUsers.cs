using MongoDB.Bson;
using MongoDB.Driver;
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
    public partial class FormUsers : Form
    {
        public FormUsers()
        {
            InitializeComponent();
        }

        private void populate()
        {
            var documents = Global.collectionLogin.Find(new BsonDocument()).ToList();
            UserProfileItem user;

            foreach(var i in documents)
            {
                user = new UserProfileItem();
                user.Message = i.nome+" / "+i.periodo;
                user.Mode = i.mode;
                user.User = i;
                flowUsers.Controls.Add(user);
            }
        }

        private void FormUsers_Load(object sender, EventArgs e)
        {
            populate();
        }
    }
}

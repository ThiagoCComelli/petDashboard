using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;
using System.Windows.Forms;
using System.Runtime.CompilerServices;

namespace petDashboard
{
    public class DB
    {
        public static void ConnectToMongoService()
        {
            const string connectionString = "mongodb+srv://thiago:1234@cluster0-jhejj.gcp.mongodb.net/PETDashboard?retryWrites=true&w=majority";
            IMongoClient clients = new MongoClient(connectionString);
            IMongoDatabase databases = clients.GetDatabase("PETDashboard");
            IMongoCollection<User> collectionsLogin = databases.GetCollection<User>("users");
            IMongoCollection<Meeting> collectionsMeetings = databases.GetCollection<Meeting>("meeting");
            IMongoCollection<Meeting> collectionsMeetingsTags = databases.GetCollection<Meeting>("meetingPerTags");

            Global.client = clients;
            Global.database = databases;
            Global.collectionLogin = collectionsLogin;
            Global.collectionMeeting = collectionsMeetings;
            Global.collectionMeetingTags = collectionsMeetingsTags;
        }

        public static bool registerBD(string login,string passwd)
        {
            try
            {
                Global.collectionLogin.InsertOne(new User { _id = login,password=passwd,author=login});
                return true;
            } catch
            {
                return false;
            }
        }

        public static bool loginBD(string login,string passwd)
        {
            try
            {
                var results = Global.collectionLogin.Find(x => x._id == login && x.password == passwd).ToList();
                if (results.Count == 1)
                {
                    Global.user = results[0];
                    return true;
                } else
                {
                    return false;
                }
            } catch
            {
                return false;
            }
        }

        public static User updateUserMode(User user, string mode)
        {
            try
            {
                string filter = "{'_id':'" + user._id + "'}";
                string param = "{$set: {'mode':'" + mode + "'} }";

                BsonDocument filterdoc = BsonDocument.Parse(filter);
                BsonDocument document = BsonDocument.Parse(param);

                Global.collectionLogin.UpdateOne(filterdoc, document);

                var results = Global.collectionLogin.Find(x => x._id == user._id).ToList();

                return results[0];
            } catch
            {
                return user;
            }
        }

        public static void updateInfo(string name, string email, string foto, string senha,string periodo)
        {
            try
            {
                Global.user.nome = name;
                Global.user.email = email;
                Global.user.fotoLink = foto;
                Global.user.password = senha;
                Global.user.periodo = periodo;

                string filter = "{'_id':'"+Global.user._id + "'}";

                BsonDocument filterdoc = BsonDocument.Parse(filter);
                
                Global.collectionLogin.ReplaceOne(filterdoc,Global.user);

                var results = Global.collectionLogin.Find(x => x._id == Global.user._id).ToList();
                if (results.Count == 1)
                {
                    Global.user = results[0];
                }
            } catch
            {
                
            }
        }
        public static bool newMeeting(FlowLayoutPanel item, DateTime time,string privacy)
        {
            string conteudo = "";
            int err = 0;

            foreach (var i in item.Controls.OfType<MeetingItem>())
            {
                i.update();
                if (i.Conteudo != "" && i.Categoria != "Escolha um item" && i.Privacy != null)
                {
                    i.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
                    conteudo += i.Categoria.ToUpper() + "\n" + i.Conteudo + "\n\n";
                }
                else
                {
                    i.BackColor = System.Drawing.Color.Red;
                    err++;
                }
            }
            if (err == 0)
            {
                List<Meeting> meetings = new List<Meeting>();
                try
                {
                    Global.collectionMeeting.InsertOne(new Meeting { date = time,content = conteudo,author = Global.user._id, privacy = privacy});
                    foreach(var i in item.Controls.OfType<MeetingItem>())
                    {
                        Meeting localItem = new Meeting();

                        localItem.date = time;
                        localItem.content = i.Conteudo;
                        localItem.author = Global.user._id;
                        localItem.privacy = i.Privacy;
                        localItem.tag = i.Categoria;

                        meetings.Add(localItem);
                    }
                    Global.collectionMeetingTags.InsertMany(meetings);

                    return true;
                }
                catch
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public static List<Meeting> allMyMeetings()
        {
            var results = Global.collectionMeeting.Find(x => x.author == Global.user.author).ToList();

            return results;
        }
    }
    public class Global
    {
        public static IMongoClient client;
        public static IMongoDatabase database;
        public static IMongoCollection<User> collectionLogin;
        public static IMongoCollection<Meeting> collectionMeeting;
        public static IMongoCollection<Meeting> collectionMeetingTags;
        public static User user;
    }
    public class User
    {
        public string _id { get; set; }
        public string author { get; set; }
        public string password { get; set; }
        public string mode { get; set; }
        public string email { get; set; }
        public string nome { get; set; }
        public string periodo { get; set; }
        public string fotoLink { get; set; }

    }
    public class Meeting
    {
        public ObjectId _id { get; set; }
        public DateTime date { get; set; }
        public string content { get; set; }
        public string tag { get; set; }
        public string author { get; set; }
        public string privacy { get; set; }
    }
}

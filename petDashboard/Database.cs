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

            Global.client = clients;
            Global.database = databases;
            Global.collectionLogin = collectionsLogin;
        }

        public static bool registerBD(string login,string passwd)
        {
            try
            {
                Global.collectionLogin.InsertOne(new User {_id=login,password=passwd});
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
                if(results.Count == 1)
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

                string filter = "{'_id':'"+Global.user._id+"'}";

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
    }
    public class Global
    {
        public static IMongoClient client;
        public static IMongoDatabase database;
        public static IMongoCollection<User> collectionLogin;
        public static User user;
    }
    public class User
    {
        public string _id { get; set; }
        public string password { get; set; }
        public string mode { get; set; }
        public string email { get; set; }
        public string nome { get; set; }
        public string periodo { get; set; }
        public string fotoLink { get; set; }

        public static implicit operator User(string v)
        {
            throw new NotImplementedException();
        }
    }
}

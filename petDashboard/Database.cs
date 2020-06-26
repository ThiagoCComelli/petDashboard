using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;

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
    }
}

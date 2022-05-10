using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNames_Mongodb
{
    internal class DatabaseConnection
    {
        private static readonly string connectionString = "mongodb://127.0.0.1:27017";
        private static readonly string databaseName = "NonSenseNames_DataBaseTest";
        private static readonly string collectionName = "NonSensepeople";

        private static MongoClient client;
        private static IMongoDatabase db;
        private static IMongoCollection<PersonModel> collection;

        static DatabaseConnection()
        {
            client = new MongoClient(connectionString);
            db = client.GetDatabase(databaseName);
            collection = db.GetCollection<PersonModel>(collectionName);
        }

        public static void SendToMongoDatabase(int limit)
        {
            var ListOfNames = PersonModel.CreateListOfNonsenses(limit);
            foreach (var item in ListOfNames)
            {
                if (item is not null)
                {
                    collection.InsertOne(item);
                }
            }
        }

        public static void RetrieveAll()
        {
            var results = collection.Find(_ => true);
            foreach (var item in results.ToList())
            {
                Console.WriteLine(item.FirstName + ", " + item.LastName + ", " + item.Age.ToString());
            }
        }

        public static object RetrieveById(string id)
        {
            var filter = Builders<PersonModel>.Filter.Eq("ID", id);
            return collection.Find(filter).First();
        }
    }
}

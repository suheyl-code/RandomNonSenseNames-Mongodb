
using MongoDB.Driver;

// How many first names/last names? set the limit bellow:
//SendToMongoDatabase(100);

//RetrieveAll();

//var result = RetrieveById<PersonModel>("62793f9595737a855e3f81e1");
//Console.WriteLine(result.ToString());


static void SendToMongoDatabase(int limit)
{
    string connectionString = "mongodb://127.0.0.1:27017";
    string databaseName = "NonSenseNames_DataBase";
    string collectionName = "NonSensepeople";

    var client = new MongoClient(connectionString);
    var db = client.GetDatabase(databaseName);
    var collection = db.GetCollection<PersonModel>(collectionName);

    var ListOfNames = PersonModel.CreateListOfNonsenses(limit);
    foreach (var item in ListOfNames)
    {
        if(item is not null)
        {
            collection.InsertOne(item);
        }
    }
}

static void RetrieveAll()
{
    string connectionString = "mongodb://127.0.0.1:27017";
    string databaseName = "NonSenseNames_DataBase";
    string collectionName = "NonSensepeople";

    var client = new MongoClient(connectionString);
    var db = client.GetDatabase(databaseName);
    var collection = db.GetCollection<PersonModel>(collectionName);
    
    var results = collection.Find(_ => true);
    foreach (var item in results.ToList())
    {
        Console.WriteLine(item.FirstName + " " + item.LastName + " " + item.Age.ToString());
    }
}

static object RetrieveById<PersonModel>(string id)
{
    string connectionString = "mongodb://127.0.0.1:27017";
    string databaseName = "NonSenseNames_DataBase";
    string collectionName = "NonSensepeople";

    var client = new MongoClient(connectionString);
    var db = client.GetDatabase(databaseName);
    var collection = db.GetCollection<PersonModel>(collectionName);
    var filter = Builders<PersonModel>.Filter.Eq("ID", id);
    return collection.Find(filter).First();
}
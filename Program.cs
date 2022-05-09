
using MongoDB.Driver;

// How many first names/last names? set the limit bellow:
SendToMongoDatabase(10);







static List<PersonModel> CreateListOfNames(int limit)
{
    var listOfNonsenseNames = new List<PersonModel>();
    for (int i = 0; i < limit; i++)
    {
        var yourNewItem = new PersonModel
        {
            FirstName = RandomGenerator.GenerateRandomName(),
            LastName = RandomGenerator.GenerateRandomName()
        };

        listOfNonsenseNames.Add(yourNewItem);
    }
    return listOfNonsenseNames;

}

static void SendToMongoDatabase(int limit)
{
    string connectionString = "mongodb://127.0.0.1:27017";
    string databaseName = "NonSenseNames_DataBase";
    string collectionName = "NonSensepeople";

    var client = new MongoClient(connectionString);
    var db = client.GetDatabase(databaseName);
    var collection = db.GetCollection<PersonModel>(collectionName);

    var ListOfNames = CreateListOfNames(limit);
    foreach (var item in ListOfNames)
    {
        if(item is not null)
            collection.InsertOne(item);
    }

}
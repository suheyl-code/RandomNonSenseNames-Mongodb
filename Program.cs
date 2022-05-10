

// How many first names/last names? set the limit bellow:
using RandomNames_Mongodb;

//DatabaseConnection.SendToMongoDatabase(10);

//DatabaseConnection.RetrieveAll();

var result = DatabaseConnection.RetrieveById("6279fda9b13eba466568476b");
Console.WriteLine(result.ToString());



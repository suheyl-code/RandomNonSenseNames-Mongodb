
using RandomNames_Mongodb;
try
{
    //DatabaseConnection.SendToMongoDatabase(10);

    //List<PersonModel> myList = DatabaseConnection.RetrieveAll();
    //var namesBelowTwenty = from items in myList
    //              where items.Age < 20
    //              select items;
    //foreach (var name in namesBelowTwenty)
    //{
    //    Console.WriteLine(name);
    //}


    //var result = DatabaseConnection.RetrieveById("6279fda9b13eba466568476b");
    //Console.WriteLine(result.ToString());
}
catch (Exception ex)
{
    throw new CustomException(ex);
}

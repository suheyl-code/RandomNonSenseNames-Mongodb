
using RandomNames_Mongodb;
try
{
    //DatabaseConnection.SendToMongoDatabase(10);

    List<PersonModel> myList = DatabaseConnection.RetrieveAll();
    var namesBelowTwenty = from items in myList
                           where items.Age < 20
                           select items;
    myList.ForEach(e => Console.WriteLine(e));
    
    Console.WriteLine();
    
    foreach (var name in namesBelowTwenty)
    {
        Console.WriteLine(name);
    }
    Console.WriteLine();
    
    // Same as:
    namesBelowTwenty.ToList().ForEach(e => Console.WriteLine(e));

    //var result = DatabaseConnection.RetrieveById("6279fda9b13eba466568476b");
    //Console.WriteLine(result.ToString());
}
catch (Exception ex)
{
    throw new CustomException(ex);
}

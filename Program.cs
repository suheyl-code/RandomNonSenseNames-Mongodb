
using RandomNames_Mongodb;
try
{
    //DatabaseConnection.SendToMongoDatabase(10);

    //DatabaseConnection.RetrieveAll();

    var result = DatabaseConnection.RetrieveById("6279fda9b13eba466568476b");
    Console.WriteLine(result.ToString());
}
catch (Exception ex)
{
    throw new CustomException(ex);
}

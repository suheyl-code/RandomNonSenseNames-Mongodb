

using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

public class PersonModel
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string? ID { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public int Age { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public static List<PersonModel> CreateListOfNonsenses(int limit)
    {
        var listOfNonsense = new List<PersonModel>();
        for (int i = 0; i < limit; i++)
        {
            var yourNewItem = new PersonModel
            {
                
                FirstName = RandomGenerator.GenerateRandomName(),
                LastName = RandomGenerator.GenerateRandomName(),
                Age = RandomGenerator.GenerateRandomAge(),
            };

            listOfNonsense.Add(yourNewItem);
        }
        return listOfNonsense;
    }

    public override string ToString()
    {
        return $"{FirstName}, {LastName}, {Age}";
    }
}
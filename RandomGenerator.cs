

public static class RandomGenerator
{
    public static Random Random { get; set; }

    static RandomGenerator()
    {
        Random rnd = new Random();
        RandomGenerator.Random = rnd;
    }

    public static string GenerateRandomName()
    {
        int nameLength = Random.Next(2, 8);
        string word = string.Empty;
        for (int i = 0; i < nameLength; i++)
        {
            char alfabet = Convert.ToChar(Random.Next(97, 122));
            word += alfabet;
        }
        return word;
    }

    public static int GenerateRandomAge()
    {
        return Random.Next(1, 99);
    }

}

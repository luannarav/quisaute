using System;
using Newtonsoft.Json;

public class Program
{
    public static void Main()
    {
        string jsonString = "{\"name\": \"Alice\", \"age\": 30}";
        Parse(jsonString);
    }

    public static void Parse(string jsonString)
    {
        try
        {
            var user = JsonConvert.DeserializeObject<User>(jsonString);
            Console.WriteLine(user);
        }
        catch (Exception e)
        {
            Console.WriteLine($"Error parsing JSON: {e.Message}");
        }
    }
}

public class User
{
    public string Name { get; set; }
    public int Age { get; set; }

    public override string ToString()
    {
        return $"User {{ Name = {Name}, Age = {Age} }}";
    }
}

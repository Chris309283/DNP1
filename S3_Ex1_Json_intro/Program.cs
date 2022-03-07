using System.Text.Json;

namespace S3_Ex1_Json_intro;

class Program
{
    public static void Main(string[] args)
    {
        var p1 = new Person("Christopher", "Gadgaard", 28, 1.78, false, 'M',
            new[] {"Fucking bitches", "Being awesome"});
        var p2 = new Person("Vlad", "Lazar", 20, 1.68, false, 'M', new[] {"Sucking cocks", "Eating shit"});
        var p3 = new Person("Mary", "Jane", 18, 1.60, true, 'F', new[] {"Sucking chris' dick", "Blowing smoke"});

        var pList = new List<Person>
        {
            p1,
            p2,
            p3
        };

        string jsonString = JsonSerializer.Serialize(pList);
        Console.WriteLine(jsonString);

        string jsonFormatted = JsonSerializer.Serialize(pList, new JsonSerializerOptions {WriteIndented = true});
        Console.WriteLine(jsonFormatted);
    }
}
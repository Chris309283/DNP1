namespace S3_Ex2_Json_file_storage;

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

        var pp = new PersonPersistence();
        // pp.StorePersons(pList);
        //
        // Console.WriteLine(pp.ReadFile());
        

        foreach (var person in pp.GetPersonsList()!)
        {
            Console.WriteLine(person.ToString());
        }
    }
}
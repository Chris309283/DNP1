namespace S1_Ex7;
class Program
{
    public string MakeAbba(string a, string b)
    {
        return a + b + b + a;
    }

    public static void Main(string[] args)
    {
        Program program = new();

        Console.WriteLine(program.MakeAbba("Hi", "Bye"));
        Console.WriteLine(program.MakeAbba("Yo", "Alice"));
        Console.WriteLine(program.MakeAbba("What", "Up"));
    }
}


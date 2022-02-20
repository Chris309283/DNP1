namespace S1_Ex8;
class Program
{
    public void MakeOutWord(string outer, string inner)
    {
        Console.WriteLine($"{outer[0]}{outer[1]}{inner}{outer[2]}{outer[3]}");
    }

    public static void Main(string[] args)
    {
        Program program = new();
        
        program.MakeOutWord("<<>>","Yay");
        program.MakeOutWord("<<>>","WooHoo");
        program.MakeOutWord("[[]]","word");
    }
}
namespace S1_Ex9;

class Program
{
    public void Substring(string word, int number)
    {
        string result = word.Substring(0, number);
        result += word.Substring(word.Length - number);
        Console.WriteLine(result);
    }

    public static void Main(string[] args)
    {
        Program program = new();
        program.Substring("Hello",2);
        program.Substring("Chocolate",3);
        program.Substring("Chocolate",1);
    }
}
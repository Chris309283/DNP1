namespace S1_Ex10;

class Program
{
    public void BigDiff(int[] ints)
    {
        int max = ints.Max();
        int min = ints.Min();

        Console.WriteLine($"Diff = {max - min}");
    }

    public static void Main(string[] args)
    {
        Program program = new();

        program.BigDiff(new[] {10, 3, 5, 6});
        program.BigDiff(new[] {7, 2, 10, 9});
        program.BigDiff(new[] {2, 10, 7, 2});
    }
}
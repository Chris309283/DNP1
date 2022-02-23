namespace S1_Ex11;
class Program
{
    void CountClumps(int[] ints)
    {
        int clumps = 0;
        int current = -1;
        for (int i = 0; i < ints.Length-1; i++)
        {
            if (ints[i]==ints[i+1] && ints[i] != current)
            {
                current = ints[i];
                clumps++;
            }
            else if (ints[i] != current)
            {
                current = -1;
            }
        }
        Console.WriteLine(clumps);
    }

    public static void Main(string[] args)
    {
        Program program = new();
        program.CountClumps(new []{1, 2, 2, 3, 4, 4});
        program.CountClumps(new []{1, 1, 2, 1, 1});
        program.CountClumps(new []{1, 1, 1, 1, 1});
    }
}


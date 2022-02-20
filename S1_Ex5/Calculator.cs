namespace S1_Ex5;
public class Calculator
{
    public int Add(int x, int y)
    {
        return x + y; 
    }
    public int Add(int[] ints)
    {
        int sum = 0;

        foreach (var variable in ints)
        {
            sum += variable;
        }

        return sum;
    }

    public int Max()
    {
        Console.WriteLine("Input first number: ");
        int x = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Input second number: ");
        int y = Convert.ToInt32(Console.ReadLine());

        return Math.Max(x, y);
    }
}
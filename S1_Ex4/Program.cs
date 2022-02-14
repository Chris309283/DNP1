namespace S1_Ex4;

class Program
{
    public void Even(int x)
    {
       for (int i = 1; i <x; i++)
       {
          if (i%2 == 0)
          {
              Console.WriteLine(i); 
          }
       }
    }
    
    public void Odd(int x)
    {
        for (int i = 1; i <x; i++)
        {
            if (i%2 != 0)
            {
                Console.WriteLine(i); 
            }
        }
    }

    public void Divisible(int x, int y)
    {
        for (int i = 1; i < x; i++)
        {
            if (i%y==0)
            {
                Console.WriteLine(i);
            }
        }
    }
    

    static void Main(string[] args)
    {
        Program p = new();
        p.Even(10);
        p.Odd(10);
        p.Divisible(20,3);
    }
}




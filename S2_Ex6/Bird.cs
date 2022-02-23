namespace S2_Ex6;

public class Bird
{
    public void Run()
    {
        var random = new Random();
        while (true)
        {
            switch (random.Next(1, 4))
            {
                case 1:
                    Console.WriteLine("Bird flaps wings");
                    break;
                case 2:
                    Console.WriteLine("Bird sings");
                    break;
                case 3:
                    Console.WriteLine("Bird does mating dance");
                    break;
            }
            Thread.Sleep(2000);
        }
    }
}
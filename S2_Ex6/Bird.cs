namespace S2_Ex6;

public class Bird
{
    public Action<string> BirdThings;
    private string[] things = {"Bird flaps wings", "Bird sings", "Bird does mating dance"};
    private string birdType;

    public Bird(string birdType)
    {
        this.birdType = birdType;
    }

    public void Run()
    {
        var random = new Random();
        while (true)
        {
            string bird = things[random.Next(0, 3)];
            Console.WriteLine($"{birdType} {bird}");
            BirdThings?.Invoke(bird);
            Thread.Sleep(1000);
        }
    }
}
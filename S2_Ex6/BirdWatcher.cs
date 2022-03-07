namespace S2_Ex6;

public class BirdWatcher
{
    public void ReactToBirdy(string birdThing)
    {
        switch (birdThing)
        {
            case "Bird flaps wings":
                Console.WriteLine("Ooh");
                break;
            case "Bird sings":
                Console.WriteLine("How nice");
                break;
            case "Bird does mating dance":
                Console.WriteLine("Would you look at that");
                break;
        }
    }
}
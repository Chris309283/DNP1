namespace S2_Ex4;

public class Patient
{
    private readonly int NumberInQueue;
    private readonly WaitingRoom waitingRoom;
    public Patient(WaitingRoom waitingRoom)
    {
        NumberInQueue = waitingRoom.DrawNumber();
        this.waitingRoom = waitingRoom;
        waitingRoom.NumberChange += ReactToNumber;
        Console.WriteLine($"Patient {NumberInQueue} enters waiting room");
    }

    private void ReactToNumber(int ticketNumber)
    {
        Console.WriteLine($"Patient {NumberInQueue} looks up");

        if (NumberInQueue == ticketNumber)
        {
            Console.WriteLine($"Patient {NumberInQueue} goes to the doctor's room");
            waitingRoom.NumberChange -= ReactToNumber;
        }
        else
        {
            Console.WriteLine($"Patient {NumberInQueue} goes back to looking at phone");
        }
    }
}
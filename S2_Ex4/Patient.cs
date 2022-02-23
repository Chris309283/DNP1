namespace S2_Ex4;

public class Patient
{
    private int NumberInQueue;
    public Patient(WaitingRoom waitingRoom)
    {
        waitingRoom.NumberChange += ReactToNumber;
        NumberInQueue = waitingRoom.DrawNumber();
        Console.WriteLine($"Patient {NumberInQueue} enters waiting room");
    }

    public void ReactToNumber(int ticketNumber)
    {
        Console.WriteLine($"Patient {NumberInQueue} looks up");
        Console.WriteLine(NumberInQueue == ticketNumber
            ? $"Patient {NumberInQueue} goes to the doctor's room"
            : $"Patient {NumberInQueue} goes back to looking at phone");
    }
}
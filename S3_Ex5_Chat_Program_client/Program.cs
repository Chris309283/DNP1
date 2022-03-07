using System.Net.Sockets;
using System.Text;

namespace S3_Ex5_Chat_Program_client;

class Program
{
    public static void Main(string[] args)
    {
        using TcpClient client = new TcpClient("127.0.0.1", 5000);
        using NetworkStream stream = client.GetStream();
           // ny thread             ListenToServer(stream);

        while (true)
        {
            Console.WriteLine("Please input something to echo...");
            string? input = Console.ReadLine();
  
            if (input != null)
            {
                byte[] dataToServer = Encoding.ASCII.GetBytes(input);
                stream.Write(dataToServer, 0, dataToServer.Length);
            }
  
            if (input.Equals("exit"))
            {
                break;
            }
  
        }
    }

    private static void ListenToServer(NetworkStream stream)
    {
        byte[] dataFromServer = new byte[1024];
        int bytesRead = stream.Read(dataFromServer, 0, dataFromServer.Length);
        string response = Encoding.ASCII.GetString(dataFromServer, 0, bytesRead);
        Console.WriteLine(response);
    }
}
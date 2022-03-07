using System.Net;
using System.Net.Sockets;
using System.Text;

namespace S3_Ex5_Chat_Program_server;

class Program
{
    private static List<NetworkStream> networkStreams = new();

    static void Main(string[] args)
    {
        Console.WriteLine("Starting server..");

        IPAddress ip = IPAddress.Parse("127.0.0.1");
        TcpListener listener = new TcpListener(ip, 5000);
        listener.Start();

        Console.WriteLine("Server started..");

        while (true)
        {
            ConnectClient(listener);
        }
    }

    private static void HandleOneClient(TcpListener listener)
    {
        using TcpClient client = listener.AcceptTcpClient();

        Console.WriteLine("Client connected");
        using NetworkStream stream = client.GetStream();
        
        networkStreams.Add(stream);

        while (true)
        {
            // read
            byte[] dataFromClient = new byte[1024];
            int bytesRead = stream.Read(dataFromClient, 0, dataFromClient.Length);
            string s = Encoding.ASCII.GetString(dataFromClient, 0, bytesRead);
            Console.WriteLine(s);

            if (s.Equals("exit"))
            {
                break;
            }

            // respond
            byte[] dataToClient = Encoding.ASCII.GetBytes($"Returning {s}");
            foreach (var networkStream in networkStreams)
            {
               networkStream.Write(dataToClient, 0, dataToClient.Length); 
            }
            
        }
    }

    private static void ConnectClient(TcpListener listener)
    {
        Thread thread = new Thread(() => HandleOneClient(listener));
        thread.Start();
    }
}
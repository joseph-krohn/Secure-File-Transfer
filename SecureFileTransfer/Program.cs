using System;

namespace SecureFileTransfer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose a mode: (1) Server, (2) Client");
            var choice = Console.ReadLine();

            if (choice == "1")
            {
                FileTransferServer server = new FileTransferServer();
                server.Start();
            }
            else if (choice == "2")
            {
                FileTransferClient client = new FileTransferClient();
                client.Start();
            }
            else
            {
                Console.WriteLine("Invalid choice.");
            }
        }
    }
}

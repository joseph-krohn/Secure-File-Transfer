using System;
using System.IO;
using System.Net.Sockets;

namespace SecureFileTransfer
{
    public class FileTransferClient
    {
        private readonly string serverAddress = "127.0.0.1";
        private readonly int port = 8000;

        public void Start()
        {
            Console.WriteLine("Enter the path of the file to send:");
            string filePath = Console.ReadLine();

            if (!File.Exists(filePath))
            {
                Console.WriteLine("File does not exist.");
                return;
            }

            byte[] fileContent = File.ReadAllBytes(filePath);
            byte[] encryptedContent = Encryptor.EncryptFile(fileContent);

            using (TcpClient client = new TcpClient(serverAddress, port))
            using (NetworkStream stream = client.GetStream())
            {
                stream.Write(encryptedContent, 0, encryptedContent.Length);
                Console.WriteLine("File sent securely.");
            }
        }
    }
}

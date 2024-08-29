using System;
using System.IO;
using System.Net;
using System.Net.Sockets;

namespace SecureFileTransfer
{
    public class FileTransferServer
    {
        private readonly int port = 8000;

        public void Start()
        {
            TcpListener listener = new TcpListener(IPAddress.Any, port);
            listener.Start();
            Console.WriteLine("Server started, waiting for file...");

            using (TcpClient client = listener.AcceptTcpClient())
            using (NetworkStream stream = client.GetStream())
            using (MemoryStream ms = new MemoryStream())
            {
                stream.CopyTo(ms);
                byte[] encryptedContent = ms.ToArray();
                byte[] decryptedContent = Encryptor.DecryptFile(encryptedContent);

                File.WriteAllBytes("received_file", decryptedContent);
                Console.WriteLine("File received and decrypted successfully.");
            }
        }
    }
}

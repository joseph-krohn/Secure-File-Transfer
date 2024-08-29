namespace SecureFileTransfer.Models
{
    public class TransferConfig
    {
        public string EncryptionKey { get; set; } = "YourEncryptionKey123";
        public string ServerAddress { get; set; } = "127.0.0.1";
        public int Port { get; set; } = 8000;
    }
}

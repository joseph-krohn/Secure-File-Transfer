# Secure File Transfer in C#

## Overview

This project is a simple yet secure file transfer application written in C#. It allows users to send files securely over a network by encrypting them before transmission and decrypting them on the receiving end. This ensures that the files are protected from unauthorized access during transfer.

## Features

- **AES Encryption:** Files are encrypted using AES encryption to ensure data confidentiality.
- **File I/O:** Efficient file reading and writing operations.
- **Network Sockets:** Utilizes TCP sockets for network communication between the client and server.
- **Error Handling:** Robust error handling to ensure reliability and security during the transfer process.

## Requirements

- **.NET Core SDK** - [Download and install](https://dotnet.microsoft.com/download)

## How to Use

1. **Clone the Repository:**

    ```bash
    git clone https://github.com/yourusername/SecureFileTransfer.git
    ```

2. **Navigate to the project directory:**

    ```bash
    cd SecureFileTransfer
    ```

3. **Build the Solution:**

    ```bash
    dotnet build
    ```

4. **Run the Server:**

    ```bash
    dotnet run --project SecureFileTransfer/SecureFileTransfer.csproj
    ```

    Choose the `Server` mode when prompted.

5. **Run the Client:**

    ```bash
    dotnet run --project SecureFileTransfer/SecureFileTransfer.csproj
    ```

    Choose the `Client` mode when prompted and provide the file path of the file you want to send.

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## Contributing

Feel free to submit issues, fork the repository, and make pull requests. Contributions are always welcome!

## Author

**Joseph Krohn** - [Your GitHub Profile](https://github.com/yourusername)

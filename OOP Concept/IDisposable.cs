// The IDisposable interface in C# provides a standard way to release unmanaged resources like file handles, database connections, or network sockets.

using System;
using System.IO;

public interface IDisposable  //in C# interface names starts with capital I (it's a norm or coding standard)
{
    void Dispose();
}

class FileHandler : IDisposable {
    private StreamReader reader;

    public FileHandler(string path) {
        reader = new StreamReader(path);
        Console.WriteLine("File opened.");
    }

    public void ReadFile() {
        Console.WriteLine(reader.ReadLine());
    }

    // Implementation of Dispose method
    public void Dispose() {
        if (reader != null) {
            reader.Close();
            Console.WriteLine("File closed.");
        }
    }
}

class Program {
    public static void Main() {
        FileHandler fh = new FileHandler("test.txt");
        fh.ReadFile();
        fh.Dispose(); // Explicit call

        //Alternative method Using 'using' keyword

        using (StreamReader reader = new StreamReader("test.txt")) {
            Console.WriteLine(reader.ReadLine());
        } // Dispose() is called automatically here
    }
}
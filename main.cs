using System;
using System.IO;

namespace MaliciousApp
{
    class Program
    {
        static void Main()
        {
            string message = "Malicious code executed!";
            File.WriteAllText("malicious.txt", message);
        }
    }
}

using System;
using Sharp7;

namespace S7
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new S7Client();
            int result = client.ConnectTo("127.0.0.1", 0, 1);
            if (result == 0)
            {
                Console.WriteLine("Connected to 127.0.0.1");
            }
            else
            {
                Console.WriteLine(client.ErrorText(result));
            }
            Console.Read();


            // Disconnect the client
          //  client.Disconnect();
        }
    }
}

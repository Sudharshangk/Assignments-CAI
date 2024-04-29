using System;

class ReverseHello
{
    static void Main()
    {
        string message = "Hello World!!";

        // Loop through the message in reverse order
        for (int i = message.Length - 1; i >= 0; i--)
        {
            Console.WriteLine(message[i]);
        }
    }
}
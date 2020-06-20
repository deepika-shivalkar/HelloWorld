using System;

namespace HelloWorld
{
    public class MessageGenerator
    {
        static void Main(string[] args)
        {

            string message= displayMessage();
            Console.WriteLine(message);
        }

        public static string displayMessage()
        {
            string message = "Hello world!";
            return message;
        }
    }
}

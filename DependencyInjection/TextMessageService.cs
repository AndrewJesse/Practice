using System;

namespace DependencyInjectionExample
{
    public class TextMessageService : IMessageService
    {
        public void SendMessage(string message)
        {
            Console.WriteLine($"Sending text message: {message}");
        }
    }
}

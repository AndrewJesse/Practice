using System;

namespace DependencyInjectionExample
{
    public class EmailService : IMessageService
    {
        public void SendMessage(string message)
        {
            Console.WriteLine($"Sending email: {message}");
        }
    }
}

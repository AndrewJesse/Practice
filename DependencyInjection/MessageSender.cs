namespace DependencyInjectionExample
{
    public class MessageSender
    {
        private readonly IMessageService _messageService;

        public MessageSender(IMessageService messageService)
        {
            _messageService = messageService;
        }

        public void Send(string message)
        {
            _messageService.SendMessage(message);
        }
    }
}

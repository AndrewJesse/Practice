using Microsoft.Extensions.DependencyInjection;
using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Setup Dependency Injection Container
            var serviceProvider = new ServiceCollection()
                .AddSingleton<IMyService, MyService>()
                .AddSingleton<Program>()
                .BuildServiceProvider();

            // Get instance of Program and execute method
            serviceProvider.GetService<Program>().Run();
        }
        // Declares a private field named _myService of type IMyService, which will hold an instance of a class that implements the IMyService interface.
        private readonly IMyService _myService;

        // Constructor for the Program class that takes an instance of IMyService as a parameter and assigns it to the _myService field. This constructor is used by the dependency injection container to inject an instance of IMyService into the Program class.
        public Program(IMyService myService) => _myService = myService;


        public void Run() => Console.WriteLine(_myService.GetMessage());
    }
}

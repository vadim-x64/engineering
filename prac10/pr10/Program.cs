using System;
using System.Text;
using Xunit;

namespace pr10
{
    public class Program
    {
        // Task1 - SoC (Separation of Concerns)

        // До рефакторингу

        //public static void Main(string[] args)
        //{
        //    OrderProcessor orderProcessor = new OrderProcessor();
        //    orderProcessor.ProcessOrder("Ноутбук");
        //}


        // Після рефакторингу

        //public static void Main(string[] args)
        //{
        //    Console.OutputEncoding = Encoding.UTF8;
        //    Console.InputEncoding = Encoding.UTF8;

        //    OrderRepository orderRepository = new OrderRepository();
        //    EmailService emailService = new EmailService();

        //    OrderProcessor orderProcessor = new OrderProcessor(orderRepository, emailService);
        //    orderProcessor.ProcessOrder("Ноутбук");
        //    orderProcessor.ProcessOrder("Мишка");
        //    orderProcessor.ProcessOrder("Навушники");
        //}

        // Task2 - Modularity
        //public static void Main(string[] args)
        //{
        //    Console.OutputEncoding = Encoding.UTF8;
        //    Console.InputEncoding = Encoding.UTF8;

        //    IBookRepository storage = new BookDb();
        //    ILibraryService service = new LibraryService(storage);

        //    UserInterface userInterface = new UserInterface(service);
        //    userInterface.Start();
        //}

        // Task3 - Abstraction
        //public static void Main(string[] args)
        //{
        //    Console.OutputEncoding = Encoding.UTF8;
        //    Console.InputEncoding = Encoding.UTF8;

        //    Vehicle myCar = new Car();
        //    Vehicle myBike = new Bicycle();

        //    myCar.Start();
        //    myCar.Stop();

        //    myBike.Start();
        //    myBike.Stop();
        //}

        // Task 4 - Information Hiding
        //public static void Main(string[] args)
        //{
        //    Console.OutputEncoding = Encoding.UTF8;
        //    Console.InputEncoding = Encoding.UTF8;

        //    Vehicle myCar = new Car();
        //    Vehicle myBike = new Bicycle();

        //    myCar.Start();
        //    Console.WriteLine($"Швидкість авто: {myCar.Speed} км/год.");
        //    myCar.Stop();
        //    Console.WriteLine($"Швидкість авто: {myCar.Speed} км/год.");

        //    Console.WriteLine();

        //    myBike.Start();
        //    Console.WriteLine($"Швидкість велосипеда: {myBike.Speed} км/год.");
        //    myBike.Stop();
        //    Console.WriteLine($"Швидкість авто: {myBike.Speed} км/год.");
        //}
    }
}
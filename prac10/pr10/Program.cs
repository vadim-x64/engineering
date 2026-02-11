using pr10.task2.Data;
using pr10.task2.Interfaces;
using pr10.task2.Services;
using pr10.task2.UI;
using System.Text;

namespace pr10.task2
{
    public class Program
    {
                                                    // Task1 - до рефакторингу
        /*
        public static void Main(string[] args)
        {
            OrderProcessor orderProcessor = new OrderProcessor();
            orderProcessor.ProcessOrder("Ноутбук");
        }
        */

                                                    // Task1 - після рефакторингу
        /*public static void Main(string[] args)
        {
            OrderRepository orderRepository = new OrderRepository();
            EmailService emailService = new EmailService();

            OrderProcessor orderProcessor = new OrderProcessor(orderRepository, emailService);
            orderProcessor.ProcessOrder("Ноутбук");
        }*/

                                                    // Task2
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            IBookRepository storage = new BookDb();
            ILibraryService service = new LibraryService(storage);
            UserInterface userInterface = new UserInterface(service);
            userInterface.Start();
        }
    }
}
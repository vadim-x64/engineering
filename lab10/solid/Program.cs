using System.Text;

namespace solid
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            
            string message = "Hello SOLID!";

            ILogger logger = new Logger();
            INotificationRepository repo = new NotificationRepository();
            INotificationSender emailSender = new EmailSender();

            NotificationService emailService = new NotificationService(emailSender, repo, logger);
            emailService.ProcessNotification(message);

            INotificationSender telegramSender = new TelegramSender();
            NotificationService telegramService = new NotificationService(telegramSender, repo, logger);
            telegramService.ProcessNotification(message);

            INotificationSender pushSender = new PushSender();
            NotificationService pushService = new NotificationService(pushSender, repo, logger);
            pushService.ProcessNotification(message);

            INotificationSender smsSender = new SmsSender();
            NotificationService smsService = new NotificationService(smsSender, repo, logger);
            smsService.ProcessNotification(message);
        }
    }
}
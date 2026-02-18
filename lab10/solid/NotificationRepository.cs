namespace solid
{
    public class NotificationRepository : INotificationRepository
    {
        public void Save(string message)
        {
            Console.WriteLine($"Збереження в БД: {message}");
        }
    }
}
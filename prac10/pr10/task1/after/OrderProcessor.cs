namespace pr10.task1.after
{
    public class OrderProcessor
    {
        private OrderRepository _orderRepository;
        private EmailService _emailService;

        public OrderProcessor(OrderRepository orderRepository, EmailService emailService)
        {
            _orderRepository = orderRepository;
            _emailService = emailService;
        }

        public void ProcessOrder(string item)
        {
            _orderRepository.SaveToDb(item);
            _emailService.SendEmail(item);
        }
    }
}
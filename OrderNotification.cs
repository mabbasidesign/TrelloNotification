using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace TrelloNotification
{
    public class OrderNotification
    {
        private readonly ILogger _logger;

        public OrderNotification(ILoggerFactory loggerFactory)
        {
            _logger = loggerFactory.CreateLogger<OrderNotification>();
        }

        [Function("OrderNotification")]
        public void Run(
            [ServiceBusTrigger("orders", Connection = "ServiceBusConnection")] string message,
            FunctionContext context)
        {
            _logger.LogInformation($"Received Service Bus message: {message}");
            // Your logic here (e.g., call OrderServiceUrl, process event, etc.)
        }
    }
}

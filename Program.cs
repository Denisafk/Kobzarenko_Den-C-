using System.Text;

namespace DeliveryService
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            Bike bike = new Bike();
            Car car = new Car();
            Truck truck = new Truck();

            List<Transport> transports = new List<Transport>()
            {
                bike,
                car,
                truck
            };

            Console.WriteLine("--- Доступні транспортні засоби ---");

            foreach (var transport in transports)
            {
                Console.WriteLine($"{transport.GetType().Name}");
            }

            Console.WriteLine();

            Order order1 = new Order(121, "Чайник", 5, 8);
            Order order2 = new Order(222, "Стіл", 20, 12);
            Order order3 = new Order(361, "Ванна", 80, 15);

            List<Order> activeOrders = new List<Order>();
            List<Order> history = new List<Order>();

            IPayment cardPayment = new CardPayment();
            IPayment cashPayment = new CashPayment();
            Console.WriteLine("--- Оплата карткою ---");

            DeliveryService cardService = new DeliveryService(
                transports,
                activeOrders,
                history);

            cardService.ProcessOrder(order1, cardPayment);
            cardService.ProcessOrder(order2, cardPayment);
            cardService.ProcessOrder(order3, cardPayment);

            Console.WriteLine();

            Console.WriteLine("--- + замовлення ---");

            Order order4 = new Order(431, "Монітор", 8, 5);

            cardService.ProcessOrder(order4, cardPayment);

            Console.WriteLine();

            Console.WriteLine("--- Активні замовлення ---");

            foreach (var order in cardService.GetActiveOrders())
            {
                Console.WriteLine(
                    $"Замовлення №{order.Id} - {order.ItemName}");
            }

            Console.WriteLine();

            Console.WriteLine("--- Завершення замовлень ---");

            cardService.CompleteOrder(order1, bike);
            cardService.CompleteOrder(order2, car);
            cardService.CompleteOrder(order3, truck);

            Console.WriteLine();

            Console.WriteLine("--- Історія замовлень --- ");

            foreach (var order in cardService.GetHistory())
            {
                Console.WriteLine(
                    $"Замовлення №{order.Id} - {order.ItemName}");
            }

            Console.WriteLine();

            Console.WriteLine("--- Оплата готівкою ---");

            Order order5 = new Order(509, "Принтер", 10, 7);

            DeliveryService cashService = new DeliveryService(
                transports,
                activeOrders,
                history);

            cashService.ProcessOrder(order5, cashPayment);

            cashService.CompleteOrder(order5, bike);

            Console.WriteLine();

            Console.WriteLine("--- Історія замовлень ---");

            foreach (var order in cashService.GetHistory())
            {
                Console.WriteLine(
                    $"Замовлення №{order.Id} - {order.ItemName}");
            }
        }
    }
}
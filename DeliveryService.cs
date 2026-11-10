namespace DeliveryService
{
    internal class DeliveryService
    {
        private List<Order> activeOrders;
        private List<Order> history;
        private List<Transport> transports;

        public bool IsAvaible(Transport transports)
        {
            return !transports.IsBusy;
        }

        public DeliveryService(List<Transport> transports, List<Order> activeOrders,List<Order> history)
        {
            this.transports = transports;
            this.activeOrders = activeOrders;
            this.history = history;
        }
        public void ProcessOrder(Order order, IPayment paymentMethod)
        {
            Console.WriteLine($"Можливі варіанти для замовлення {order.Id}:");

            foreach (var transport in transports)
            {
                if (transport.CanTake(order))
                {
                    Console.WriteLine(
                        $"{transport.GetType().Name} - {transport.CalculateCost(order)} грн");
                }
            }
            Transport selectedTransport = null;
            foreach (var transport in transports)
            {
                if (transport.CanTake(order) && IsAvaible(transport))
                {
                    selectedTransport = transport;
                  
                    break;
                }
            
            }
            if (selectedTransport == null)
            {
                Console.WriteLine("Немає доступного транспорту для цього замовлення.");
                return;
            }
            activeOrders.Add(order);     
            selectedTransport.IsBusy = true;
            decimal cost = selectedTransport.CalculateCost(order);
            Console.WriteLine($"Замовлення {order.Id} - Вартість доставки: {cost} грн, Транспорт доставки: {selectedTransport.GetType().Name}");
            paymentMethod.ProcessPayment(cost);
        }
        public void CompleteOrder(Order order,Transport transport)
        {
            if (activeOrders.Contains(order))
            {             
                activeOrders.Remove(order);       
                history.Add(order);
                transport.IsBusy = false;
                Console.WriteLine($"Замовлення {order.Id} завершено, транспорт {transport.GetType().Name} вільний.");
            }
            else
            {
                Console.WriteLine($"Замовлення {order.Id} не знайдено серед активних замовлень.");
            }
        }
        public List<Order> GetActiveOrders()
        {
            Console.WriteLine($"Активні замовлення: {activeOrders.Count}");
            return activeOrders;
        }
        public List<Order> GetHistory()
        {
            Console.WriteLine($"Історія замовлень: {history.Count}");
            return history;
            
        }
    }
}


namespace DeliveryService
{
    internal class Car : Transport
    {
        public Car()
        {
            MaxWeight = 50;
 
        }
        public override decimal CalculateCost(Order order)
        {
            return 50 + (8 * order.Range) + (1 * order.Weight);
        }

    }
}

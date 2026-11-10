namespace DeliveryService
{
    internal class Truck : Transport
    {
        public Truck()
        {
            MaxWeight = 100;
        }

        public override decimal CalculateCost(Order order)
        {
            return 200 + (15 * order.Range) + (0.5m * order.Weight);
        }
    }
}

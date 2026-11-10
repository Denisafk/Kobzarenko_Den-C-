namespace DeliveryService
{
    internal class Bike : Transport
    {
        public Bike()
        {
            MaxWeight = 10;
        }
        public override bool CanTake(Order order)
        {
            if (order.Range > 10 || order.Weight > MaxWeight)
            {
                return false;
            }

            return true;
        }

        public override decimal CalculateCost(Order order)
        {
            return 20 + (5 * order.Range);
        }
    }
}
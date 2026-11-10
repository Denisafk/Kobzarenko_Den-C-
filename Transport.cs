namespace DeliveryService
{
    abstract class Transport
    {
        private bool _isBusy;
        private decimal _maxWeight;
        public bool IsBusy
        {
            get { return _isBusy; }
            set { _isBusy = value; }
        }
        public decimal MaxWeight
        {
            get { return _maxWeight; }
            set { _maxWeight = value; }
        }
        abstract public decimal CalculateCost(Order order);

        virtual public bool CanTake(Order order)
        {

            return order.Weight <= MaxWeight;
        }


    }
}

namespace DeliveryService
{
    internal class Order
    {
        
        private int _id;
        private string _itemName;
        private decimal _weight;
        private decimal _range;
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string ItemName
        {
            get { return _itemName; }
            set { _itemName = value; }
        }
        public decimal Weight
        {
            get { return _weight; }
            set { _weight = value; }
        }
        public decimal Range
        {
            get { return _range; }
            set { _range = value; }
        }
        public bool CanTake(Transport transport)
        {
            return transport.CanTake(this);
        }
        public Order(int id, string itemName, decimal weight, decimal range)
        {
            _id = id;
            _itemName = itemName;
            _weight = weight;
            _range = range;
        }
    }
    
}

namespace DeliveryService
{
    internal class CardPayment : IPayment
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Оплата карткою: {amount} грн");
        }
    }
}

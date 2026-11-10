namespace DeliveryService
{
    internal class CashPayment : IPayment
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Оплата готівкою: {amount + 70} грн (додатково 70 грн готівковий платіж)");
        }
    }

}

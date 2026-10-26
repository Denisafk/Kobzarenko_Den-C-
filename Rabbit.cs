namespace Hunter_game
{
    internal class Rabbit
    {

        public HP RabbitHealth = new HP(50);
        public void TakeDamage(int damage)
        {
            if (damage < 0)
            {
                throw new ArgumentException("Damage cannot be negative.");
            }
            RabbitHealth.TakeDamage(damage);
        }
    }
}

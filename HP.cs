namespace Hunter_game
{
    internal class HP
    {
        private int _health;
        public int Health
        {
            get { return _health; }
        }
        public HP(int health)
        {
            _health = health;
            if (health < 0)
            {
                throw new ArgumentException("Health cannot be negative.");
            }
        }

        public void Die()
        {    
            
            Console.WriteLine("Тварина померла");
              
        }
        public void TakeDamage(int damage)
        {
            if(damage <= 0)
            {
                throw new ArgumentException("Damage cannot be negative.");
            }
            _health -= damage;
            if (_health < 0)
            {
                _health = 0;
            }
            if (_health <= 0)
            {
                Die();
            }
        }

    }
}

namespace Hunter_game
{
    internal class Hunter
    {
        private Gold _gold;
        private int _rabbits;
        private HP _health;
        private Arrow _arrows;
        private Rabbit _rabbit;
        public int Rabbits
        {
            get { return _rabbits; }
        }
        public Hunter()
        {
            _arrows = new Arrow(5);
            _health = new HP(100);
            _gold = new Gold(30);
        }
        public void Hunt()
        {
            if (_arrows.Arrows > 0)
            {
                _arrows.ShootArrow(1);
                Console.WriteLine("Ви стріляєтє...");            
                int damage =30;
                _rabbit.TakeDamage(damage);
                Console.WriteLine($"Ви завдали {damage} шкоди зайцю.");
                Console.WriteLine($"Здоров'я зайця: {_rabbit.RabbitHealth.Health}");
            }
            else
            {
                Console.WriteLine("У вас немає стріл!");
            }
        }
        public void HuntRabbit()
        {
            Console.WriteLine("Ви йдете на полювання...");
            _rabbit = new Rabbit();
            Console.WriteLine("Ви зустріли зайця!");
            while (_rabbit.RabbitHealth.Health > 0)
            {
                if (_arrows.Arrows <= 0)
                {
                    Console.WriteLine("Стріли закінчилися!");
                    break;
                }
                Hunt();
                if (_rabbit.RabbitHealth.Health <= 0)
                {
                    _rabbits++;
                    Console.WriteLine("Ви вбили зайця!");               
                    break;
                }
            }
        }
        public void VisitShop()
        {
            Console.WriteLine("Ви відвідуєте магазин.");
            Console.WriteLine($"У вас є {_gold.GetGold()} золота.");
            Console.WriteLine("1. Купити 5 стріл за 10 золота");
            Console.WriteLine("2. Продати зайця за 15 золота");
            Console.WriteLine("3. Вийти з магазину");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    if (_gold.SpendGold(10))
                    {
                        _arrows.AddArrows(5);
                        Console.WriteLine("Ви купили 5 стріл.");
                    }
                    else
                    {
                        Console.WriteLine("Недостатньо золота!");
                    }
                    break;
                case "2":
                    if (_rabbits > 0)
                    {                   
                        _rabbits--;
                        _gold.AddGold(15);
                        Console.WriteLine("Ви продали зайця за 15 золота.");
                    }
                    else
                    {
                        Console.WriteLine("У вас немає зайців для продажу!");
                    }
                    break;
                case "3":
                    Console.WriteLine("Ви виходите з магазину.");
                    break;
                default:
                    Console.WriteLine("Невірний вибір!");
                    break;
            }
        }
        public void ShowStats()
        {
            Console.WriteLine($"Здоров'я: {_health.Health}");
            Console.WriteLine($"Стріли: {_arrows.Arrows}");
            Console.WriteLine($"Вбито зайців: {_rabbits}");
            Console.WriteLine($"Золото: {_gold.GetGold()}");
            
        }
    }
}

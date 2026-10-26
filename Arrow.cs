namespace Hunter_game
{
    internal class Arrow
    {
        private int _arrows;

        public int Arrows
        {
            get { return _arrows; }
        }
        public Arrow(int arrows)
        {
            _arrows = arrows;
            if (arrows < 0)
            {
                throw new ArgumentException("Arrows cannot be negative.");
            }
        }

        public void ShootArrow(int amount)
        {
            if (amount < 0)
            {
                throw new ArgumentException("Amount cannot be negative.");
            }
            if (_arrows >= amount)
            {
                _arrows -= amount;
            }
            else
            {
                Console.WriteLine("Недостатньо стріл!");
            }
        }
        public void AddArrows(int amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Amount must be positive.");
            }

            _arrows += amount;
        }


    }
}

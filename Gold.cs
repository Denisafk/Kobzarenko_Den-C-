namespace Hunter_game
{
    internal class Gold
    {
        private int _gold;

        public Gold(int gold)
        {
            _gold = gold;
        }

        public void AddGold(int amount)
        {
            _gold += amount;
        }

        public bool SpendGold(int amount)
        {
            if (_gold >= amount)
            {
                _gold -= amount;
                return true;
            }

            return false;
        }

        public int GetGold()
        {
            return _gold;
        }
    }
}

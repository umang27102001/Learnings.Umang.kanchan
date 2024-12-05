namespace AccessModifier
{
    public class AccessModifier
    {
        private int _value;
        private int _money;
        protected int coins;
        public int Coins
        {
            get => this.coins;
            set
            {
                this.coins = value;
            }
        }
        public int Money
        {
            get => this._money;
            set
            {
                this._money = value;
            }
        }
        public void Set(int a)
        {
            this._value = a;
        }
        public int Get()
        {
            return this._value;
        }
    }
}

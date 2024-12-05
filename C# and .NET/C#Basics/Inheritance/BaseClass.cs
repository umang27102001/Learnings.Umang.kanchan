namespace Inheritance
{
    public class BaseClass
    {
        public BaseClass()
        {
            Console.WriteLine("Inside BaseClass");
        }
        private int _marks;
        public int Marks
        {
            set { this._marks = value; }
            get => this._marks;
        }
        protected private int _money;
        public int Money
        {
            get => this._money;
            set => this._money = value;
        }
    }
}

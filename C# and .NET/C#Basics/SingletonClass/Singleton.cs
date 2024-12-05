namespace SingletonClass
{
    public class Singleton
    {
        private string _name;
        public string Name
        {
            set { this._name = value; }
            get => this._name;
        }
        public static Singleton ptr = null;
        private Singleton(string name)
        {
            this._name = name;
        }
        public static Singleton CreateObj(string name)
        {
            if (ptr == null)
            {
                ptr = new Singleton(name);
            }
            return ptr;
        }
    }
}

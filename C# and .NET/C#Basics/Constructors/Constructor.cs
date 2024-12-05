
namespace Constructors
{
    internal class Constructor
    {
        private string _name;
        public Constructor() {
            this._name = "umang";
            Console.WriteLine("Hello, this is Default Constructor!!");
        }
        public Constructor(string name) {
            this._name = name;
            Console.WriteLine("Hello, this is parameterized Constructor!!");
        }
        public Constructor(Constructor obj)
        {
            this._name=obj._name; 
            Console.WriteLine("Hello, this is copy Constructor!!");
        }
        public string GetName()
        {
            return this._name;
        }
        public void SetName(string name)
        {
            this._name = name;
        }
    }
}

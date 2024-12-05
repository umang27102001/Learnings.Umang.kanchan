namespace Properties
{
    internal class Properties
    {
        private string _name;
        //Defining a public property as an accessor to access the private field.
        public string Name
        {
            get => this._name;
            set => this._name = value;
        }
        public int Prop
        {
            get;
            set;
        }

       
    }
}

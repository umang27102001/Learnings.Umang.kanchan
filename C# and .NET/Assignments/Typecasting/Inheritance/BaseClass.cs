using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Basics.Inheritance
{
    internal class BaseClass
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

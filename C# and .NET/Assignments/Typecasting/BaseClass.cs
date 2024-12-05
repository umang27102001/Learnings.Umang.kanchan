using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Typecasting
{
    public class BaseClass
    {
        private string _baseClassName;
        public string BaseClassName
        {
            get => this._baseClassName;
            set => this._baseClassName = value;
        }
        virtual public void MethodA()
        {
            Console.WriteLine("Base Class MethodA ");
        }
    }
}

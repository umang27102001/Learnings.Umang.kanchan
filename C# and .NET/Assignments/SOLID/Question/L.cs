using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Question
{
    /* QUESTION
     * How are we breaking the LSP here ?
     * LSP states that behavior of classes should not change even if we substitute the child class in parent class. Such that intended result is achieved.
     * Answer:
     * Here Motorcyle class inherits Car class and it overrides the GetTyreCount() method now since the method is 
     * overridden, the child class has changed the behavior of the parent class and the parent class can not be replaced by the child class' instance as it has different behavior
     * Solution to this problem is shown in LSol.cs file
     * 
     */
    public class Car
    {
        public virtual int GetTyreCount()
        {
            return 4;
        }
    }

    public class Motorcycle : Car
    {
        public override int GetTyreCount()
        {
            return 2;
        }
    }
}
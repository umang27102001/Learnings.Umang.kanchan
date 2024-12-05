
using SOLID.Solution;
using System;
namespace SOLID
{
    class Program
    {
        static void Main(string[] args)
        {
            IVehicle car = new MotorCycle();
            Console.WriteLine(car.GetTyreCount());
        }
    }
}

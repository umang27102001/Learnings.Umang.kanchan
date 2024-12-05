using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Solution
{
    public interface IVehicle
    {
        public int GetTyreCount();
    }
    public class Car : IVehicle
    {
        public int GetTyreCount()
        {
            return 4;
        }

        public static implicit operator Car(MotorCycle v)
        {
            throw new NotImplementedException();
        }
    }
    public class MotorCycle : IVehicle
    {
        public int GetTyreCount()
        {
            return 2;
        }
    }
}

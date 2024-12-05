namespace Datatypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataTypes nc = new DataTypes();
            nc.GetDefaultValues();
            nc.SetValues();
            nc.GetDefaultValues();
            Console.ReadLine();
            nc.Result = 0;
            Console.WriteLine(nc.Result);
        }
    }
}

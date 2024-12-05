namespace IComparer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car[] cars = new Car[]
            {
                new Car {Name = "BMW RS",Price=12345543,Type="Special"},
                new Car {Name = "Mazda Meridian",Price=3234553,Type="SUV"},
                new Car {Name = "Baleno",Price=112233,Type="Sedan"},
                new Car {Name = "Rolls-Royce",Price=123452543,Type="Xtra-Special"}
            };
            Array.Sort(cars,new Comparer());
            foreach (Car car in cars)
            {
                Console.WriteLine(car.ToString());
            }
        }
    }
}

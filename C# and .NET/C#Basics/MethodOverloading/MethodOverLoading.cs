namespace Overloading
{
    internal class MethodOverLoading
    {
        public void Print(byte x,byte y,byte z)
        {
            Console.WriteLine($"{x} {y} {z}");
        }
        public void Print(byte a,byte b)
        {
            Console.WriteLine($"The sum is {a+b}");
        }
    }
}

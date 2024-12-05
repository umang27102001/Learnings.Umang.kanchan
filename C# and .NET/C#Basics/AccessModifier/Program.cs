namespace AccessModifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AccessModifier am = new AccessModifier();
            am.Coins = 10;
            Console.WriteLine(am.Coins);
        }
    }
}

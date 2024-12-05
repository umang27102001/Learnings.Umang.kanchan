namespace TryCatchFinally
{
    internal class HandleException
    {
        public void Run()
        {
            byte a = 10;
            try
            {
                int b = a / 0;
            }
            catch(ArithmeticException exp)
            {
                Console.WriteLine($"ArithmeticException: {exp.Message}");
                throw;
            }
            finally
            {
                Console.WriteLine("Hello I will get executed at any cost .");
            }
        }
    }
}

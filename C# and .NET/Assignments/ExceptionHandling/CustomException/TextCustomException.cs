
namespace CustomException
{
    internal class TextCustomException
    {
        public void Run()
        {
            try
            {
                throw new CustomException("OOps!! Some Custom Exception Occured!");
            }
            catch(CustomException exp) {
                Console.WriteLine($"Custom Exception: {exp.Message}");
                throw exp;
            }
        }
    }
}
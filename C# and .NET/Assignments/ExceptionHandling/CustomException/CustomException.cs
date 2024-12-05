namespace CustomException
{
    internal class CustomException:Exception
    {
        public CustomException():base("Custom Exception occured!!") { }
        public CustomException(string message):base(message) 
        {
        
        }
    }
}

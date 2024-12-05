namespace MultipleCatches
{
    public class MultipleCatchesClass
    {
        public void Run()
        {
            byte[] arr = { 1, 2, 3 };
            for(int i = 0; i <= arr.Length; i++)
            {
                try
                {
                    int a = arr[i] / 0;
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Can not divideby 0");
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Index out of range");
                }
            }
        }
    }
}

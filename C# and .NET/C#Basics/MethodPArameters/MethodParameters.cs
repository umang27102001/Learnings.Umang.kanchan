namespace MethodPArameters
{
    internal class MethodParameters
    {
        public void NamedParams(byte a,byte b,byte c)
        {
            Console.WriteLine(a+" "+b+" "+c);
        }
        public void RefParams(ref byte a,ref byte b)
        {
            byte temp = a;
            a = b;
            b = temp;
        }
        public void OutParams(out byte a)
        {
            a = 10;
        }
        public void DefaultParams(byte a = 10,string name = "umang")
        {
            Console.WriteLine(a+" "+name);
        }
        public void DynamicParams(dynamic val)
        {
            Console.WriteLine(val.GetType());
        }
        public void ParamsParams(params dynamic[] nums)
        {
           for(int i=0;i<nums.Length;i++) Console.WriteLine(nums[i]);
        }
    }
}

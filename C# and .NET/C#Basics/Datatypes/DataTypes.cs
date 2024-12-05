

namespace Datatypes
{
    public class DataTypes
    {
        public int Result;
        public string? Name { get; set; }
        public bool isTrue { get; set; }
        public long longNum { get; set; }
        public double doubleVal { get; set; }
        public float floatVal { get; set; }

        public object objVal { get; set; }

        public char charVal { get; set; }

        public void GetDefaultValues()
        {

            if (this.Name==default)
            {
                Console.WriteLine($"The default value of Int32 {this.Name}"); 
            }
            else
            {
                Console.WriteLine($"The value of Int32 {this.Name}"); 
            }
         
        }
        public void SetValues()
        {
            this.Result = 10;
            this.Name = null;
            this.isTrue = true;
            this.doubleVal = 10.05;
            this.floatVal = 20.5F;
            this.objVal = "kanchan";
            this.longNum = 2342312312312;
            this.charVal = '9';
        }
    }
}

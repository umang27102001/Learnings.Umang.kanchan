using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementOperators
{
    public class ElementAt
    {
        public static void Run()
        {
            List<int> ls = new List<int> { 1, 2, 3, 4, 5, 6, 7 };
            try
            {
                int elem = ls.ElementAt(5);
                Console.WriteLine(elem);
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

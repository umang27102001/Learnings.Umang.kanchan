
namespace Strings
{
    internal class Strings
    {
        public void Print()
        {
            var str1 = new char[] { 'u', 'm', 'a', 'n', 'g' };
            string str = new String("umang");
            string ans = "";
            foreach (char ch in str.ToCharArray())
            {
                char temp = ch;
                if (ch != ' ')
                    temp = (char)(ch - 'a' + 'A');
                ans += temp;
            }

            byte num = 10;
            string str7 = num + "";

            string strs = @"""""""""";
            string s1 = "umang";
            s1 += " kanchan";
            string s2 = "umang" + " kanchan";
            string s3 = "hello";
           
            string s4 = new string(s1);
            string s5 = String.Intern(s4);
            Console.WriteLine($"{s1.Equals(s2)} {s1 == s2} {Object.Equals(s1, s2)} {Object.ReferenceEquals(s1, s2)}");
            Console.WriteLine($"{s4.Equals(s5)} {s4 == s5} {Object.Equals(s4, s5)} {Object.ReferenceEquals(s2, s5)}");
        }
    }
}

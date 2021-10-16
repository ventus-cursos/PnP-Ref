using System;

namespace ExtractMethod
{
    internal class Program
    {
        private static void Main()
        {
            Test1A();
            Test1B();
            Test1C();
        }

        //NO
        private static void Test1A()
        {
            var s = "l20";
            int n;
            try
            {
                n = Convert.ToInt32(s);
            }
            catch (FormatException)
            {
                n = 0;
            }
            Console.WriteLine(n);
        }

        //NO
        private static void Test1B()
        {
            var s = "l20";
            int n;
            n = SafeConvert(s);
            Console.WriteLine(n);
        }

        private static int SafeConvert(string s, int defa = 0)
        {
            int n;
            try
            {
                n = Convert.ToInt32(s);
            }
            catch (FormatException)
            {
                n = defa;
            }
            return n;
        }

        private static void Test1C()
        {
            var s = "l20";
            int n;
            Console.WriteLine(int.TryParse(s, out n) ? n : 0);
        }
    }
}

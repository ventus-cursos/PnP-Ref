using System;
using System.Linq;

namespace InlineTemp
{
    internal class Program
    {
        private static void Main()
        {
            Test1A();
            Test1B();
        }

        private static void Test1A()
        {
            int p = 123;
            int d = 321;
            var x = p * (45 + d);
            Console.WriteLine(x);
        }

        private static void Test1B()
        {
            var x = 123 * (45 + 321);
            Console.WriteLine(x);
        }

        private static void Test2A()
        {
            var listaCompleta = new int[] { };
            var resultado = listaCompleta
                .Where(o => (o & 1) != 0)
                .OrderBy(o => o)
                .Skip(20)
                .Take(10)
                .ToArray();
            Console.WriteLine(resultado);
        }

        private static void Test2B()
        {
            var listaCompleta = new int[] { };
            var impares = listaCompleta
                .Where(o => (o & 1) != 0);
            var resultado = impares
                .OrderBy(o => o)
                .Skip(20)
                .Take(10)
                .ToArray();
            Console.WriteLine(resultado);
        }

    }
}

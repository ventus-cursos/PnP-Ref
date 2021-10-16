using System;

namespace Ventus
{
    internal static class Program
    {
        private static void Main()
        {
            Test1A(1000m, true);
            Test1B(1000m, true);
        }

        //NO
        private static void Test1A(decimal m, bool f)
        {
            decimal t;
            decimal s;
            decimal i;
            if (f)
            {
                t = m;
                s = m / 1.15m;
                i = t - s;
            }
            else
            {
                s = m;
                i = s * 0.15m;
                t = s + i;
            }
            Console.WriteLine($"{s:C} + {i:C} = {t:C}");
        }

        //YES
        private static void Test1B(decimal monto, bool ivaIncluido)
        {
            decimal total;
            decimal subtotal;
            decimal iva;
            if (ivaIncluido)
            {
                total = monto;
                subtotal = monto / 1.15m;
                iva = total - subtotal;
            }
            else
            {
                subtotal = monto;
                iva = subtotal * 0.15m;
                total = subtotal + iva;
            }
            Console.WriteLine($"{subtotal:C} + {iva:C} = {total:C}");
        }
    }
}

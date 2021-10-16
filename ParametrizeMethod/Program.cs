using System;

namespace ParametrizeMethod
{
    internal class Program
    {
        private static void Main()
        {
            Test1A(false);
        }

        private static void Test1A(bool ivaIncluido)
        {
            var monto = 1000m;
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

namespace Ventus
{
    internal class Program
    {
        private static void Main()
        {
            var a = new[] { 56, 1, 99, 67, 89, 23, 44, 12, 78, 34 };
            Test1A(a);
        }

        private static void Test1A(int[] arr)
        {
            var n = arr.Length;
            for (var i = 0; i < n - 1; i++)
            {
                var k = i;
                for (var j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[k])
                    {
                        k = j;
                    }
                }
                var temp = arr[k];
                arr[k] = arr[i];
                arr[i] = temp;
            }
        }
    }
}

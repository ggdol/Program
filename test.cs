using System;
namespace Program
{
    class Test
    {
        static void Main(string[] args)
        {
            foreach (var n in NaturalNumbers())
            {
                Console.Write(n + " ");
            }
        }
        public static IEnumerable<long> NaturalNumbers()
        {
            long n = 0;
            while (n < long.MaxValue)
            {
                yield return n;
                n += 1;
            }
        }
    }
}
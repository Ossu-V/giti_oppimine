using System.Diagnostics.Metrics;
using System.Numerics;

namespace Ruut
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta ruudu suurus:");
            //teha for loopiga ruut
            int size = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 0; i < size; i++)
            {
                for (global::System.Int32 j = 0; j < size; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            
            //kui suurus on sisestatud, siis kuvab meile ka ümbermõõdu ja pindala

            int area = size * size;
            int around = 4 * size;

            Console.WriteLine("Ruudu pindala on: " + area);
            Console.WriteLine("Ruudu ümbermõõt on: " + around);
        }
    }
}
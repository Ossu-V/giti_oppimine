namespace ForLoopArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("-------------");

            //vaja teha string array H, e, l, l, o
            //kasutada for loopi

            string[] array = { "H", "e", "l", "l", "o" };

            for (int i = 0; i < array.Length ; i++)
            {
                Console.WriteLine(array[i]);
            }

            Console.WriteLine("-------------");
            //kasutage nüüd foreach-i
            string[] array2 = { "H", "e", "l", "l", "o" };
            foreach (string i in array)
            {
                Console.WriteLine(i);
            }
        }
    }
}

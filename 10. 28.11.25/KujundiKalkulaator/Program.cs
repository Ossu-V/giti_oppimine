namespace KujundiKalkulaator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //Ruudu sees asub ring. Ringi raadius on 3 ühikut.
            //Leia ja väljasta ekraanile ruudu pindala ja ümbermõõt

            int roundRadious = 3;
            int Diameter  = roundRadious * 2;
            double squareArea = Diameter * Diameter;
            double squarePerimeter = 4 * Diameter;

            Console.WriteLine("Ruudu pindala: " + squareArea);
            Console.WriteLine("Ruudu ümbermõõt: " + squarePerimeter);

            //arvutada ringi pindala ja ümbermõõt

            double roundArea = Math.PI * (roundRadious * roundRadious);
            double roundPerimeter = 2 * Math.PI * roundRadious;

            Console.WriteLine("Ringi pindala " + roundArea);
            Console.WriteLine("Ringi ümbermõõt " + roundPerimeter);

        }
    }
}

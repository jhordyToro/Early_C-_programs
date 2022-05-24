namespace SquareArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // rectangle are calc.

            //rectagle values 
            float sideA = 10.15765f;
            int sideB = 20;
            sideB++;
            sideB++;
            sideB--;

            //rectangle are formula is a*b
            float area = sideA * sideB;

            Console.WriteLine("the rectangle area is: " + area);
        }
    }
}
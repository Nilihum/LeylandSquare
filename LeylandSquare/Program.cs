namespace LeylandSquare
{
    class Program
    {
        public static void Main(String[] args)
        {
            bool square;

            for (int i = 0; i <= 100; i++)
            {
                square = isSquare(i);
                Console.WriteLine("Is " + i + " a square number? " + square);
            }
        }


        public static bool isSquare(int input)
        {
            if (input < 0)
            {
                return false;
            }
            else if (Math.Sqrt(input) % 1 == 0)
            {
                return true;
            }

            else
            {
                return false;
            }
        }
    }
}
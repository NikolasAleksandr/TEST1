namespace TEST1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta kujund(twice x2)");
            Console.WriteLine("1. Ruut");
            Console.WriteLine("2. Teemant");
            Console.WriteLine("3. Ristkülik");
            Console.WriteLine("4. Kolmnurk");

            string tehe = Console.ReadLine();

            switch (tehe)
            {
                case "1":
                    Square();
                    break;
                case "2":
                    Diamond();
                    break;
                case "3":
                    Rectangle();
                    break;
                case "4":
                    Triangle();
                    break;
                default:
                    Console.WriteLine("Valikut ei tehtud");
                    break;
            }
        }


        private static void Square()
        {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Ruut");
            Console.WriteLine(number);
            Console.WriteLine("Sisesta ruudu suurus");
            int size = Convert.ToInt32(Console.ReadLine());

            for (int row = 1; row <= size; row++)
            {
                for (int column = 1; column <= size; column++)
                {
                    string mark;
                    if (row == column || row + column <= size + 1)
                    {
                        mark = "*";
                    }
                    else
                    {
                        mark = "*";
                    }
                    Console.Write(mark);
                }
                Console.WriteLine();
            }
        }

        private static void Triangle()
        {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Kolmnurk");
            Console.WriteLine(number);
            Console.WriteLine("Sisesta kolmnurki pikkus: ");
            int Length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sisesta kolmnurki laius: ");
            int Breadth = Convert.ToInt32(Console.ReadLine());
            int spc = Length;

            for (int i = 1; i <= Breadth; i++)
            {
                Console.Write("\n");
                for (int k = spc; k >= 1; k--)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                spc--;
            }
        }

        private static void Diamond()
        {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Teemant");
            Console.WriteLine(number);
            Console.Write("Sisesta teemante raadius: ");
            double row = Convert.ToInt32(Console.ReadLine());
            double Area = Math.PI * row * row;
            int j;
            for (int i = 0; i <= row; i++)
            {
                for (j = 1; j <= row - i; j++)
                {
                    Console.Write(" ");
                }
                for (j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }

            for (int i = (int)(row - 1); i >= 1; i--)
            {
                for (j = 1; j <= row - i; j++)
                {
                    Console.Write(" ");
                }
                for (j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
            Console.WriteLine("Teemante raadius: " + Area);

        }
        private static void Rectangle()
        {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Ristkülik");
            Console.WriteLine(number);
            Console.WriteLine("Sisesta ristkülik pikkus: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sisesta ristkülik laius: ");
            int y = Convert.ToInt32(Console.ReadLine());
            for (int row = 1; row <= x; row++)
            {
                for (int column = 1; column <= y; column++)
                {
                    string mark;
                    if (row == column || row + column <= y + 1)
                    {
                        mark = "*";
                    }
                    else
                    {
                        mark = "*";
                    }
                    Console.Write(mark);
                }
                Console.WriteLine();
            }
        }
    }
}
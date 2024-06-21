namespace Map_Test
{
    internal class Program
    {
        static char[,] map = new char[10, 10];

        static int coordinate_X = 0;
        static int coordinate_Y = 1;
        static void Main(string[] args)
        {
            Console.WriteLine("Press any key to START");
            ConsoleKey ck = Console.ReadKey().Key;
            Console.Clear();
            do
            {
                Print_Map();
                Controll_Settings();
                Console.Clear();
            }
            while (ck != ConsoleKey.Q);

            Console.ReadLine();
        }
        public static void Controll_Settings()
        {
            ConsoleKey ck = Console.ReadKey().Key;
            switch (ck)
            {
                case ConsoleKey.UpArrow:
                    if (--coordinate_X == -1)
                    {
                        coordinate_X = map.GetLength(0) -1;

                    }
                    break;
                case ConsoleKey.DownArrow:
                    if (++coordinate_X == map.GetLength(0))
                    {
                        coordinate_X = 0;
                    }
                    break;
                case ConsoleKey.LeftArrow:
                    if (--coordinate_Y == -1)
                    {
                        coordinate_Y = map.GetLength(1) -1;
                    }
                    break;
                 case ConsoleKey.RightArrow:
                    if(++coordinate_Y == map.GetLength(1))
                    {
                        coordinate_Y = 0;
                    }
                    break;
            }
            
        }
        public static void Print_Map()
        {
            Coordinate_Point_Change();
            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {

                    Console.Write(" " + map[i, j]);

                }
                Console.WriteLine();
            }
        }
        public static void Coordinate_Point_Change()
        {
            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    if (coordinate_X == i && coordinate_Y == j)
                    {
                        map[i, j] = 'X';
                    }
                    else
                    {
                        map[i, j] = '~';
                    }
                    
                }
            }
        }
    }
}

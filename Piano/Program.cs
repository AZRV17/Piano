namespace Piano
{
    internal class Program
    {
        static void ThirdOctava()
        {
            int[] ThirdOctavaArr = new int[]
                { 132, 140, 148, 156, 164, 176, 184, 196, 208, 220, 232, 248 };

            Sound(ThirdOctavaArr);
        }
        static void FourthOctava()
        {
            int[] FourthOctavaArr = new int[]
                { 264, 280, 296, 312, 328, 352, 368, 392, 416, 440, 464, 496 };

            Sound(FourthOctavaArr);
        }

        static void FifthOctava()
        {
            int[] FifthOctavaArr = new int[]
                { 523, 554, 587, 622, 659, 699, 740, 784, 831, 880, 932, 988 };

            Sound(FifthOctavaArr);
        }

        static void Sound(int[] OctavaArr)
        {
            while (true)
            {
                ConsoleKeyInfo note = Console.ReadKey(true);
                switch (note.Key)
                {
                    case ConsoleKey.A:
                        Console.Beep(OctavaArr[0], 200);
                        break;
                    case ConsoleKey.W:
                        Console.Beep(OctavaArr[1], 200);
                        break;
                    case ConsoleKey.S:
                        Console.Beep(OctavaArr[2], 200);
                        break;
                    case ConsoleKey.E:
                        Console.Beep(OctavaArr[3], 200);
                        break;
                    case ConsoleKey.D:
                        Console.Beep(OctavaArr[4], 200);
                        break;
                    case ConsoleKey.R:
                        Console.Beep(OctavaArr[5], 200);
                        break;
                    case ConsoleKey.F:
                        Console.Beep(OctavaArr[6], 200);
                        break;
                    case ConsoleKey.T:
                        Console.Beep(OctavaArr[7], 200);
                        break;
                    case ConsoleKey.G:
                        Console.Beep(OctavaArr[8], 200);
                        break;
                    case ConsoleKey.Y:
                        Console.Beep(OctavaArr[9], 200);
                        break;
                    case ConsoleKey.H:
                        Console.Beep(OctavaArr[10], 200);
                        break;
                    case ConsoleKey.U:
                        Console.Beep(OctavaArr[11], 200);
                        break;
                }
                if (note.Key == ConsoleKey.Escape) break;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Выберите октаву(F3-F5)");
            ConsoleKeyInfo Octava = Console.ReadKey(true);
            if (Octava.Key == ConsoleKey.F3)
            {
                Console.WriteLine("Третья октава");
                ThirdOctava();
            }
            else if (Octava.Key == ConsoleKey.F4)
            {
                Console.WriteLine("Четвертая октава");
                FourthOctava();
            }
            else if (Octava.Key == ConsoleKey.F5)
            {
                Console.WriteLine("Вторая октава");
                FifthOctava();
            }
            else Console.WriteLine("Ошибка");

        }
    }
}
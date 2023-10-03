namespace Piano
{
    internal class Program
    {
        public static int[] Ton(System.ConsoleKeyInfo key, int[] oct1)
        {
            switch (key.Key)
            {
                case ConsoleKey.F2:
                    Console.WriteLine("2 октава");
                    oct1 = new int[12] { 65, 69, 73, 77, 82, 87, 92, 98, 103, 110, 116, 123 };
                    break;
                case ConsoleKey.F3:
                    Console.WriteLine("3 октава");
                    oct1 = new int[12] { 130, 138, 146, 155, 164, 174, 185, 196, 207, 220, 233, 246 };
                    break;
                case ConsoleKey.F4:
                    Console.WriteLine("4 октава");
                    oct1 = new int[12] { 261, 277, 293, 311, 329, 349, 370, 392, 415, 440, 466, 493 };
                    break;
                case ConsoleKey.F5:
                    Console.WriteLine("5 октава");
                    oct1 = new int[12] { 523, 554, 587, 622, 659, 698, 740, 784, 830, 880, 932, 987 };
                    break;
                case ConsoleKey.F6:
                    Console.WriteLine("6 октава");
                    oct1 = new int[12] { 1047, 1109, 1175, 1245, 131, 1397, 1480, 1568, 1661, 1760, 1865, 1976 };
                    break;
                case ConsoleKey.F7:
                    Console.WriteLine("7 октава");
                    oct1 = new int[12] { 2093, 2217, 2349, 2489, 2637, 2794, 2960, 3136, 3322, 3520, 3729, 3951 };
                    break;
                case ConsoleKey.F8:
                    Console.WriteLine("8 октава");
                    oct1 = new int[12] { 4186, 4435, 4699, 4978, 5274, 5588, 5920, 6272, 6645, 7040, 7459, 7902 };
                    break;
                default: break;
            }

            return oct1;
        }

        static void Play(System.ConsoleKeyInfo key, int[] oct1)
        {

            switch (key.Key)
            {
                case ConsoleKey.Q:
                    Console.Beep(oct1[0], 500);
                    break;
                case ConsoleKey.W:
                    Console.Beep(oct1[1], 500);
                    break;
                case ConsoleKey.E:
                    Console.Beep(oct1[2], 500);
                    break;
                case ConsoleKey.R:
                    Console.Beep(oct1[3], 500);
                    break;
                case ConsoleKey.T:
                    Console.Beep(oct1[4], 500);
                    break;
                case ConsoleKey.Y:
                    Console.Beep(oct1[5], 500);
                    break;
                case ConsoleKey.U:
                    Console.Beep(oct1[6], 500);
                    break;
                case ConsoleKey.I:
                    Console.Beep(oct1[7], 500);
                    break;
                case ConsoleKey.O:
                    Console.Beep(oct1[8], 500);
                    break;
                case ConsoleKey.P:
                    Console.Beep(oct1[9], 500);
                    break;
                case ConsoleKey.A:
                    Console.Beep(oct1[10], 500);
                    break;
                case ConsoleKey.S:
                    Console.Beep(oct1[11], 500);
                    break;
                default: break;
            }

        }

        static void Main()
        {
            int[] oct1 = new int[12] { 65, 69, 73, 77, 82, 87, 92, 98, 103, 110, 116, 123 };
            Console.WriteLine("Переключение между откавами: F2 - F8");
            Console.WriteLine("Клавиши для игры: Q, W, E, R, T, Y, U, I, O, P, A, S");
            while (true)
            {
    
                ConsoleKeyInfo key = Console.ReadKey(true);
                oct1 = Ton(key, oct1);
                Play(key, oct1);
            }
        }
    }
}
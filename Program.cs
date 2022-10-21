namespace Pianino
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //определям массивы-каждый массив октава с 12 звуками
            int[] Octave = new int[12] { 131, 139, 147, 156, 165, 175, 185, 196, 208, 220, 233, 247 };
            


            ConsoleKeyInfo nota = Console.ReadKey();//  нажали клавишу

            while (nota.Key != ConsoleKey.Q)  // пока не нажата клавища q

            {
                if (nota.Key == ConsoleKey.F1)
                {
                    Octave = Music(1);
                }
                else if (nota.Key == ConsoleKey.F2)
                {
                    Octave= Music(2);
                }
                else if (nota.Key == ConsoleKey.F3)
                {
                    Octave = Music(3);
                }


                Zvuk(nota.Key, Octave);
                nota = Console.ReadKey(); //нажимаем клавишу
            }

        }



        static void Zvuk(System.ConsoleKey a, int[] oktav)
        {



            if (a == ConsoleKey.S)
            {
                Console.Beep(oktav[0], 500);

            }
            else if (a == ConsoleKey.E)
            {
                Console.Beep(oktav[1], 500);
            }
            else if (a == ConsoleKey.D)
            {
                Console.Beep(oktav[2], 500);
            }
            else if (a == ConsoleKey.R)
            {
                Console.Beep(oktav[3], 500);
            }
            else if (a == ConsoleKey.F)
            {
                Console.Beep(oktav[4], 500);
            }
            else if (a == ConsoleKey.G)
            {
                Console.Beep(oktav[5], 500);
            }
            else if (a == ConsoleKey.Y)
            {
                Console.Beep(oktav[6], 500);
            }
            else if (a == ConsoleKey.H)
            {
                Console.Beep(oktav[7], 500);
            }
            else if (a == ConsoleKey.U)
            {
                Console.Beep(oktav[8], 500);
            }
            else if (a == ConsoleKey.J)
            {
                Console.Beep(oktav[9], 500);
            }
            else if (a == ConsoleKey.I)
            {
                Console.Beep(oktav[10], 500);
            }
            else if (a == ConsoleKey.K)
            {
                Console.Beep(oktav[11], 500);
            }


        }



        static int[] Music(int a)
        {
            //определям массивы-каждый массив октава с 12 звуками
            int[] firstOctave1 = new int[12] { 131, 139, 147, 156, 165, 175, 185, 196, 208, 220, 233, 247 };
            int[] firstOctave2 = new int[12] { 262, 277, 294, 311, 330, 349, 370, 392, 415, 440, 466, 494 };
            int[] firstOctave3 = new int[12] { 523, 554, 587, 622, 659, 698, 740, 784, 830, 880, 932, 987 };

            if (a == 1)
            {
                return firstOctave1;
            }
            else if (a == 2)
            {
                return firstOctave2;
            }
            else if (a == 3)
            {
                return firstOctave3;
            }
            else
            {
                return firstOctave1;  
            }
        }
    }
}

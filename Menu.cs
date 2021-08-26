using System;

namespace EditorHtml
{
    public static class Menu
    {
        public static void Show()
        {
            Console.Clear();
            //Editar a cor do console 
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;

            DrawScreen();

        }

        public static void DrawScreen()
        {
            TetoConsole(30);
            ColunaConsole(10);
            Chao(30);
        }

        public static void WriteOptions()
        {
            Console.SetCursorPosition(3, 3);
            Console.WriteLine("");
        }

        public static void TetoConsole(int teto)
        {
            // teto do console
            Console.Write("+");
            for (int i = 0; i <= teto; i++)
            {
                Console.Write("-");
            }

            Console.Write("+");
            Console.Write("\n");
        }
        public static void ColunaConsole(int parede)
        {
            // Parede do console
            for (int lines = 0; lines <= parede; lines++)
            {
                Console.Write("|");

                for (int i = 0; i <= 30; i++)
                {
                    Console.Write(" ");
                }
                Console.Write("|");
                Console.Write("\n");
            }
        }
        public static void Chao(int chao)
        {
            //Chão da console
            Console.Write("+");
            for (int a = 0; a <= 30; a++)
            {
                Console.Write("-");
            }

            Console.Write("+");
        }
    }
}
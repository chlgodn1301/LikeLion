using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BrickGame
{
    class Program
    {
        [DllImport("msvcrt.dll")]
        public static extern int _getch();  // c언어 함수 가져옴

        public static void GotoXY(int x, int y)
        {
            Console.SetCursorPosition(x, y);
        }

        static void Main(string[] args)
        {
            //Console.SetWindowPosition(80, 25);
            //Console.SetBufferSize(80,25);


            GamaManager gameManager = new GamaManager();
            gameManager.Initialize();

            int Curr = Environment.TickCount;

            while (true)
            {
                if (Curr + 50 < Environment.TickCount)
                {
                    Curr = Environment.TickCount;
                    gameManager.Progress();
                    gameManager.Render();
                }
            }



        }
    }
}

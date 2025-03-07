using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ShootingGame01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(80, 25); // 콘솔 창 크기 설정 (가로 80, 세로 25)
            Console.SetBufferSize(80, 25); // 버퍼 크기도 동일하게 설정 (스크롤 방지)


            string[] player = new string[]
            {
                "  ->",
                "=□□▷",
                "  ->"
            };   // 배열 문자열로 그리기

            int PlayerX = 0;
            int PlayerY = 12;


            ConsoleKeyInfo keyInfo;
            Console.CursorVisible = false;

            // 시간 1초 루프
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            long prevSecond = stopwatch.ElapsedMilliseconds;
            



            while (true)
            {
                long currentSecond = stopwatch.ElapsedMilliseconds; // 현재시간 가져오기

                if(currentSecond - prevSecond >=10)
                {



                    Console.Clear();

                    if (Console.KeyAvailable)
                    {
                        keyInfo = Console.ReadKey(true); // 키 입력받기(화면 출력 X)
                                                         //Console.WriteLine("1초 루프");


                        // 방향키 입력에 따른 좌표 변경
                        switch (keyInfo.Key)
                        {
                            case ConsoleKey.UpArrow: if (PlayerY > 0) PlayerY--; break;
                            case ConsoleKey.DownArrow: if (PlayerY < Console.WindowHeight - 1) PlayerY++; break;

                            case ConsoleKey.LeftArrow: if (PlayerX > 0) PlayerX--; break;
                            case ConsoleKey.RightArrow: if (PlayerX < Console.WindowWidth - 2) PlayerX++; break;
                            // case ConsoleKey.Spacebar: Console.Write("미사일키"); break;
                            case ConsoleKey.Escape: return; // esc로 종료

                        }
                    }


                    for (int i = 0; i < player.Length; i++)
                    {
                        //콘솔 좌표 설정 플레이어 X 플레이어 Y
                        Console.SetCursorPosition(PlayerX, PlayerY + i);
                        // 문자열 배열 출력
                        Console.WriteLine(player[i]);
                    }

                    prevSecond = currentSecond; // 이전 시간 업데이트
                }
            }

            

        }
    }
}

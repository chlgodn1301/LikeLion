using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace projectBlackSmith
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            Console.WriteLine(" 대장장이 키우기 ");

            int pMoney = 100;
            int input;
            int rnd;

            Thread.Sleep(500);

            while (true)
            {
                Console.Clear();    // 화면 지우기
                Console.WriteLine("1. 나무캐기");
                Console.WriteLine("2. 장비뽑기");
                Console.WriteLine("3. 나가기");
                Console.Write("입력 : ");
                input = int.Parse(Console.ReadLine());  // input에 키로 눌린 숫자 담기

                if (input == 1)
                {
                    while (true)
                    {
                        Console.WriteLine("나무캐기(엔터)");
                        Console.WriteLine("뒤로가기 (x)");

                        string str = Console.ReadLine();

                        pMoney += 100;
                        Console.WriteLine("소지금 : " + pMoney);
                        if (str == "x")
                        {
                            Console.WriteLine("뒤로가기");
                            break;
                        }
                    }
                }

                else if (input == 2)
                {
                    // 장비뽑기
                    if (pMoney >= 1000)  // 돈이 있는가?
                    {
                        pMoney -= 1000;

                        // 20번 뽑기
                        for (int i = 1; i <= 20; i++)
                        {
                            rnd = rand.Next(1, 101);
                            if (rnd == 1) //1퍼
                            {
                                Console.WriteLine("도끼등급 SSS");
                            }
                            else if (rnd > 2 && rnd <= 6)
                            {
                                Console.WriteLine("도끼등급 SS");
                            }
                            else if (rnd >= 7 && rnd <= 17)
                            {
                                Console.WriteLine("도끼등급 S");
                            }
                            else if (rnd >= 18 && rnd <= 38)
                            {
                                Console.WriteLine("도끼등급 A");
                            }
                            else if (rnd >= 39 && rnd <= 698)
                            {
                                Console.WriteLine("도끼등급 B");
                            }
                            else
                            {
                                Console.WriteLine("도끼등급 C");
                            }
                            Thread.Sleep(500);  // 0.5초 간격

                        }

                        Console.WriteLine("남은 소지금 : " + pMoney);
                        Thread.Sleep(2000);  // 0.5초 간격
                    }
                    else
                    {
                        Console.WriteLine("돈이 부족합니다! \n");
                        Thread.Sleep(2000);
                        break;
                    }
                }

                else if(input == 3)
                {
                    Console.WriteLine("종료합니다! \n");
                    Thread.Sleep(2000);
                    Environment.Exit(0);
                }


            }



        }
    }
}

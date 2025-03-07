using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace projectTravelerIdle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Random rand = new Random();

            int gold = 500, health = 100, power = 10, input;
            bool isAlive = true;

            Console.WriteLine("⚔️ 모험가 키우기 ⚔️");
            Thread.Sleep(2000);

            while(isAlive)
            {
                Console.Clear();
                Console.WriteLine($"현재 상태 : 체력 {health}\n골드 : {gold}\n공격력 : {power}");
                Console.WriteLine("\n1.탐험하기 🏕️");
                Console.WriteLine("2.장비 뽑기 🎲 (1000G)");
                Console.WriteLine("3.휴식하기 (체력 +20) 🛏️");
                Console.WriteLine("4.종료하기");
                Console.Write("입력 : ");

                input = int.Parse(Console.ReadLine());

                if (input == 1)
                {
                    Console.Clear();
                    Console.WriteLine(" 탐험을 떠납니다.");
                    Thread.Sleep(500);
                    Console.WriteLine(" 탐험을 떠납니다...");
                    Thread.Sleep(500);
                    Console.WriteLine(" 탐험을 떠납니다....");
                    Thread.Sleep(500);
                    Console.WriteLine(" 탐험을 떠납니다.....");
                    Thread.Sleep(500);

                    int eventChance = rand.Next(1, 101);    // 1~100 랜덤 이벤트

                    if (eventChance <= 30)       // 30% 확률로 전투
                    {
                        int damage = rand.Next(5, 21);
                        Console.WriteLine($"⚔️ 몬스터를 만났습니다! (체력 -{damage})");
                        health -= damage;
                    }
                    else if (eventChance <= 70)  // 40% 확률로 보상
                    {
                        int reward = rand.Next(100, 301);   //100~300골드
                        Console.WriteLine($"💰 보물을 발견했습니다! (골드 +{reward})");
                        gold += reward;
                    }
                    else    // 30% 확률로 회복
                    {
                        int heal = rand.Next(10, 31);   // 10~30 체력 회복

                        if(health == 100)
                        {
                            Console.WriteLine($"🌿 신비한 약초를 발견했습니다! 체력이 최대치이므로, 약초를 판매하여 골드를 획득했습니다!");
                            gold += 50;
                        }
                        else
                        {
                            Console.WriteLine($"🌿 신비한 약초를 발견했습니다! (체력 +{heal})");
                            health += heal;
                            if(health >=100)
                            {
                                health = 100;
                            }
                        }
                    }

                    if (health <= 0)
                    {
                        Console.WriteLine("\n 💀 체력이 0이 되어 사망했습니다...");
                        Console.WriteLine("GAME OVER");
                        isAlive = false;
                    }

                    Thread.Sleep(1500);
                }

                else if (input == 2)     // 장비 뽑기
                {
                    if (gold >= 1000)
                    {
                        gold -= 1000;
                        Console.Clear();
                        Console.WriteLine("장비를 뽑습니다..");
                        Thread.Sleep(1000);

                        int rnd = rand.Next(1, 101);    // 1~100랜덤

                        if (rnd <= 5)
                        {
                            Console.WriteLine("SSR급 전설의 검 (공격력 +50) 획득!");
                            power = 150;
                            Console.WriteLine($"현재 공격력은 {power}입니다.");
                        }

                        else if (rnd <= 15)
                        {
                            Console.WriteLine("SR급 용사의 검 (공격력 +30) 획득!");
                            if(power < 150)
                            power = 130;
                            Console.WriteLine($"현재 공격력은 {power}입니다.");

                        }
                        else if (rnd <= 35)
                        {
                            Console.WriteLine("R급 무기 롱소드 (공격력 +10) 획득!");
                            if(power < 130)
                            power = 110;
                            Console.WriteLine($"현재 공격력은 {power}입니다.");

                        }
                        else
                        {
                            Console.WriteLine("N급 무기 녹슨검 (공격력 +5) 획득!");
                            if(power < 110)
                            power = 105;
                            Console.WriteLine($"현재 공격력은 {power}입니다.");

                        }
                        Thread.Sleep(1500);
                    }
                    else
                    {
                        Console.WriteLine("골드가 부족합니다.");
                        Thread.Sleep(1000);
                    }

                }

                else if (input == 3)
                {
                    Console.WriteLine("휴식을 취합니다... (체력 +20)"); ;
                    health += 20;
                    Thread.Sleep(1000);
                }

                else if (input == 4)
                {
                    Console.WriteLine("게임을 종료합니다.");
                    Environment.Exit(0);
                }

                else
                {
                    Console.WriteLine("잘못된 입력입니다. 다시 선택하세요.");
                    Thread.Sleep(3000);
                }
            }
        }
    }
}

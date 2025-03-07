using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace projectEscapeDungeon
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; // 이모지
            // 로딩바 시작화면
            // 게임 스토리 1
            //콘솔 창 크기 설정 
            Random rand = new Random();
            Console.SetWindowSize(80, 25); //x 80 , y 25

            //콘솔 버퍼 크기도 설정 (스크롤없이 고정된 창 유지)
            Console.SetBufferSize(80, 25);
            Console.SetCursorPosition(0, 0);
            Console.Write("┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓");
            Console.SetCursorPosition(0, 1);
            Console.Write("┃                                                                             ┃");
            Console.SetCursorPosition(0, 2);
            Console.Write("┃                                                                             ┃");
            Console.SetCursorPosition(0, 3);
            Console.Write("┃                                                                             ┃");
            Console.SetCursorPosition(0, 4);
            Console.Write("┃                                                                             ┃");
            Console.SetCursorPosition(0, 4);
            Console.Write("┃                                                                             ┃");
            Console.SetCursorPosition(0, 5);
            Console.Write("┃                                                                             ┃");
            Console.SetCursorPosition(0, 6);
            Console.Write("┃                                                                             ┃");
            Console.SetCursorPosition(0, 7);
            Console.Write("┃                                                                             ┃");
            Console.SetCursorPosition(0, 8);
            Console.Write("┃                                                                             ┃");
            Console.SetCursorPosition(0, 9);
            Console.Write("┃                                                                             ┃");
            Console.SetCursorPosition(0, 10);
            Console.Write("┃                              Escape Dungeon                                 ┃");
            Console.SetCursorPosition(0, 11);
            Console.Write("┃                                                                             ┃");
            Console.SetCursorPosition(0, 12);
            Console.Write("┃                                                                             ┃");
            Console.SetCursorPosition(0, 13);
            Console.Write("┃                                                                             ┃");
            Console.SetCursorPosition(0, 14);
            Console.Write("┃                                                                             ┃");
            Console.SetCursorPosition(0, 15);
            Console.Write("┃                                                                             ┃");
            Console.SetCursorPosition(0, 16);
            Console.Write("┃                                Press Enter                                  ┃");
            Console.SetCursorPosition(0, 17);
            Console.Write("┃                                                                             ┃");
            Console.SetCursorPosition(0, 18);
            Console.Write("┃                                                                             ┃");
            Console.SetCursorPosition(0, 19);
            Console.Write("┃                                                                             ┃");
            Console.SetCursorPosition(0, 20);
            Console.WriteLine("┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛");

            Console.ReadLine();
            Console.Clear();

            int inputClass = 0, inputMenu, inputBattle;
            int hp = 0, hpMax = 0, mana = 0, manaMax = 0, phyDMG = 0, magDMG = 0, avoid = 0, phyDEF = 0, magDEF = 0, cri = 0;
            int skullHP = 50, skullDMG = 20, skullPhyDEF = 5, skullMagDEF = 0;
            int gold = 500;
            string inputCheck, inputClassCheck, mainClass = "";
            bool selectClass = true,  isAlive = true, isBattle = false, isMelee = false, isDef = false, myTurn = false;

            start:
            Console.Clear();
            Console.WriteLine("1. 전사");
            Console.WriteLine("2. 궁수");
            Console.WriteLine("3. 도적");
            Console.WriteLine("4. 마법사");
            Console.Write("직업을 선택해 주세요 : ");
            inputClass = int.Parse(Console.ReadLine());


            while(selectClass == true)
            {
                if (inputClass == 1)
                {
                    Console.WriteLine("\n전사는 근접 전투에 능하며, 높은 방어력을 지니고 있습니다.");
                    mainClass = "전사";
                }
                else if (inputClass == 2)
                {
                    Console.WriteLine("\n궁수는 원거리 전투에 능하지만, 방어력이 낮습니다.");
                    Console.WriteLine("원거리 공격으로 공격 시 데미지를 받지 않습니다");
                    mainClass = "궁수";
                }
                else if (inputClass == 3)
                {
                    Console.WriteLine("\n도적은 근접 전투 및 회피에 능하지만, 방어력이 매우 낮습니다.");
                    Console.WriteLine("치명적인 공격을 할 확률이 높습니다.");
                    mainClass = "도적";
                }
                else if (inputClass == 4)
                {
                    Console.WriteLine("\n마법사는 마법 전투에 능합니다.");
                    mainClass = "마법사";
                }
                else
                {
                    Console.WriteLine("제대로 된 값을 입력해주세요..");
                }
                
                Console.Write($"\n{mainClass}(으)로 전직하시겠습니까? (Y/N) - ");
                inputCheck = Console.ReadLine();

                if (inputCheck == "Y" || inputCheck == "y")
                {
                    Console.WriteLine("직업 선택이 완료되었습니다.");
                    if (inputClass == 1)
                    {
                        hp = 100; hpMax = 100; mana = 80; manaMax = 80; phyDMG = 15; magDMG = 5; avoid = 10; phyDEF = 10; magDEF = 10; cri = 5; isMelee = true;
                    }
                    else if (inputClass == 2)
                    {
                        hp = 80; hpMax = 80;  mana = 100; manaMax = 100; phyDMG = 15; magDMG = 5; avoid = 15; phyDEF = 5; magDEF = 5; cri = 5; isMelee = false;
                    }
                    else if (inputClass == 3)
                    {
                        hp = 90; hpMax = 90; mana = 100; manaMax = 100; phyDMG = 20; magDMG = 5; avoid = 20; phyDEF = 5; magDEF = 5; cri = 10; isMelee = true;
                    }
                    else if (inputClass == 4)
                    {
                        hp = 85; hpMax = 85; mana = 120; manaMax = 120; phyDMG = 15; magDMG = 20; avoid = 10; phyDEF = 10; magDEF = 10; cri = 5; isMelee = false;
                    }

                    Console.WriteLine("\n던전으로 들어갑니다.");
                    selectClass = false;
                }
                else if (inputCheck == "N" || inputCheck == "n")
                {
                    Console.Clear();
                    goto start;
                }
                else
                {
                    Console.WriteLine("제대로 된 값을 입력해주세요.");
                    Thread.Sleep(1000);
                    goto start;
                }

                while(isAlive)
                {
                    Console.Clear();
                    Console.WriteLine($"현재 상태 : 체력 {hp}\n골드 : {gold}");
                    Console.WriteLine("\n1.탐험하기 🏕️");
                    Console.WriteLine("2.장비 뽑기 🎲 (-1000G)");
                    Console.WriteLine("3.휴식하기 (-100G, 완전히 회복) 🛏️");
                    Console.WriteLine("4.종료하기");
                    Console.Write("입력 : ");

                    inputMenu = int.Parse(Console.ReadLine());

                    if (inputMenu == 1)
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
                            isBattle = true;
                            while(isBattle)
                            {
                                myTurn = true;
                                Console.Clear();
                                Console.WriteLine("스켈레톤을 마주쳤습니다!");
                                Thread.Sleep(500);
                                Console.WriteLine("\n행동을 선택해주세요.");
                                Console.WriteLine("\n1. 공격");
                                Console.WriteLine("2. 방어");
                                Console.WriteLine("3. 도주");
                                inputBattle = int.Parse(Console.ReadLine());

                                if(inputBattle == 1)
                                {

                                }
                                else if(inputBattle == 2)
                                {

                                }
                                else if(inputBattle == 3)
                                {
                                    int escapeEvent = rand.Next(1, 101);
                                    if(eventChance <= 70)
                                    {
                                        Console.WriteLine("도주에 성공했습니다!");
                                        Thread.Sleep(1000);
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("도주에 실패했습니다!");
                                        Thread.Sleep(1000);
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("제대로 된 값을 입력해주세요.");
                                    Thread.Sleep(1000);
                                }
                            }


                            /*int damage = rand.Next(5, 21);
                            Console.WriteLine($"⚔ 몬스터를 만났습니다! (체력 -{damage})");
                            hp -= damage;*/



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

                            if (hp == hpMax)
                            {
                                Console.WriteLine($"🌿 신비한 약초를 발견했습니다! 체력이 최대치이므로, 약초를 판매하여 골드를 획득했습니다!");
                                gold += 50;
                            }
                            else
                            {
                                Console.WriteLine($"🌿 신비한 약초를 발견했습니다! (체력 +{heal})");
                                hp += heal;
                                if (hp >= hpMax)
                                {
                                    hp = hpMax;
                                }
                            }
                        }

                        if (hp <= 0)
                        {
                            Console.WriteLine("\n 💀 체력이 0이 되어 사망했습니다...");
                            Console.WriteLine("GAME OVER");
                            isAlive = false;
                        }

                        Thread.Sleep(1500);
                    }
                    /*
                    else if (inputMenu == 2)     // 장비 뽑기
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
                                if (power < 150)
                                    power = 130;
                                Console.WriteLine($"현재 공격력은 {power}입니다.");

                            }
                            else if (rnd <= 35)
                            {
                                Console.WriteLine("R급 무기 롱소드 (공격력 +10) 획득!");
                                if (power < 130)
                                    power = 110;
                                Console.WriteLine($"현재 공격력은 {power}입니다.");

                            }
                            else
                            {
                                Console.WriteLine("N급 무기 녹슨검 (공격력 +5) 획득!");
                                if (power < 110)
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
                    */
                    else if (inputMenu == 3)
                    {
                        Console.WriteLine("휴식을 취합니다... ");
                        Console.WriteLine("모두 회복했습니다! ");
                        hp = hpMax;
                        gold -= 100;
                        Thread.Sleep(1000);
                    }

                    else if (inputMenu == 4)
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

            Console.Clear();
            Console.WriteLine("진입");

            
        }
    }
}

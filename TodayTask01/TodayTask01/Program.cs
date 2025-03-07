using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodayTask01
{
    class Program
    {
        static void Main(string[] args)
        {
            // 로딩바 시작화면
            // 게임 스토리 1
            //콘솔 창 크기 설정 
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


            Console.WriteLine("직업을 선택해 주세요.");


            Console.WriteLine("눈을 뜨자 어둠이 눈 앞을 지배하고 있다.");
            Console.ReadLine();
            Console.WriteLine("기분 나쁜 습기와 어둠이 느껴진다.");
            Console.ReadLine();
            Console.Clear();
            
            Console.WriteLine("\"던전인가?\"");
            Console.ReadLine();
            Console.WriteLine("즐겨하던 게임에서 본 듯한 분위기가 눈앞에서 느껴진다.");
            Console.ReadLine();
            Console.WriteLine("유행하는 만화나 소설의 뻔한 스토리가 나에게 벌어진건가?");
            Console.ReadLine();
            Console.WriteLine("실소를 흘리며 말도 안된다는 생각을 하려던 그 때,");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("\'그르르...\'");
            Console.ReadLine();
            Console.WriteLine("어디선가 짐승의 울음소리 같은 것이 들려왔다.");
            Console.ReadLine();
            Console.WriteLine("등골이 오싹해지며, 몸이 굳어왔다.");
            Console.ReadLine();
            Console.WriteLine("1. 일단 달린다.");
            Console.WriteLine("2. 일단 침착하게 정신을 가다듬는다.");

            Console.WriteLine("");
            Console.Write("당신의 선택은? ");
            string selection = Console.ReadLine();
            if (selection == "1")
            {
                Console.Clear();
                Console.WriteLine("더 이상 고민할 겨를이 없다.");
                Console.ReadLine();
                Console.WriteLine("일단 저 괴물에게서 도망치자.");
                Console.ReadLine();
                Console.WriteLine("생각을 마치고 일단 제 자리에서 뛰쳐나갔다.");
                Console.ReadLine();
                Console.WriteLine("하지만 그것은 잘못된 생각이었다.");
                Console.ReadLine();
                Console.WriteLine("앞이 보이지 않아 지형을 파악하지 못한 나는, 낭떠러지로 떨어지고 말았다.");
                Console.ReadLine();
                Console.Clear();


                Console.WriteLine("GAME OVER");
                Console.ReadLine();
            };


            if (selection == "2")
            {
                Console.Clear();
                Console.WriteLine("일단은 침착하자.");
                Console.ReadLine();
                Console.WriteLine("뭔지는 모르겠지만 날 두려워하고 있다.");
                Console.ReadLine();
                Console.WriteLine("혹시 모를 사태를 대비해 주변의 지형을 파악하자.");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("내 바로 앞은, 낭떠러지였다.");
                Console.ReadLine();
                Console.WriteLine("다급하게 뛰쳐나갔다간 큰일날 뻔했군.");
                Console.ReadLine();
                Console.WriteLine("날 견제하던 무언가도 조심스럽게 자리를 피한듯 하다.");
                Console.ReadLine();
                Console.Clear();


                Console.WriteLine("STAGE 1 CLEAR");
                Console.ReadLine();
            }
        }
    }
}

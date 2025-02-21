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

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("             Escape Dungeon              ");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Enter 입력 시 진행됩니다.");
            Console.ReadLine();
            Console.Clear();

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

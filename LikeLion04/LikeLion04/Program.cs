using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeLion04
{
    class Program
    {
        static void Main(string[] args)
        {
            // 캐릭터
            // HP : 100
            // att : 56.7
            // 캐릭터 이름 : ??
            // 등급 : S

            Console.Write("캐릭터 명을 입력해주세요 : ");  // 변수 입력 설명
            string CharName = Console.ReadLine();          // 변수 입력 

            int HP = 100;
            double att = 56.7;
            char tier = 'S';

            Console.WriteLine("캐릭터");
            Console.WriteLine("캐릭터 이름 : " + CharName);
            Console.WriteLine("HP : " + HP);
            Console.WriteLine("공력력 : " + att);
            Console.WriteLine("등급 : " + tier);


        }
    }
}

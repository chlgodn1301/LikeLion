using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeLion06
{
    class Program
    {
        static void Main(string[] args)
        {
            // 변수 선언과 초기화를 한번에 수행
            /*int score = 100;            // 정수형 변수 선언과 동시에 100으로 초기화
            double temperature = 36.5;  // 실수형 변수 선언과 초기화
            string city = "Seoul";      // 문자형 변수 선언과 초기화


            // 변수 출력
            Console.WriteLine(score);       // 출력 100
            Console.WriteLine(temperature); // 출력 36.5
            Console.WriteLine(city);        // 출력 Seoul*/


            // 같은 데이터 타입의 변수를 쉼표로 구분하여 선언
            /*int x = 10, y = 20, z = 30; // 정수형 변수 x,y,z를 선언하고 초기화

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);*/



            //상수 선언
            /*const double Pi = 3.141592; // 상수 Pi 선언 및 초기화
            const int MaxScore = 100;   // 정수형 상수 선언

            // 출력
            Console.WriteLine("Pi : " + Pi);                // 출력 : Pi : 3.141592
            Console.WriteLine("MaxScore : " + MaxScore);    // 출력 : MaxScore : 100*/

            
            int atk = 16755, maxHP = 78103, Cri = 36, Special = 1017, Domination = 41, Swift = 611, Endurance = 22, Expertise = 39;

            Console.WriteLine("[기본 특성]");
            Console.WriteLine("공격력 : " + atk);
            Console.WriteLine("최대 생명력 : " + maxHP);

            Console.WriteLine("[전투 특성]");
            Console.WriteLine("치명 : " + Cri);
            Console.WriteLine("특화 : " + Special);
            Console.WriteLine("제압 : " + Domination);
            Console.WriteLine("신속 : " + Swift);
            Console.WriteLine("인내 : " + Endurance);
            Console.WriteLine("숙련 : " + Expertise);


        }
    }
}


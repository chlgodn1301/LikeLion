using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LikeLion09
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int day = 3;
            switch(day)
            {
                case 1:
                    Console.WriteLine("월요일");
                    break;
                case 2:
                    Console.WriteLine("화요일");
                    break;
                case 3:
                    Console.WriteLine("수요일");
                    break;
                case 4:
                    Console.WriteLine("목요일");
                    break;
                case 5:
                    Console.WriteLine("금요일");
                    break;
                default:
                    Console.WriteLine("주말입니다");
                    break;
            }*/


            // 캐릭터를 선택하세요 (1. 검사 2. 마법사 3. 도적)
            // 스위치


            // 1
            // 검사
            // 공격력 100
            // 방어력 90

            // 2
            // 마법사
            // 공격력 110
            // 방어력 80

            // 3
            // 도적
            // 공격력 115
            // 방어력 70

            /*int mainChar = 0;
            Console.WriteLine("원하는 직업의 번호를 선택해주세요.");
            Console.WriteLine("1. 검사");
            Console.WriteLine("2. 마법사");
            Console.WriteLine("3. 도적");
            mainChar = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            switch (mainChar)
            {
                case 1:
                    Console.WriteLine("검사를 선택하셨습니다.");
                    Console.WriteLine("공격력 : 100");
                    Console.WriteLine("방어력 : 90");
                    break;
                case 2:
                    Console.WriteLine("마법사를 선택하셨습니다.");
                    Console.WriteLine("공격력 : 110");
                    Console.WriteLine("방어력 : 80");
                    break;
                case 3:
                    Console.WriteLine("도적을 선택하셨습니다.");
                    Console.WriteLine("공격력 : 115");
                    Console.WriteLine("방어력 : 70");
                    break;
            }*/

            //=====================================================
            // for문 - 고정된 횟수를 반복할 때 사용

            // 초기화 ; 조건문 ; 증감식
            /*for(int i = 1; i <= 5; i++)
            {
                Console.WriteLine("숫자 : " + i);
            }*/

            //무한반복
            /*for (; ; )
            {
                Console.WriteLine("중요한건 꺽이지 않는 마음");
            }*/

            //0~9
            /*for (int i = 0; i <= 9; i++)
            {
                Console.WriteLine("숫자 : " + i);
            }*/

            // 1~ 10까지의 합

            /*int i;
            int sum = 0;
            for(i = 1; i<=10; i++)
            {
                sum = sum + i;
                Console.WriteLine(sum);
            }*/


            //=====================================================
            // while 
            /*int count = 1;  //초기화
            while (count <= 5) // 조건식
            {
                Console.WriteLine("Count : " + count);
                count++;    // 증가,감소

                if (count == 3)
                {
                    Console.WriteLine("3일 때 반복문 탈출");
                    break;
                }
            }
            Console.WriteLine("Count : " + count);*/



            //=====================================================
            // 랜덤

            /*Random rand = new Random();    // 랜덤 객체를 생성

            // 0이상 10 미만의 랜덤 정수 생성
            int randomNum = rand.Next(0, 10);   // 0~9
            Console.WriteLine(randomNum);


            for(int i = 0; i<10; i++)
            {
                double randomNumber = rand.NextDouble(); // 0~9
                Console.WriteLine("0이상 10미만의 랜덤 실수 : " + randomNumber);
            }

            int randomInrange = 0;
            for (int j = 0; j<10; j++)
            {
                randomInrange = rand.Next(5, 15);
                Console.WriteLine("5부터 14까지 : " + randomInrange);
            }*/



            //=====================================================
            // 대장장이 키우기

            // 도끼 등급 SSS 10%
            // 도끼 등급 SS  40%
            // 도끼 등급 S   50%

            /*Random rand = new Random(); // 랜덤 객체 생성
            
            int rnd = 0;

            for(int i = 0; i<=20; i++)
            {
                rnd = rand.Next(1, 101);

                if(rnd >=1 && rnd <=5)
                {
                    Console.WriteLine("SSS등급 도끼를 뽑았습니다!");
                    break;
                }
                else if (rnd >= 11 && rnd <= 45)
                {
                    Console.WriteLine("SS등급 도끼를 뽑았습니다!");
                }
                else
                {
                    Console.WriteLine("S등급 도끼를 뽑았습니다!");
                }

                Thread.Sleep(500);  // 0.5초 간격
            }*/


            //=====================================================
            // do while - 1회 무조건 실행하고 while문과 같이 조건진행

            /*int x = 5;
            do
            {
                Console.WriteLine("최소 한번은 실행 - " + x);
                x--;
            } while (x > 0);*/


            //=====================================================
            // break문 - 반복문을 탈출할 수 있다

            /*for(int i = 1; i <= 10; i++)
            {
                if(i==5);
                break;

                Console.WriteLine(i);
            }*/


            //=====================================================
            // continue - 현재 반복을 건너뛰고 다음반복으로 넘어간다

            /*for (int i= 1; i <=10; i++)
            {
                if(i % 2 == 0);
                {
                    continue;
                }
                Console.WriteLine(i); // 홀수만 출력
            }*/


            //=====================================================
            // goto 

            int n = 1;
            start:
            if(n <=5)
            {
                Console.WriteLine(n);
                n++;
                goto start; //레이블로 이동
            }

        }
    }
}

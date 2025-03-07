using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LikeLion011
{
    class Program
    {
        // 메모리 영역
        // 스택 (stack)
        // 힙 (heap)
        // 정적 메모리 (static memory)

        //static int count = 0; // 정적 메모리에 저장됨
        // 프로그램 종료 전까지 유지됨.


        // 1단계 함수
        // 반환형 함수 이름 (매개변수)
        //{
        //}
        // void (반환형, 출력값 없음)

        // void Print()
        //{
        //}
        
        // 1단계 기본형
        static void Loading()
        {
            Console.WriteLine("로딩중.");
            Thread.Sleep(1000);
            Console.WriteLine("로딩중..");
            Thread.Sleep(1000);
            Console.WriteLine("로딩중...");
            Thread.Sleep(1000);
        }


        // 2단계
        // 입력

        static void AttackFunction(int _Attack)
        {
            Console.WriteLine("공격력 : " + _Attack);
        }



        // 3단계
        // 출력
        static int baseAttack()
        {
            // 기본 공격력 10
            int attack = 10;
            return attack;  // 출력
        }


        static int Add(int a, int b)
        {
            return a+b;
        }


        static int inputLength(string input)
        {
            return input.Length;
        }

        static int CompareNumber(int a, int b, int c)
        {
            int numMax = 0;
            int[] numbers10 = { a, b, c };
            for(int i = 0; i<3;  i++)
            {
                if (numMax < numbers10[i])
                    numMax = numbers10[i];

            }
            return numMax;
        }

        static void Main(string[] args)
        {
            /*int statAtk = 0;
            int baseAtk = 0;
            Console.WriteLine("캐릭터의 공격력을 입력 : ");
            statAtk = int.Parse(Console.ReadLine());

            // 기본 공격력
            baseAtk = baseAttack();

            AttackFunction(statAtk + baseAtk);*/

            // 두 수를 더하는 함수 만들어서 오류를 해결하세요.
            /*int result = Add(10, 20);
            Console.WriteLine($"10 + 20 = {result}");*/


            /*string[] fruits = { "사과", "바나나", "체리" };

            // 반복문
            foreach(string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }*/

            // Q1. 배열 요소 출력
            // 문제: 크기가 5인 정수 배열을 만들고, {10, 20, 30, 40, 50} 값을 저장한 후 출력하세요.

            /* Console.WriteLine("Q1. 배열 요소 출력");
             Console.WriteLine("크기가 5인 정수 배열을 만들고, {10, 20, 30, 40, 50} 값을 저장한 후 출력하세요.");

             int[] numbersQ1 = new int[5];
             numbersQ1[0] = 10;
             numbersQ1[1] = 20;
             numbersQ1[2] = 30;
             numbersQ1[3] = 40;
             numbersQ1[4] = 50;

             for(int i = 0; i < 5; i++)
             {
                 Console.WriteLine(numbersQ1[i]);
             }*/



            // Q2. 배열 요소 합 구하기
            // 문제: 사용자가 5개의 정수를 입력하면 배열에 저장하고, 모든 수의 합을 출력하세요.


            /*Console.WriteLine("Q2. 배열 요소 합 구하기");
            Console.WriteLine("사용자가 5개의 정수를 입력하면 배열에 저장하고, 모든 수의 합을 출력하세요.");

            int sum = 0;
            int[] numbersQ2 = new int[5];
            for (int i = 0; i < 5; i++)
            {
                numbersQ2[i] = int.Parse(Console.ReadLine());
                sum = sum + numbersQ2[i];
            }
            Console.WriteLine("총합 : " + sum);*/


            // Q3. 최대값 찾기
            // 문제: 정수 배열 {3, 8, 15, 6, 2}에서 가장 큰 값을 찾아 출력하세요.


            /*Console.WriteLine("Q3. 최대값 찾기");
            Console.WriteLine("정수 배열 {3, 8, 15, 6, 2}에서 가장 큰 값을 찾아 출력하세요.");

            int[] numbersQ3 = { 3, 8, 15, 6, 2 };
            int maxQ3 = 0;

            for(int i = 0; i< 5; i++)
            {
                if(maxQ3 < numbersQ3[i])
                {
                    maxQ3 = numbersQ3[i];
                }
            }

            Console.WriteLine($"최대값은 {maxQ3}입니다.");*/



            //Q4. 1부터 10까지 출력 (for문)
            // 문제: for문을 사용하여 1부터 10까지 출력하세요.

            /*Console.WriteLine("Q4. 1부터 10까지 출력 (for문)");
            Console.WriteLine("for문을 사용하여 1부터 10까지 출력하세요.");

            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine(i + 1);
            }*/



            //Q5. 짝수만 출력 (while문)
            // 문제: while문을 사용하여 1부터 10까지 중 짝수만 출력하세요.

            /*Console.WriteLine("Q5. 짝수만 출력 (while문)");
            Console.WriteLine("while문을 사용하여 1부터 10까지 중 짝수만 출력하세요.");


            int i = 1;
            while(i <= 10)
            {
                if(i%2 == 0)
                {
                    Console.WriteLine(i);
                }
                i++;
            }*/




            //Q6. 배열 요소 출력 (foreach문)
            // 문제: foreach문을 사용하여 배열 {1, 2, 3, 4, 5}의 요소를 출력하세요.

            /*Console.WriteLine("Q6. 배열 요소 출력 (foreach문)");
            Console.WriteLine("foreach문을 사용하여 배열 {1, 2, 3, 4, 5}의 요소를 출력하세요.");

            int[] numbersQ6 = { 1, 2, 3, 4, 5 };
            foreach (int number in numbersQ6)
            {
                Console.WriteLine(number);
            }*/


            // Q7. 두 수의 합을 구하는 함수
            // 문제: 두 개의 정수를 입력받아 합을 반환하는 함수를 작성하세요.
            /*Console.WriteLine("Q7. 두 수의 합을 구하는 함수");
            Console.WriteLine("두 개의 정수를 입력받아 합을 반환하는 함수를 작성하세요.");

            int a, b, sum;
            Console.WriteLine("첫 번째 수를 입력해주세요.");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("두 번째 수를 입력해주세요.");
            b = int.Parse(Console.ReadLine());


            sum = Add(a, b);

            Console.WriteLine($"두 수의 합은 {sum} 입니다.");*/



            // Q8. 문자열 길이 반환 함수
            // 문제: 문자열을 입력받아 길이를 반환하는 함수를 작성하세요.
            /*Console.WriteLine("Q8. 문자열 길이 반환 함수");
            Console.WriteLine("문자열을 입력받아 길이를 반환하는 함수를 작성하세요.");

            Console.Write("\n문자열을 입력해주세요 : ");

            string inputString = Console.ReadLine();

            Console.WriteLine("입력하신 문자열의 길이는 " + inputLength(inputString) + " 입니다.");*/



            // Q9. 가장 큰 수 반환 함수
            // 문제: 세 개의 정수를 입력받아 가장 큰 값을 반환하는 함수를 작성하세요.

            Console.WriteLine("Q9. 가장 큰 수 반환 함수");
            Console.WriteLine("세 개의 정수를 입력받아 가장 큰 값을 반환하는 함수를 작성하세요.");
            int a, b, c, max;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());

            max = CompareNumber(a,b,c);

            Console.WriteLine("가장 큰 값 : " + max);

        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
//using System.Collections;

namespace Practice_250304
{
    //Q1
    /*class Warrior
    {
        public string Name { get; set; }
        public int Score { get; set; }
        public int Strength { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Warrior warrior = new Warrior
            {
                Name = "최해우",
                Score = 100,
                Strength = 80
            };

            // 속성 값 출력
            Console.WriteLine($"Name: {warrior.Name}");
            Console.WriteLine($"Score: {warrior.Score}");
            Console.WriteLine($"Strength: {warrior.Strength}");
        }
    }*/


    //Q2

    /*
     사용자에게 정수를 입력받고, 이를 int로 변환하는 프로그램을 작성하세요.
     숫자로 변환할 수 없는 경우 FormatException을 처리하여 "올바른 숫자를 입력하세요!"라는 메시지를 출력하세요.
     변환이 성공하면 입력한 숫자를 출력하세요.
     */
    /*class Program
    {
        static void Main(string[] args)
        {

            while(true)
            {
                try
                {
                    Console.Write("숫자를 입력하세요 : ");
                    int value = int.Parse(Console.ReadLine());
                    Console.WriteLine($"입력한 숫자: {value}");
                    break;
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("숫자만 입력해주세요!");
                }
            }
           
           
        }
    }*/

    //Q3
    /*컬렉션(List, Queue, Stack) 활용
    List<string>을 생성하고 "사과", "바나나", "포도"를 추가하세요.
    Queue<string> 을 생성하고 "첫 번째 작업", "두 번째 작업", "세 번째 작업"을 추가하세요.
    Stack<int> 을 생성하고 10, 20, 30을 추가한 뒤 하나씩 출력하세요.*/

    /* class Program
     {
         static void Main(string[] args)
         {
             List<string> fruits = new List<string>();
             fruits.Add("사과");
             fruits.Add("바나나");
             fruits.Add("포도");

             var enumerator = fruits.GetEnumerator();
             Console.WriteLine("과일");
             foreach (var fruit in fruits)
                 Console.WriteLine(fruit);


             Queue<string> tasks = new Queue<string>();
             tasks.Enqueue("첫 번째 작업");
             tasks.Enqueue("두 번째 작업");
             tasks.Enqueue("세 번째 작업");


             Console.WriteLine("\n\n작업");
             while (tasks.Count > 0)
                 Console.WriteLine(tasks.Dequeue());


             Stack<int> numbers = new Stack<int>();
             numbers.Push(10);
             numbers.Push(20);
             numbers.Push(30);

             Console.WriteLine("\n\n숫자");
             while (numbers.Count > 0)
                 Console.WriteLine(numbers.Pop());

         }
     }*/


    /*class Program
    {
        static void Main(string[] args)
        {
            *//*  Q4)
                사용자로부터 "Hello, C# World!" 같은 문자열을 입력받아, 다음을 수행하세요.
                전체 문자열을 대문자로 변환
                "C#"을 "CSharp"으로 변경
                문자열의 길이 출력
            *//*
            Console.Write("문자열을 입력하세요! : ");
            string input = Console.ReadLine();

            string upperString = input.ToUpper();
            string replacedString = input.Replace("C#", "CSharp");
            int lengthString = input.Length;

            Console.WriteLine(upperString);
            Console.WriteLine(replacedString);
            Console.WriteLine(lengthString);


        }
    }*/


    class Program
    {
        static void Main(string[] args)
        {
            /*  Q4)
                int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }; 배열이 주어질 때,
                LINQ를 사용하여 짝수만 필터링하고 출력하세요.
                LINQ를 사용하여 모든 숫자의 합을 구하고 출력하세요.
            */

            int evenSum = 0, sum = 0;
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var evenNumbers = numbers.Where(n => n % 2 == 0);

            foreach(var num in evenNumbers)
            {
                Console.WriteLine(num);
                evenSum += num;
            }

            foreach(var num in numbers)
            {
                sum += num;
            }

            Console.WriteLine("모든 짝수의 합 : " + evenSum);
            Console.WriteLine("모든 수의 합 : " + sum);
        }
    }
}


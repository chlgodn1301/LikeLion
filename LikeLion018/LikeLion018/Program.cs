using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeLion018
{
    /*struct Rectangle
    {
        public int Width;
        public int Height;

        public int GetArea() => Width + Height;
    }

    struct Point
    {
        public int x;
        public int y;
    }*/


    struct Student
    {
        public string Name;
        public int Kor;
        public int Eng;
        public int Math;
        public void Print()
        {
            Console.WriteLine($"{Name,-5} {Kor,5} {Eng,5} {Math,5}");
                
        }


    }


        class Program
    {
        
        static void Main(string[] args)
        {
            //var rect = new Rectangle { Width = 5, Height = 4 };           
            //Console.WriteLine($"Area : {rect.GetArea()}");

            /*Rectangle rect;
            rect.Width = 10;
            rect.Height = 20;
            Console.WriteLine($"Area : {rect.GetArea()}");*/

            /*Point[] points = new Point[2];

            points[0].x = 10;
            points[0].y = 10;

            points[1].x = 20;
            points[1].y = 20;

            foreach (var point in points)
            {
                Console.WriteLine($"Point : ({point.x}, {point.y})");
            }*/

            // 구조체를 이용하여, 학생 3명의 이름과 성적을 받고 국어,영어, 수학 출력하기
            // 이름   국어  영어  수학
            // 홍길동  100   80    70
            // 홍길란   90   10    20
            // 홍길순   20   55    70

            Student[] students = new Student[3];

            for(int i = 0; i<3; i++)
            {
                Console.WriteLine("학생 성적을 입력하세요.");
                Console.Write("이름 : ");
                students[i].Name = Console.ReadLine();
                Console.Write("국어 : ");
                students[i].Kor = int.Parse(Console.ReadLine());
                Console.Write("영어 : ");
                students[i].Eng = int.Parse(Console.ReadLine());
                Console.Write("수학 : ");
                students[i].Math = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("이름       국어  영어  수학");
            foreach(Student std in students)
            {
                std.Print();
            }

        }
    }
}

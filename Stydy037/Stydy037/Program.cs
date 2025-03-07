using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stydy037
{
    class Person
    {
        public string Name; // 생성자
        public int Age;
        public Person()
        {
            Name = "Unknown";
            Age = 0;
        }

        public Person(string name)  // 오버라이딩
        {
            Name = name;
            Age = 0;
        }

        public Person(string name, int age)  // 오버라이딩
        {
            Name = name;
            Age = age;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();    // 오버라이딩 되어있으므로 Person() 안에 원하는 값 넣을시, 생성자 호출하여 입력값을 출력가능
            Person p1 = new Person("Bob");  // 1개짜리 매개변수 있는 생성자
            Person p2 = new Person("카타리나", 20); // 2개짜리 매개변수 있는 생성자

            Console.WriteLine(p.Name + ", " + p.Age);
            Console.WriteLine(p1.Name + ", " + p1.Age);
            Console.WriteLine(p2.Name + ", " + p2.Age);

        }
    }
}

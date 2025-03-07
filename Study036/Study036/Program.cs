using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study036
{
    class Person
    {
        private string name; // 필드 클래스의 데이터를 저장하는 멤버입니다.
        public void SetName(string n)
        {
            name = n;
        }
        public string GetName()
        {
            return name;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person(); // 객체로 만들기 인스턴스
            //p.name = "Alice";        // 필드에 값넣기
            //Console.WriteLine(p.name);
            p.SetName("Bob");
            Console.WriteLine(p.GetName());
        }
    }
}

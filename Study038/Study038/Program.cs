using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study038
{
    class MyResource
    {
        // 소멸자
        ~MyResource()
        {
            Console.WriteLine("삭제될 때 호출");
        }
    }


    class Program
    {
        // ref 포인터 개념 참조
        // 메서드 ref, out
        static void Increase(ref int x)
        {
            x++;
        }

        // out은 반환이 여러개일 때 유용하다.
        static void OutFunc (int a, int b, out int x, out int y)
        {
            x = a;
            y = b;
        }

        static void Main(string[] args)
        {
            /*MyResource r = new MyResource();
            //GC에 의해 나중에 소멸자 호출
            // 가비지 컬렉션은 더 이상 참조되지 않는 객체를 정리합니다.*/
            //==============================================================
            // ref
            /*int a = 10;
            Increase(ref a);

            Console.WriteLine("A의 값 : " + a);*/

            //==============================================================
            // out
            int a = 10;
            int b = 20;
            int x, y;
            OutFunc(a, b, out x, out y);
            Console.WriteLine("x : " + x + ", y : " + y);

        }
    }
}

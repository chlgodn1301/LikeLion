using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study030
{
    class Animal
    {
        public virtual void Speak()
        {
            Console.WriteLine("동물이 소리를 냅니다.");
        }
    }

    class Dog : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("멍멍!");
        }
        public void WagWail()
        {
            Console.WriteLine("꼬리를 흔든다.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Animal myAnimal = new Dog(); // 업캐스팅
            
            myAnimal.Speak();

            Dog d = (Dog)myAnimal;
            d.WagWail();
        }
    }
}

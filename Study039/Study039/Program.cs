﻿using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study039
{
    // 추상 클래스 (Abstract Class)?
    // 추상 클래스는 객체를 생성할 수 없는 클래스로, 상속을 통해서만 사용할 수 있습니다.
    // 공통적인 기능을 정의하고, 상속받은 클래스가 이를 구현하도록 강제할 떄 사용됩니다.
    // abstract 키워드를 사용
    // 추상 메서드는 선언만 하고, 구현은 하지 않습니다.
    abstract class Animal
    {
        // 추상 메서드 (구현x , 상속받은 클래스가 구현)
        public abstract void MakeSound();

        // 일반 메서드 (공통 기능 제공)
        public void Sleep()
        {
            Console.WriteLine("동물이 잠을 잡니다.");
        }
    }

    // 추상 클래스를 상속받아 구체적인 클래스 구현
    class Dog : Animal  // 알트 엔터(or 우클릭 -> 빠른 작업 및 리팩토링) -> 추상 클래스 구현 -> 자동으로 구현해줌
    {
        public override void MakeSound()
        {
            Console.WriteLine("멍멍!");
        }
    }

    class Cat : Animal 
    {
        public override void MakeSound()
        {
            Console.WriteLine("야옹!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Animal myDog = new Dog();
            myDog.MakeSound();  //멍멍
            myDog.Sleep();

            Animal myCat = new Cat();
            myCat.MakeSound();
            myCat.Sleep();

        }
    }
}

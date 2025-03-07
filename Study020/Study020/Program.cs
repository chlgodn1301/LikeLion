using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study020
{

    /*    class Person
        {
            public string Name;
            public int Age;
            *//*public void ShowInfo()
            {
                Console.WriteLine("이름 : " + name);
            }*//*

            // 기본 생성자
            // 클래스가 객체로 생성될 떄 자동으로 실행되는 특별한 메서드 (메서드가 곧 함수)
            // 클래스와 같은 이름을 가지며, 반환형이 없다 (void도 사용하지 않음)
            // 객체를 만들 시 필요한 초기값을 설정할 때 많이 사용함





            public Person(string name, int age)
            {
                Name = name;
                Age = age;
                //Console.WriteLine("기본 생성자가 실행됨");
                Console.WriteLine("매개변수가 있는 생성자가 실행됨");
            }
            public void ShowInfo()
            {
                Console.WriteLine($"이름 : {Name}, 나이 : {Age}");
            }

        }*/

    // 마린 클래스를 만드세요
    // 이름, 미네랄 = 50
    // 기본 생성자, 인자있는 생성자

    // SCV 클래스를 만드세요
    // 이름, 미네랄 = 50
    // 기본 생성자, 인자있는 생성자

    class Marine
    {
        public string unitName;
        public int costMineral;
        
        public Marine()
        {
            unitName = "마린";
            costMineral = 50;
        }

        public Marine(string _name, int _mineral)
        {
            unitName = _name;
            costMineral = _mineral;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"이름 : {unitName}, 미네랄 : {costMineral}");
        }

    }
    class SCV
    {
        public string unitName;
        public int costMineral;

        public SCV()
        {
            unitName = "SCV";
            costMineral = 50;
        }

        public SCV(string _name, int _mineral)
        {
            unitName = _name;
            costMineral = _mineral;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"이름 : {unitName}, 미네랄 : {costMineral}");
        }

    }

    // 배럭 클래스
    // this 키워드를 사용해보자 (this =  자기자신)
    class Barrack
    {
        public string buildName;
        public int costMineral;

        public Barrack()
        {
            buildName = "Barrack";
            costMineral = 150;
        }

        public Barrack(string _buildName, int _costMineral)
        {
            this.buildName = _buildName;
            this.costMineral = _costMineral;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"이름 : {buildName}, 미네랄 : {costMineral}");
        }

    }


    // 미네랄 클래스를 만드시오
    // Mineral 양은 1500
    // 7개가 있음
    class Mineral
    {
        public string objName;
        public int objAmount;
        public int MineralCount;

        public Mineral()
        {
            objName = "Mineral";
            objAmount = 1500;
            MineralCount = 1500;
        }
        public Mineral(string _objName, int _objAmount)
        {
            this.objName = _objName;
            this.objAmount = _objAmount;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"이름 : {objName}, 양 : {objAmount}");
            Console.WriteLine($"현재 미네랄 양 : {MineralCount}");
        }
    }

    // Game 클래스를 만들어보자

    class Game
    {
        public static int mineral;
        public static int gas;
        public static int charCount;

        public static void ShowInfo()
        {
            Console.WriteLine($"미네랄 : {mineral}, 가스 : {gas}, 인구수 : {charCount}");
        }
    }




    class Program
    {
        static void Main(string[] args)
        {
            // 클래스
            // 
            /*Person p1 = new Person("철수",25);       //객체 생성 instance
            p1.ShowInfo();
            Person p2 = new Person("영희",30);     
            p2.ShowInfo();*/


            /*Marine marine = new Marine("동료를 잃은 마린", 100);
            SCV scv = new SCV("분노한 SCV", 70);
            Barrack barrack = new Barrack();
            // 클래스의 배열
            Mineral[] mineral = new Mineral[7];
            
            // 각 배열에 new 객체화
            for(int i = 0; i<mineral.Length; i++)
            {
                mineral[i] = new Mineral();
                mineral[i].ShowInfo();
            }


            marine.ShowInfo();
            scv.ShowInfo();
            barrack.ShowInfo();*/

            Game.mineral = 50;
            Game.gas = 0;
            Game.charCount = 4;
            Game.ShowInfo();


        }
    }
}

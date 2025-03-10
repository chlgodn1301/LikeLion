using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPGExam
{
    public class Player
    {
        public INFO m_Info;

        // 데미지 입음
        public void SetDamage(int iAttack) { m_Info.Hp -= iAttack; }

        // 플레이어 정보 외부 조회
        public INFO GetInfo() { return m_Info; }

        // HP 재설정
        public void SetHp(int iHp) { m_Info.Hp = iHp; }


        // 직업 선택
        public void SelectClass()
        {
            m_Info = new INFO();

            Console.WriteLine("무의식 속에서 누군가의 목소리가 들려온다.");
            Console.ReadLine();
            Console.WriteLine("\"당신은 이 세계를 구하러온 용사.\"");
            Console.ReadLine();
            Console.WriteLine("\"끝까지 살아남아 마왕을 반드시 물리치세요.\"");
            Console.ReadLine();
            Console.WriteLine("곧 눈앞이 밝아졌고, 그 곳에는 롱소드, 스태프, 단검이 놓여져 있었다.");
            Console.ReadLine();

            Console.Clear();
            Console.WriteLine("<====================||====0");
            Console.WriteLine("클래스를 선택하세요!");
            Console.WriteLine("1. 전사");
            Console.WriteLine("2. 마법사");
            Console.WriteLine("3. 도적");
            Console.WriteLine("<====================||====0");

            int iInput = 0;
            iInput = int.Parse(Console.ReadLine());

            switch (iInput)
            {
                case 1:
                    m_Info.Name = "전사";
                    m_Info.Hp = 100;
                    m_Info.Attack = 10;
                    break;
                case 2:
                    m_Info.Name = "마법사";
                    m_Info.Hp = 90;
                    m_Info.Attack = 12;
                    break;
                case 3:
                    m_Info.Name = "도적";
                    m_Info.Hp = 80;
                    m_Info.Attack = 15;
                    break;
            }


        }

        public void Render()
        {
            Console.WriteLine("<====================||====0");
            Console.WriteLine("클래스 : " + m_Info.Name);
            Console.WriteLine($"체력 : {m_Info.Hp}\n공격력 : {m_Info.Attack}");
            Console.WriteLine("<====================||====0");
        }


    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPGExam
{
    class Field
    {
        Player m_Player = null;
        Monster m_Monster = null;


        public void SetPlayer(ref Player player) { m_Player = player; }
        public void DrawMap()
        {
            Console.WriteLine("1. 초원");
            Console.WriteLine("2. 던전");
            Console.WriteLine("3. 악마성");
            Console.WriteLine("4. 되돌아가기");
            Console.WriteLine("<====================||====0");
            Console.WriteLine("맵을 선택하세요 : ");
        }

        public void Create(string _strName, int _iHp, int _iAttack, out Monster pMonster)
        {
            pMonster = new Monster();  
            INFO tMonster = new INFO();

            tMonster.Name = _strName;    
            tMonster.Hp = _iHp;           
            tMonster.Attack = _iAttack;    

            pMonster.SetMonster(tMonster);  
        }

        public void CreateMonster(int input)
        {
            switch (input)
            {
                case 1:
                    //공장처럼 찍어내준다. 
                    //디자인패턴 팩토리 메서드 패턴
                    Create("토끼", 30, 3, out m_Monster);
                    break;
                case 2:
                    Create("스켈레톤", 60, 6, out m_Monster);
                    break;
                case 3:
                    Create("소악마", 90, 9, out m_Monster);
                    break;
            }


        }

        public void Fight()
        {
            int iInput = 0;
            while (true)
            {
                Console.Clear();        
                m_Player.Render();     // 플레이어 정보 출력
                m_Monster.Render();    // 몬스터 정보 출력

                Console.WriteLine("1. 공격\n2. 도망\n");
                iInput = int.Parse(Console.ReadLine());

                if (iInput == 1)
                {
                    // 플레이어 데미지 주기 (몬스터 공격력 기준 데미지)
                    m_Player.SetDamage(m_Monster.GetMonster().Attack);
                    // 몬스터 데미지 주기 (플레이어 공격력 기준 데미지)
                    m_Monster.SetDamage(m_Player.GetInfo().Attack);

                    if (m_Player.GetInfo().Hp <= 0)    //플레이
                    {
                        Console.Clear();
                        Console.WriteLine("눈앞이 하얘집니다...");
                        Console.WriteLine("당신은 사망했습니다.");
                        Environment.Exit(0);
                        //m_Player.SetHp(100);
                        //break;
                    }
                }

                if (iInput == 2 || m_Monster.GetMonster().Hp <= 0)
                {
                    m_Monster = null;
                    break;      // 탈출
                }
            }
        }

        public void Progress()
        {
            int iInput = 0;

            while (true)
            {
                Console.Clear();
                m_Player.Render();
                DrawMap();

                iInput = int.Parse(Console.ReadLine());

                if (iInput == 4)
                    break;
                if (iInput <= 3)
                {
                    CreateMonster(iInput);
                    Fight();
                }

            }
        }




    }
}

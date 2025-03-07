using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG
{
    public class Field
    {
        Player m_pPlayer = null;
        
        // 몬스터
        Monster m_pMonster = null;

        // 플레이어 MainGame에서 생성한 것 가져오기
        // 플레이어가 필드에서 전투를 하면? 데미지 입음 + HP깎임
        // ref 사용해보기?
        public void SetPlayer(ref Player pPlayer) { m_pPlayer = pPlayer; }

        public void Progress()
        {
            // 사냥터 입장
            int iInput = 0;

            while (true)
            {
                Console.Clear();
                m_pPlayer.Render();
                DrawMap();

                iInput = int.Parse(Console.ReadLine());

                if (iInput == 4) 
                    break;
                if (iInput <= 3)
                {
                    // 몬스터를 만들고 
                    // 1번일 때 초보 몬스터
                    // 2번일 때 중급 몬스터
                    // 3번일 때 고급 몬스터

                    CreateMonster(iInput);
                    // 싸운다
                    Fight();

                }

            }


        }
        //생성을 도와주는 함수
        //공장처럼 찍어낸다.
        //팩토리 메서드 패턴
        public void Create(string _strName, int _iHp, int _iAttack, out Monster pMonster)
        {
            pMonster = new Monster();   // 몬스터 생성
            INFO tMonster = new INFO(); // 몬스터 데이터 메모리 추가

            tMonster.strName = _strName;    // 각 몬스터별 (초,중,고)
            tMonster.iHp = _iHp;            // 체력
            tMonster.iAttack = _iAttack;    // 공격력

            pMonster.SetMonster(tMonster);  // 생성된 데이터 INFO 클래스 타입 이자로 데이터 세팅

        }

        public void CreateMonster(int input)
        {
            switch(input)
            {
                case 1:
                    //공장처럼 찍어내준다. 
                    //디자인패턴 팩토리 메서드 패턴
                    Create("초보몹", 30, 3, out m_pMonster);
                    break;
                case 2:                    
                    Create("중수몹", 60, 6, out m_pMonster);
                    break;
                case 3:                   
                    Create("고수몹", 90, 9, out m_pMonster);
                    break;
            }


        }
        public void Fight()
        {
            int iInput = 0;
            while (true)
            {
                Console.Clear();        // 콘솔 화면 지움
                m_pPlayer.Render();     // 플레이어 정보 출력
                m_pMonster.Render();    // 몬스터 정보 출력

                Console.WriteLine("1. 공격\n2. 도망\n");    // 1, 2 선택지 표시
                iInput = int.Parse(Console.ReadLine());

                if (iInput == 1)
                {
                    // 플레이어 데미지 주기 (몬스터 공격력 기준 데미지)
                    m_pPlayer.SetDamage(m_pMonster.GetMonster().iAttack);
                    // 몬스터 데미지 주기 (플레이어 공격력 기준 데미지)
                    m_pMonster.SetDamage(m_pPlayer.GetInfo().iAttack);

                    if (m_pPlayer.GetInfo().iHp <= 0)    //플레이
                    {
                        m_pPlayer.SetHp(100);
                        break;
                    }
                }

                if (iInput == 2 || m_pMonster.GetMonster().iHp <= 0)
                {
                    m_pMonster = null;
                    break;      // 탈출
                }
            }
        }


        public void DrawMap()
        {
            Console.WriteLine("1. 초보맵");
            Console.WriteLine("2. 중수맵");
            Console.WriteLine("3. 고수맵");
            Console.WriteLine("4. 되돌아가기");
            Console.WriteLine("==============");
            Console.WriteLine("맵을 선택하세요 : ");
        }


        public Field() { }
        ~Field() { }
    }
}

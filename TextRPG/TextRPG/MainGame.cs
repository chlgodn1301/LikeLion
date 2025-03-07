using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG.Properties
{
    class MainGame
    {
        public Player m_pPlayer = null;
        // 필드 객체
        public Field m_pField = null;

        public void Initialize()
        {
            // 플레이어 생성 및 직업 선택
            m_pPlayer = new Player();
            m_pPlayer.SelecdtJob();
        }


        // 게임의 전체적인 과정 관리
        public void Progress()
        {
            int iInput = 0;
            while (true)
            {
                Console.Clear();
                m_pPlayer.Render(); // 플레이어 출력
                Console.WriteLine("1. 사냥터\n2. 종료\n");
                iInput = int.Parse(Console.ReadLine());

                if (iInput == 2)
                    break;

                if (iInput == 1)
                {
                    // 사냥터 구현
                    if (m_pField == null)
                    {
                        m_pField = new Field();
                        // 필드로 갈 떄 플레이어 넣어주기
                        m_pField.SetPlayer(ref m_pPlayer);
                    }
                    m_pField.Progress();
                }

            }


        }
        public MainGame() { }
        ~MainGame() { }
    }
}

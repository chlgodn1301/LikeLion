using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TextRPGExam
{
    class MainGame
    {
        public Player m_Player = null;
        public Field m_Field = null;

        public void Initialize()
        {
            m_Player = new Player();
            m_Player.SelectClass();
        }

        public void Progress()
        {
            int iInput = 0;
            while (true)
            {
                Console.Clear();
                m_Player.Render();
                Console.WriteLine("1. 사냥터로 간다.");
                Console.WriteLine("2. 여관으로 간다.");
                Console.WriteLine("3. 종료한다.");
                Console.WriteLine("<====================||====0");
                iInput = int.Parse(Console.ReadLine());

                if (iInput == 3)
                    break;

                if (iInput == 1)
                {
                    if (m_Field == null)
                    {
                        m_Field = new Field();
                        m_Field.SetPlayer(ref m_Player);
                    }
                    m_Field.Progress();

                }
            }
        }


    }
}

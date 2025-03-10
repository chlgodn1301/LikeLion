using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPGExam
{
    public class Monster
    {
        public INFO m_Monster;

        public void SetDamage(int iAttack) { m_Monster.Hp -= iAttack; }

        public void SetMonster(INFO monster) { m_Monster = monster; }
        public INFO GetMonster() { return m_Monster; }

        public void Render()
        {
            Console.WriteLine("몬스터 이름 : " + m_Monster.Name);
            Console.WriteLine($"체력 : {m_Monster.Hp}\n공격력 : {m_Monster.Attack}");
            Console.WriteLine("<====================||====0");
        }
    }
}

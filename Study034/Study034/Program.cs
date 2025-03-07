using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SkillSystem
{
    class Unit
    {
        public string Name;
        protected int Health;

        public Unit()
        {
            Name = "Unknown";
            Health = 0;
        }


        public virtual void Attack()
        {
            Console.WriteLine($"{Name}이(가) 기본 공격을 합니다.");
        }
        public virtual void Heal(Unit target)
        {
            Console.WriteLine($"{Name}은(는) 치료할 수 있습니다.");
        }

        public virtual void Move()
        {
            Console.WriteLine($"{Name}이(가) 이동합니다.");
        }


    }

    // SCV 유닛 (건설과 수리 기능)
    class SCV : Unit
    {
        public SCV()
            {
                Name = "SCV";
                Health = 60;
            }
    
        public override void Attack()
        {
            Console.WriteLine("SCV가 용접기로 공격합니다! (공격력 약함)");
        }
        public override void Heal(Unit target)
        {
            Console.WriteLine($"SCV가 {target.Name}을 수리합니다. (기계 유닛만 가능)");
        }

    }

    //Marin 유닛(총기 공격)
    class Marin : Unit
    {
        public Marin()
        {
            Name = "Marine";
            Health = 40;
        }

        public override void Attack()
        {
            Console.WriteLine("Marin이 소총으로 공격합니다.");
        }
    }


    class Medic : Unit
    {
        public Medic()
        {
            Name = "Medic";
            Health = 50;
        }

        public override void Heal(Unit target)
        {
            Console.WriteLine($"Medic이 {target.Name}을 치료합니다. (생명 유닛만 가능)");
        }
    }

    // Tank 유닛 (강력한 공격)
    class Tank : Unit
    {
        public Tank()
        {
            Name = "Tank";
            Health = 150;
        }
        public override void Attack()
        {
            Console.WriteLine("Tank가 시즈 모드로 강력한 포격!");
        }
        public override void Move()
        {
            Console.WriteLine("탱크가 천천히 움직입니다.");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Champion> champions = new List<Champion>()
        {
            new Garen(), new Darius(), new Lux(), new Katarina()
        };

            Console.WriteLine("플레이어의 챔피언을 선택하세요:");
            for (int i = 0; i < champions.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {champions[i].Name}");
            }
            int playerChoice = int.Parse(Console.ReadLine()) - 1;
            Champion player = champions[playerChoice];

            Console.WriteLine("상대 챔피언을 선택하세요:");
            for (int i = 0; i < champions.Count; i++)
            {
                if (i != playerChoice)
                    Console.WriteLine($"{i + 1}. {champions[i].Name}");
            }
            int enemyChoice = int.Parse(Console.ReadLine()) - 1;
            Champion enemy = champions[enemyChoice];

            Console.WriteLine($"{player.Name} vs {enemy.Name} 전투 시작!");

            while (true)
            {
                Console.Clear();
                Console.WriteLine($"{player.Name} HP: {player.Health}, MP: {player.Mana}");
                Console.WriteLine($"{enemy.Name} HP: {enemy.Health}, MP: {enemy.Mana}\n");
                Console.WriteLine("1. 기본 공격\n2. Q 스킬\n3. W 스킬\n4. E 스킬\n5. R 스킬");
                Console.Write("공격 방법을 선택하세요: ");
                int action = int.Parse(Console.ReadLine());

                switch (action)
                {
                    case 1:
                        player.PressA(enemy);
                        break;
                    case 2:
                        player.PressQ();
                        break;
                    case 3:
                        player.PressW();
                        break;
                    case 4:
                        player.PressE();
                        break;
                    case 5:
                        player.PressR();
                        break;
                    default:
                        Console.WriteLine("잘못된 입력입니다!");
                        continue;
                }

                if (enemy.Health <= 0)
                {
                    Console.WriteLine($"{enemy.Name}이(가) 쓰러졌습니다! {player.Name} 승리!");
                    break;
                }

                Thread.Sleep(1000);
                Console.WriteLine($"{enemy.Name}의 반격!");
                enemy.PressA(player);

                if (player.Health <= 0)
                {
                    Console.WriteLine($"{player.Name}이(가) 쓰러졌습니다! {enemy.Name} 승리!");
                    break;
                }

                Thread.Sleep(1000);
            }
            Console.WriteLine("게임 종료");
        }
    }

    /*class Program
    {
        static void Main(string[] args)
        {
            List<Unit> units = new List<Unit>();
            units.Add(new SCV());
            units.Add(new Marin());
            units.Add(new Medic());
            units.Add(new Tank());

            // 모든 유닛 순회하며 다형성 적용

            foreach (var Unit in units)
            {
                Unit.Move();
                Unit.Attack();
                Console.WriteLine();
            }

            //SCV 탱크 수리 시도
            SCV scv = new SCV();
            scv.Heal(units[3]); // 탱크 수리

            //Medic이 Marin 치료 시도
            Medic medic = new Medic();
            medic.Heal(units[1]);   //  Marin을 치료

        }
    }*/
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OverridePractice_250305
{
    class Champion
    {
        private Skill[] skills;
        public string Name, SkillQ, SkillW, SkillE, SkillR;
        public int Health, Mana;

        public Champion()
        {
            Name = "Unknown";
            Health = 0;
            Mana = 0;
            skills = new Skill[]
            {
                new Skill("",0,0,0),  // 마나소모 0, 쿨다운 8초
                new Skill("",0,0,0),  // 마나소모 5, 쿨다운 10초
                new Skill("",0,0,0),  // 마나소모 0, 쿨다운 10초
                new Skill("",0,0,0)  // 마나소모 0, 쿨다운 60초
            };
        }

        public virtual void PressA(Champion target)
        {
            Console.WriteLine($"{Name}이(가) 기본 공격을 사용합니다.");
        }

        public virtual void PressQ()
        {
            Console.WriteLine($"{Name}가 {skills[0].Name}을 사용합니다!");
        }
        public virtual void PressW()
        {
            Console.WriteLine($"{Name}가 {skills[1].Name}를 사용합니다!");
        }
        public virtual void PressE()
        {
            Console.WriteLine($"{Name}가 {skills[2].Name}를 사용합니다!");
        }
        public virtual void PressR()
        {
            Console.WriteLine($"{Name}가 {skills[3].Name}을 사용합니다!");
        }


    }

    // Garen 유닛
    class Garen : Champion
    {
        private Skill[] skills;
        public Garen()
            {
                Name = "가렌";
                Health = 180;
                Mana = 0;
                skills = new Skill[]
                {
                    new Skill("결정타",0,8,30),  // 마나소모 0, 쿨다운 8초
                    new Skill("용기",0,20,-20),  // 마나소모 5, 쿨다운 10초
                    new Skill("심판",0,12,50),  // 마나소모 0, 쿨다운 10초
                    new Skill("데마시아의 정의",0,60,80)  // 마나소모 0, 쿨다운 60초
                };
            }

        public override void PressQ()
        {
            Console.WriteLine($"{Name}가 {skills[0].Name}을 사용합니다!");
        }
        public override void PressW()
        {
            Console.WriteLine($"{Name}가 {skills[1].Name}를 사용합니다!");
        }
        public override void PressE()
        {
            Console.WriteLine($"{Name}가 {skills[2].Name}를 사용합니다!");
        }
        public override void PressR()
        {
            Console.WriteLine($"{Name}가 {skills[3].Name}을 사용합니다!");
        }
        public override void PressA(Champion target)
        {
            Console.WriteLine($"{Name}이 일반 공격으로 {target.Name}을(를) 공격합니다.");
        }

    }

    // Darius 유닛
    class Darius : Champion
    {
        private Skill[] skills;
        public Darius()
        {
            Name = "다리우스";
            Health = 180;
            Mana = 150;
            skills = new Skill[]
            {
                new Skill("학살",40,8,50),  // 마나소모 20, 쿨다운 3초
                new Skill("마비의 일격",20,5,30),  // 마나소모 15, 쿨다운 2초
                new Skill("포획",30,11,0),  // 마나소모 30, 쿨다운 5초
                new Skill("녹서스의 단두대",50,60,80)  // 마나소모 30, 쿨다운 5초
            };
        }

        public override void PressQ()
        {
            Console.WriteLine($"{Name}가 {skills[0].Name}을 사용합니다!");
        }
        public override void PressW()
        {
            Console.WriteLine($"{Name}가 {skills[1].Name}를 사용합니다!");
        }
        public override void PressE()
        {
            Console.WriteLine($"{Name}가 {skills[2].Name}를 사용합니다!");
        }
        public override void PressR()
        {
            Console.WriteLine($"{Name}가 {skills[3].Name}을 사용합니다!");
        }
        public override void PressA(Champion target)
        {
            Console.WriteLine($"{Name}가 일반 공격으로 {target.Name}을(를) 공격합니다.");
        }

    }


    // Lux 유닛
    class Lux : Champion
    {
        private Skill[] skills;
        public Lux()
        {
            Name = "럭스";
            Health = 80;
            Mana = 200;
            skills = new Skill[]
            {
                new Skill("빛의 속박", 30, 7, 40),  // 마나소모 20, 쿨다운 3초
                new Skill("프리즘 보호막", 20, 10, -30),  // 마나소모 15, 쿨다운 2초
                new Skill("광휘의 특이점", 50, 15, 70),  // 마나소모 30, 쿨다운 5초
                new Skill("최후의 섬광", 100, 60, 100)  // 마나소모 30, 쿨다운 5초
            };
        }

        public override void PressQ()
        {
            Console.WriteLine($"{Name}가 {skills[0].Name}을 사용합니다!");
        }
        public override void PressW()
        {
            Console.WriteLine($"{Name}가 {skills[1].Name}를 사용합니다!");
        }
        public override void PressE()
        {
            Console.WriteLine($"{Name}가 {skills[2].Name}를 사용합니다!");
        }
        public override void PressR()
        {
            Console.WriteLine($"{Name}가 {skills[3].Name}을 사용합니다!");
        }
        public override void PressA(Champion target)
        {
            Console.WriteLine($"{Name}가 일반 공격으로 {target.Name}을(를) 공격합니다.");
        }

    }



    // Katarina 유닛
    class Katarina : Champion
    {
        private Skill[] skills;
        public Katarina()
        {
            Name = "카타리나";
            Health = 100;
            Mana = 0;
            skills = new Skill[]
            {
                new Skill("단검 투척",0,8,40),  // 마나소모 0, 쿨다운 8초
                new Skill("준비",0,10,0),  // 마나소모 5, 쿨다운 10초
                new Skill("순보",0,12,10),  // 마나소모 0, 쿨다운 10초
                new Skill("죽음의 연꽃",0,60,80)  // 마나소모 0, 쿨다운 60초
            };
        }

        public override void PressQ()
        {
            Console.WriteLine($"{Name}가 {skills[0].Name}을 사용합니다!");
        }
        public override void PressW()
        {
            Console.WriteLine($"{Name}가 {skills[1].Name}를 사용합니다!");
        }
        public override void PressE()
        {
            Console.WriteLine($"{Name}가 {skills[2].Name}를 사용합니다!");
        }
        public override void PressR()
        {
            Console.WriteLine($"{Name}가 {skills[3].Name}을 사용합니다!");
        }
        public override void PressA(Champion target)
        {
            Console.WriteLine($"{Name}가 일반 공격으로 {target.Name}을(를) 공격합니다.");
        }

    }

    class Skill
    {
        public string Name; // 스킬 이름
        public int ManaCost; // 마나 소모량
        public int Cooldown;    // 재사용 대기 시간(밀리초)
        public int LastUsedTime;    // 마지막 사용 시간 (TickCount 기준)
        public int Damage; // 데미지

        public Skill(string name, int manaCost, int cooldown, int damage)
        {
            Name = name;
            ManaCost = manaCost;
            Cooldown = cooldown * 1000;// 초를 밀리초로 변환
            Damage = damage;
            LastUsedTime = 0;   // 처음엔 사용하지 않은 상태
        }


        // 스킬 사용 가능 여부 확인
        public bool CanUse(int playerMana)
        {
            int currentTime = Environment.TickCount;

            if (playerMana < ManaCost)
            {
                Console.WriteLine($" 마나가 부족합니다 ! (필요 MP : {ManaCost})");
                return false;
            }
            if (currentTime - LastUsedTime < Cooldown)
            {
                int remainingTime = (Cooldown - (currentTime - LastUsedTime)) / 1000;
                Console.WriteLine($" {Name} 스킬은 아직 사용할 수 없습니다. (남은 시간 : {remainingTime}초)");
                return false;
            }

            return true;

        }


        //스킬 사용
        public void Use(ref int playerMana)
        {
            if (!CanUse(playerMana)) return;

            playerMana -= ManaCost; // 플레이어 마나 참조로 외부 값도 같이 조정 동기화
            LastUsedTime = Environment.TickCount;   // 현재 시간을 저장

            Console.WriteLine($"{Name} 스킬 사용! (MP -{ManaCost})");
        }
    }





    /class Program
    {
        static void Main(string[] args)
        {
            List<Champion> Champions = new List<Champion>();
            Champions.Add(new Garen());
            Champions.Add(new Darius());
            Champions.Add(new Lux());
            Champions.Add(new Katarina());

            // 모든 유닛 순회하며 다형성 적용

            foreach (var Champion in Champions)
            {
                Champion.PressE();
                Champion.PressQ();
                Console.WriteLine();
            }

            //Garen 탱크 수리 시도
            Garen Garen = new Garen();
            Garen.PressA(Champions[3]); // 탱크 수리

            //Medic이 Marin 치료 시도
            Darius darius = new Darius();
            darius.PressA(Champions[1]);   //  Marin을 치료





            int playerMana = Garen(skills[1]);   // 플레이어의 초기 마나

            while (true)
            {
                Console.Clear();
                Console.WriteLine($"현재 MP : {playerMana}");
                Console.WriteLine("사용 가능한 스킬 : ");
                for (int i = 0; i < skills.Length; i++)
                {
                    Console.WriteLine($"{i + 1}.{skills[i].Name}(MP {skills[i].ManaCost})" + $", 쿨다운 {skills[i].Cooldown / 1000}s");
                }
                Console.WriteLine("0.종료");
                Console.WriteLine("사용할 스킬 번호를 입력하세요 : ");

                try
                {
                    int skillIndex = int.Parse(Console.ReadLine());
                    if (skillIndex == 0) break;
                    if (skillIndex > 0 && skillIndex <= skills.Length)
                    {
                        skills[skillIndex - 1].Use(ref playerMana);
                    }
                    else
                    {
                        Console.WriteLine("잘못된 입력 값입니다.");
                    }
                }
                catch
                {
                    Console.WriteLine("숫자를 입력하세요!");
                }

                Thread.Sleep(500);  // CPU 과부하 방지

            }
            Console.WriteLine("게임 종료");


        }
    }

    


}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study042
{
    class Warrior : GameCharacter
    {
        public Warrior(string name) : base(name, 100, 15, 10)
        {
        }

        public override void BasicAttack(GameCharacter target)
        {
            Console.WriteLine($"{Name}이 {target.Name}에게 기본 공격을 시도합니다.!");
            target.TakeDamage(Attack);
        }

        public override void SpecialAttack(GameCharacter target)
        {
            Console.WriteLine($"{Name}이 {target.Name}에게 휠윈드 시전합니다.");
            target.TakeDamage(Attack * 2);
        }


    }
}

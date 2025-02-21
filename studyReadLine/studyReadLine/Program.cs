using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studyReadLine
{
    class Program
    {
        static void Main(string[] args)
        {
            // 사용자 입력을 문자열 받기
            /*Console.Write("이름을 입력하세요 : ");
            string userName = Console.ReadLine();   // 사용자로부터 입력 받기

            Console.WriteLine($"안녕하세요, {userName}님!");


            // 문자열을 정수로 변환
            Console.Write("나이를 입력하세요 : ");
            string input = Console.ReadLine();  // 사용자로부터 입력 받기
            int age = int.Parse(input);         // 문자열을 정수로 변환

            Console.WriteLine($"내년에는 {age + 1} 살이 되겠군요!");  // 변환된 값 사용
            Console.WriteLine("내년에는 " + age + "살이 되겠군요!");
            Console.WriteLine("내년에는 {0}살이 되겠군요!", age);*/



            // =================================================================================

            // 해당 스샷 내용

            // 루인 스킬 피해
            // 카드 게이지 획득량
            // 각성기 피해
            // 최대 마나
            // 전투 중 마나 회복량
            // 비전투 중 마나 회복량
            // 이동 속도
            // 탈 것 속도
            // 운반 속도
            // 스킬 재사용 대기시간 감소

            float Ruin_Damage = 0.0f;
            float Card_Gage = 0.0f;
            float Ult_Damage = 0.0f;
            int Max_Mana = 0;
            int Combat_On_ManaRegen = 0;
            int Combat_Off_ManaRegen = 0;
            float Move_Speed = 0.0f;
            float Vehicle_Speed = 0.0f;
            float Carry_Speed = 0.0f;
            float Cooldown = 0.0f;

            Console.Write("루인 스킬 피해 : ");
            Ruin_Damage = float.Parse(Console.ReadLine());  

            Console.Write("카드 게이지 획득량 : ");
            Card_Gage = float.Parse(Console.ReadLine());    

            Console.Write("각성기 피해 : ");
            Ult_Damage = float.Parse(Console.ReadLine());    

            Console.Write("최대 마나 : ");
            Max_Mana = int.Parse(Console.ReadLine());   

            Console.Write("전투 중 마나 회복량 : ");
            Combat_On_ManaRegen = int.Parse(Console.ReadLine());    

            Console.Write("비전투 중 마나 회복량 : ");
            Combat_Off_ManaRegen = int.Parse(Console.ReadLine());    

            Console.Write("이동 속도 : ");
            Move_Speed = float.Parse(Console.ReadLine());    

            Console.Write("탈 것 속도 : ");
            Vehicle_Speed = float.Parse(Console.ReadLine());    

            Console.Write("운반 속도 : ");
            Carry_Speed = float.Parse(Console.ReadLine());    

            Console.Write("스킬 재사용 대기시간 감소 : ");
            Cooldown = float.Parse(Console.ReadLine());    

            Console.Clear();

            Console.WriteLine("활동                                  ▼");
            Console.WriteLine($"루인 스킬 피해                     : {Ruin_Damage}%");
            Console.WriteLine($"카드 게이지 획득량                 : {Card_Gage}%");
            Console.WriteLine($"각성기 피해                        : {Ult_Damage}%");
            Console.WriteLine($"최대 마나                          : {Max_Mana}");
            Console.WriteLine($"전투 중 마나 회복량                : {Combat_On_ManaRegen} ");
            Console.WriteLine($"비전투 중 마나 회복량              : {Combat_Off_ManaRegen} ");
            Console.WriteLine($"이동 속도                          : {Move_Speed}%");
            Console.WriteLine($"탈 것 속도                         : {Vehicle_Speed}%");
            Console.WriteLine($"운반 속도                          : {Carry_Speed}%");
            Console.WriteLine($"스킬 재사용 대기시간 감소          : {Cooldown}%");



        }
    }
}

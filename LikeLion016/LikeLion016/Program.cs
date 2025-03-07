using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeLion016
{
    class Program
    {

        // Eunmeration enum
        // 숫자 앞에 이름을 부여하는 자료형
        // 가독성을 높이고, 의미있는 값으로 표현 가능
        // 기본적으로 첫 번째 값은 0부터 시작하며 1씩 증가

        // 기본적인 enum사용법
        enum DayofWeek
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }

        // 2. enum 값 변경 (0부터 시작하지 않기)
        enum StatusCode
        {
            Success = 200,
            BadRequest = 400,
            Unauthorized = 401,
            NotFound = 404
        }

        enum WeaponType
        {
            Sword,
            Bow,
            Staff
        }

        static void ChooseWeapon(WeaponType weapon)
        {
            if (weapon == WeaponType.Sword)
            {
                Console.WriteLine("검을 선택했습니다.");
            }
            else if (weapon == WeaponType.Bow)
            {
                Console.WriteLine("활을 선택했습니다.");
            }
            else if (weapon == WeaponType.Staff)
            {
                Console.WriteLine("지팡이를 선택했습니다.");
            }
        }
       
        static void Main(string[] args)
        {
            /*// Math 클래스 사용
            // 수학적 계산
            Console.WriteLine($"Pi : {Math.PI}");                       // 파이
            Console.WriteLine($"Square root of 25 : {Math.Sqrt(25)}");  // 루트
            Console.WriteLine($"Power (2^3) : {Math.Pow(2, 3)}");       // 제곱근
            Console.WriteLine($"Round(3.75) : {Math.Round(3.75)}");     // 반올림*/


            /*DayofWeek today = DayofWeek.Wednesday;

            // 숫자를 직접 사용하지 않고, 의미있는 이름으로 관리 가능
            Console.WriteLine(today);
            Console.WriteLine((int)today);

            StatusCode status = StatusCode.NotFound;
            Console.WriteLine(status);*/


            // 문제
            // 열거형과 함수를 이용해서 풀어주세요.
            // Weapontype.Sword 검을 선택했습니다.
            // Weapontype.Bow 활을 선택했습니다.
            // Weapontype.Staff 지팡이를 선택했습니다.

            // ChooseWeapon(WeaponType.Bow);    //출력 : 활을 선택했습니다.


            ChooseWeapon(WeaponType.Bow);

        }

        


    }
}

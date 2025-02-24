using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeLion08
{
    class Program
    {
        static void Main(string[] args)
        {

            //이진수를 정수로 변환
            /*Console.Write("2진수를 입력하세요 : ");
            string binaryInput = Console.ReadLine();
            int decimalValue = Convert.ToInt32(binaryInput, 2); // 2진수 -> 10진수 변환*/

            // 정수를 이진수로 변환
            /*string binaryOutput = Convert.ToString(decimalValue, 2);       // 10진수 -> 2진수 변환

            Console.WriteLine($"입력한 이진수 : {binaryInput}");
            Console.WriteLine($"10진수로 변환 : {decimalValue}");
            Console.WriteLine($"다시 이진수로 변환 : {binaryOutput}");*/


            //===================================================
            // var를 사용하여 변수 선언 (컴파일러가 변수의 데이터형식을 자동으로 추론, 선언시 반드시 초기화해야함)
            /*var name = "Alice";     // 문자열로 추론
            var age = 25;           // 정수로 추론
            var isStudent = true;   //논리값으로 추론

            Console.WriteLine($"이름 : {name}, 나이 : {age}, 학생 여부 : {isStudent}");*/



            //===================================================
            // default 키워드를 사용한 기본값 설정 (ex : 숫자는 0, 문자열은 null, 논리값은 false
            /*int defaultInt = default;       // 기본값 : 0
            string defaultString = default; // 기본값 : null
            bool defaultBool = default;     // 기본값 : false

            Console.WriteLine($"정수 기본값 : {defaultInt}");        // 출력 : 0
            Console.WriteLine($"문자열 기본값 : {defaultString}");   // 출력 : (null)
            Console.WriteLine($"논리값 기본값 : {defaultBool}");     // 출력 : False*/



            //===================================================
            // 연산자는 값을 계산하거나 조작할 때 사용
            // 단항, 산술, 관계형, 논리, 비트 연산자 등 다양한 종류
            // 오른쪽부터 계산됨

            /*int a = 5, b = 3;
            int sum = 0;
            sum = a + b;    // 합 산술 연산자 사용
            Console.WriteLine($"합 : {sum}");    // 출력 : 8
            sum = a - b;    // 차 산술 연산자 사용
            Console.WriteLine($"차 : {sum}");    // 출력 : 2
            sum = a * b;    // 곱 산술 연산자 사용
            Console.WriteLine($"곱 : {sum}");    // 출력 : 15
            sum = a / b;    // 몫 산술 연산자 사용
            Console.WriteLine($"몫 : {sum}");    // 출력 : 1
            sum = a % b;    // 나머지 연산자 사용
            Console.WriteLine($"나머지 : {sum}");    // 출력 : 2



            bool isEqual = (a == b);    // 관계형 연산자 사용
            Console.WriteLine($"a와 b가 같은가? : {isEqual}");    // 출력 : False*/

            /*int number = 7;

            int sum = 0;
            sum = number % 2;       // 0 나오면 짝수 1 나오면 홀수
            Console.WriteLine("짝수 홀수 판별 : " + sum);*/

            /*bool isEqual = false;   // 거짓 0
            int a = 5;
            int b = 2;

            // 관계형 연산자
            isEqual = (a == b); // a와 b가 같은가?

            Console.WriteLine("같은가? : " + isEqual);*/

            //===================================================
            // 단항 연산자





        }
    }
}

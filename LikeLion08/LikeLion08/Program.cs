using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Policy;
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

            /*int number = 5;
            bool flag = true;

            Console.WriteLine(+number); // 양수출력 : 5
            Console.WriteLine(-number); // 음수출력 : -5

            Console.WriteLine(!flag); // 논리 부정 : False*/

            // ~ 비트 반전
            // 10   1010
            //      0101

            /* int num = 10;
             int result = ~num;  // 모든 비트 반전 : 1111 0101 
             Console.WriteLine("기존 값 : " + num);
             Console.WriteLine("변환 값 : " + result);*/



            //===================================================
            // 캐스팅
            /*double pi = 3.14;
            int integerPi = (int)pi;    // 실수형 => 정수형으로 변환

            Console.WriteLine(integerPi);   // 출력 : 3*/

            /*int iKor = 90;
            int iEng = 75;
            int iMath = 58;

            int sum = 0;
            float average = 0.0f;

            sum = iKor + iEng + iMath;

            average = (float)sum / 3;  // 평균
            

            Console.WriteLine("총점 : " + sum);
            Console.WriteLine("평균 : " + average);*/

            /*int a = 10, b = 3;

            Console.WriteLine(a + b);
            Console.WriteLine(a - b);
            Console.WriteLine(a * b);
            Console.WriteLine(a / b);
            Console.WriteLine(a % b);*/




            //===================================================
            // 문자열 연결 연산자

            /*string firstName = "Alice";
            string lastName = "Smith";

            Console.WriteLine(firstName + " " +  lastName); // 출력*/



            //===================================================
            // 할당 연산자 - 값을 변수에 저장

            /*int a = 10;
            a += 5; // a = a + 5
            Console.WriteLine(a);   //출력 : 15
            a -= 5; // a = a + 5
            Console.WriteLine(a);   //출력 : 10
            a *= 5; // a = a + 5
            Console.WriteLine(a);   //출력 : 50
            a /= 5; // a = a + 5
            Console.WriteLine(a);   //출력 : 10
            a %= 5; // a = a + 5
            Console.WriteLine(a);   //출력 : 0*/



            //===================================================

            /*
             * 문제 1. 학점 평균 계산 프로그램
                설명:
                국어, 영어, 수학 점수를 사용자로부터 입력받아 총점과 평균을 구하는 프로그램을 작성하세요.
                요구사항:

                각 과목의 점수는 정수형으로 입력받습니다.
                총점을 구한 후, 평균을 계산할 때 정수형 총점을 실수형으로 캐스팅하여 소수점까지 정확하게 계산합니다.
                평균은 소수점 둘째 자리까지 출력하세요.

                문제 2. 비트 반전(~) 연산자 활용 프로그램
                설명:
                사용자로부터 정수를 입력받아, 해당 정수의 모든 비트를 반전(~)한 결과를 출력하는 프로그램을 작성하세요.
                요구사항:

                정수를 입력받습니다.
                비트 반전 연산자(~)를 이용하여 입력된 정수의 비트를 반전합니다.
                원래의 값과 비트 반전 후의 값을 함께 출력합니다
             */

            /*// Q1
            int scKor, scEng, scMath, scSum;
            double scAvg;
            Console.WriteLine("Q1)");
            Console.Write("국어 점수를 입력하세요! : ");
            scKor = int.Parse(Console.ReadLine());
            Console.Write("영어 점수를 입력하세요! : ");
            scEng = int.Parse(Console.ReadLine());
            Console.Write("수학 점수를 입력하세요! : ");
            scMath = int.Parse(Console.ReadLine());

            scSum = scKor + scEng + scMath;
            scAvg = (float)scSum / 3;

            Console.WriteLine("합계 : " + scSum);
            Console.WriteLine("평균 : " + scAvg.ToString("F2"));


            //Q2
            Console.WriteLine("\nQ2)");
            int num, bit;
            Console.Write("정수를 입력하세요! : ");
            num = int.Parse(Console.ReadLine());
            bit = ~num;
            Console.WriteLine("기존 값 : " + num);
            Console.WriteLine("변환 값 : " + bit);*/



            //===================================================
            // 증감 연산자

            /*int b = 3;

            // 전위
            ++b;
            Console.WriteLine(b);   // 출력 : 4

            ++b;
            Console.WriteLine(b);   // 출력 : 5
            Console.WriteLine(++b);   // 출력 : 6
            Console.WriteLine(b++);   // 출력 : 6  - 후위이므로, 더해지는게 나중이 됨
            Console.WriteLine(b);   // 출력 : 7*/


            //===================================================
            // 관계형 연산자
            // ==, !=, <, >, <=, >=

            /*int x = 5, y = 10;
            Console.WriteLine(x < y);   // 출력 : True
            Console.WriteLine(x == y);   // 출력 : False
            Console.WriteLine(x < y);   // 출력 : True
            Console.WriteLine(x > y);   // 출력 : False
            Console.WriteLine(x >= y);  // 출력 : False
            Console.WriteLine(x <= y);  // 출력 : True*/



            //===================================================
            // 논리 연산자

            /*bool a = true;
            bool b = false;

            Console.WriteLine(a && b);
            Console.WriteLine(a || b);

            b = a;
            Console.WriteLine(b);*/


            //===================================================
            // 비트 연산자

            /*int x = 5; // 0101
            int y = 3; // 0011

            Console.WriteLine(x & y);   // AND : 1 (0001)
            Console.WriteLine(x | y);   // OR :  7 (0111)
            Console.WriteLine(x ^ y);   // XOR :  6 (0110)  
            Console.WriteLine(~x);   // NOT :  -6 (-1010)
            Console.WriteLine(~y);   // NOT :  -4 (-100)*/

            /*int value = 4;  // 0100

            Console.WriteLine(value << 1);  // 왼쪽이동 : 8 (1000)
            Console.WriteLine(value >> 1);  // 왼쪽이동 : 2 (0010)*/


            //===================================================
            // 삼항 연산자 
            /*int a = 10, b = 20;
            int max;

            max = (a < b) ? a : b;  // 삼항 연산자
            // (비교) ? 참 : 거짓;

            Console.WriteLine(max);*/

            /*int key = 1;
            string str;

            str = (key == 1) ? "문이 열렸습니다." : "문을 못 열었습니다.";

            Console.WriteLine(str);*/

            /*int result = 10 + 2 * 5;            // 곱셈이 덧셈보다 먼저
            Console.WriteLine(result);          // 출력 : 20

            int adjustedResult = (10 + 2) * 5;  //괄호 우선순위 먼저 계산
            Console.WriteLine(adjustedResult);  // 출력 : 60*/


            //===================================================
            // 제어문

            /*int score = 85;

            if (score >= 90)
            {
                Console.WriteLine("A학점");
            }
            else
            {
                Console.WriteLine("B학점");
            }*/
            /*if(true)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }*/
            /*string gameID = "멋사검존";

            if(gameID == "멋사검존")
            {
                Console.WriteLine("아이디가 일치합니다.");
            }
            else
            {
                Console.WriteLine("아이디가 일치하지 않습니다.");
            }*/

            /*int score = 75;
            if(score >= 90)
            {
                Console.WriteLine("A 학점");
            }
            else if(score >= 80)
            {
                Console.WriteLine("B 학점");
            }
            else if(score >= 70)
            {
                Console.WriteLine("C 학점");
            }
            else
            {
                Console.WriteLine("F 학점");
            }*/


            // 1단계
            // 가지고 있는 소지금을 입력하세요 : 
            // 0~100 무한의 대검 +1
            // 101~200 카타나 +2
            // 201~300 진은검 +3
            // 301~400 집판검 +4
            // 401~500 엑스칼리버 +5
            // 501~600 유령검 +6
            // 601~ 전설의 검+7

            // 2단계
            // 캐릭터 이름 : 
            // 무기 : 가지고 있는 무기 이름 표시
            // ex) 공격력 : 100 + 1


            /*int money, atk = 100;
            string name, weapon = "";

            Console.Write("캐릭터 이름 : ");
            name = Console.ReadLine();
            Console.Write("가지고 있는 소지금을 입력하세요 : ");
            money = int.Parse(Console.ReadLine());

            if(money <= 100)
            {
                atk = atk + 1;
                weapon = "무한의 대검";
            }
            else if(money <= 200)
            {
                atk = atk + 2;
                weapon = "카타나";
            }
            else if(money <= 300)
            {
                atk = atk + 3;
                weapon = "진은검";
            }
            else if(money <= 400)
            {
                atk = atk + 4;
                weapon = "집판검";
            }
            else if(money <= 500)
            {
                atk = atk + 5;
                weapon = "엑스칼리버";
            }
            else if(money <= 600)
            {
                atk = atk + 6;
                weapon = "유령검";
            }
            else if(money > 600)
            {
                atk = atk + 7;
                weapon = "전설의 검";
            }

            Console.WriteLine("========================================");
            Console.WriteLine("캐릭터 : " + name);
            Console.WriteLine("착용한 장비 : " + weapon);
            Console.WriteLine("공격력 : " + atk);*/

            /*
             2024오후문제
                문제 1. 세 정수의 최대값 구하기
                문제 설명:
                사용자로부터 3개의 정수를 입력받아 그 중 가장 큰 값을 출력하는 프로그램을 작성하세요.
                요구사항:

                사용자에게 세 개의 정수를 입력받습니다.
                if문을 사용하여 가장 큰 정수를 결정합니다.
                결과를 “최대값: X” 형식으로 출력합니다.




                문제 2. 점수에 따른 학점 평가
                문제 설명:
                학생의 점수를 입력받아 아래 기준에 따라 학점을 출력하는 프로그램을 작성하세요.

                90 이상: A 학점
                80 이상 90 미만: B 학점
                70 이상 80 미만: C 학점
                60 이상 70 미만: D 학점
                60 미만: F 학점




                문제 3. 간단한 사칙연산 계산기
                문제 설명:
                사용자로부터 두 개의 숫자와 연산자(+, -, *, /)를 입력받아 해당 연산을 수행하고 결과를 출력하는 계산기 프로그램을 작성하세요.
                요구사항:

                두 개의 숫자와 연산자 기호를 입력받습니다.
                if문을 사용하여 연산자를 확인하고 해당 연산을 수행합니다.
                나눗셈의 경우 0으로 나누는 상황을 처리하여 에러 메시지를 출력합니다.
                결과는 “결과: X” 형식으로 출력합니다.

                //시간남는사람
                나만의 텍스트노벨 배운내용 더 넣어서 만들기
            */

            //Q1)


            int numA, numB, numC, max;

            Console.WriteLine("Q1)");
            Console.Write("첫 번째 정수를 입력해주세요 : ");
            numA = int.Parse(Console.ReadLine());
            Console.Write("두 번째 정수를 입력해주세요 : ");
            numB = int.Parse(Console.ReadLine());
            Console.Write("세 번째 정수를 입력해주세요 : ");
            numC = int.Parse(Console.ReadLine());

            if(numA > numB)
            {
                max = numA;
            }
            else
            {
                max = numB;
            }
            if(numC > max)
            {
                max = numC;
            }
            Console.WriteLine("최대값 : " + max);



            //Q2)

            Console.WriteLine("\nQ2)");

            int score;

            Console.Write("점수를 입력해주세요 : ");
            score = int.Parse(Console.ReadLine());

            if (score >= 90)
            {
                Console.WriteLine("A 학점");
            }
            else if (score < 90 && score >= 80)
            {
                Console.WriteLine("B 학점");
            }
            else if (score < 80 && score >= 70)
            {
                Console.WriteLine("C 학점");
            }
            else if (score < 70 && score >= 60)
            {
                Console.WriteLine("D 학점");
            }
            else
            {
                Console.WriteLine("F 학점");
            }


            //Q3)


            Console.WriteLine("\nQ3)");

            int calA, calB, calResult;
            string symbol;

            Console.Write("첫 번째 숫자를 입력해주세요 : ");
            calA = int.Parse(Console.ReadLine());
            Console.Write("연산 기호를 입력해주세요 (+, - , *, /) : ");
            symbol = Console.ReadLine();
            Console.Write("두 번째 숫자를 입력해주세요 : ");
            calB = int.Parse(Console.ReadLine());

            if(symbol == "+")
            {
                Console.WriteLine("결과 : " + (calA + calB));
            }
            else if(symbol == "-")
            {

                Console.WriteLine("결과 : " + (calA - calB));
                //calResult = calA - calB;
            }
            else if(symbol == "*" || symbol == "x")
            {
                Console.WriteLine("결과 : " + (calA * calB));
                //calResult = calA * calB;
            }
            else if(symbol == "/")
            {
                if(calB == 0)
                {
                    Console.WriteLine("0으로는 나눌 수 없습니다!");
                }
                else
                {
                    Console.WriteLine("결과 : " + (calA / calB));
                }
            }


        }
    }
}


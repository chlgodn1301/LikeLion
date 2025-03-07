using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace Study024
{
    /*
    class Program
    {
        static void Main(string[] args)
        {
    */
    // 배열과 컬렉션
    /*int[] numbers = { 1, 2, 3, 4, 5 };
    foreach(var num in numbers)
    {
        Console.WriteLine(num);
    }*/


    // 컬렉션
    // 배열과 비슷, 동적으로 크기가 변하는 가변 길이 컬렉션
    /*List<string> names = new List<string> { "Alice", "Bob", "Charlie" };

    names.Add("Dave");
    names.Remove("Bob");

    foreach(var name in names)
    {
        Console.WriteLine(name);
    }*/

    /*List<int> list = new List<int>();
    list.Add(1);
    list.Add(2);
    list.Add(3);

    Console.WriteLine(list[1]);
    list.Insert(1, 100);    // (a,b) a뒤에 b를 넣음
    Console.WriteLine(list[1]);

    Console.WriteLine(list[0]);
    Console.WriteLine(list.Count);

    foreach(int i in list)
    {
        Console.WriteLine(i);
    }*/

    //===============================================
    //Stack
    /*Stack stack = new Stack();

    stack.Push(1);
    stack.Push(2);
    stack.Push(3);

    while(stack.Count>0)
    {
        Console.WriteLine(stack.Pop());
    }*/


    /*Queue queue = new Queue();
    queue.Enqueue(1);
    queue.Enqueue(2);
    queue.Enqueue(3);

    while(queue.Count>0)
    {
        Console.WriteLine(queue.Dequeue());
    }*/

    /*Queue queue = new Queue();

    queue.Enqueue("q");
    queue.Enqueue("w");
    queue.Enqueue("e");
    queue.Enqueue("r");
    queue.Enqueue("점멸");
    queue.Enqueue("평타");

    while (queue.Count > 0)
    {
        Console.WriteLine(queue.Dequeue());
    }*/



    //========================================================
    // ArrayList 생성
    // 크기가 동적으로 조정되는 배열

    /*ArrayList arrayList = new ArrayList();

    // 요소 추가
    arrayList.Add(1);       // 정수
    arrayList.Add("Hello"); //문자열
    arrayList.Add(3.14);    //실수

    Console.WriteLine("ArrayList 요소 : ");
    foreach(var item in arrayList)
    {
        Console.WriteLine(item);
    }

    // 요소 제거
    arrayList.Remove(1);

    Console.WriteLine("\nArrayList요소 제거 후 : ");

    foreach(var item in arrayList)
    {
        Console.WriteLine(item);
    }*/


    //========================================================
    // Hashtable 클래스
    // 키-값을 저장하는 컬렉션
    // 키를 이용해 값을 빠르게 검색

    /*Hashtable hashTable = new Hashtable();

    // 키-값 쌍 추가
    hashTable["Alice"] = 25;
    hashTable["Bob"] = 30;
    hashTable["포션"] = 20;

    Console.WriteLine("hashTable 요소:");

    foreach (DictionaryEntry entry in hashTable)
    {
        Console.WriteLine($"Key : {entry.Key}, Value : {entry.Value}");
    }


    //특정 키의 값 가져오기
    Console.WriteLine($"\nAlice의 나이 : {hashTable["Alice"]}");

    //요소제거
    hashTable.Remove("Bob");

    Console.WriteLine("hashTable 요소:");

    foreach (DictionaryEntry entry in hashTable)
    {
        Console.WriteLine($"Key : {entry.Key}, Value : {entry.Value}");
    }*/


    //========================================================
    // 제네릭 사용하기 (Generics)
    // <T> 제네릭 클래스를 사용하면 특정 타입에 종속되지 않는 범용 클래스를 만들수 있음


    //    }
    //}

    //class Program
    //{
    //    class Cup<T>
    //    {
    //        public T Content { get; set; }
    //    }
    //    static void Main(string[] args)
    //    {
    //        /*Cup<string> cupOfString = new Cup<string> { Content = "Coffee" };
    //        Cup<int> cupOfInt = new Cup<int> { Content = 42 };

    //        Console.WriteLine($"CupOfString : {cupOfString.Content}");
    //        Console.WriteLine($"cupOfInt : {cupOfInt.Content}");*/

    //        /*Stack<int> stack = new Stack<int>();

    //        stack.Push(10);
    //        stack.Push(20);
    //        stack.Push(30);

    //        while(stack.Count > 0)
    //        {
    //            Console.WriteLine(stack.Pop());
    //        }*/

    //        /*List<string> names = new List<string> { "Alice", "Bob", "Charlie" };
    //        names.Add("Dave");

    //        foreach(var name in names)
    //        {
    //            Console.WriteLine("name");
    //        }*/


    //        //========================================================
    //        //  C# 컬렉션 순회 반복할 수 있는 인터페이스

    //        /*ArrayList list = new ArrayList { "Apple", "Banana", "Cherry" };
    //        IEnumerator eneumerator = list.GetEnumerator();     // 열거자 가져오기

    //        while(eneumerator.MoveNext())  // 다음 요소가 있는지 확인
    //        {
    //            Console.WriteLine(eneumerator.Current);  // 현재요소 출력
    //        }*/




    //    }
    //}


    /*   // 커스텀 컬렉션

       class SimpleCollection : IEnumerable<int>
       {
           private int[] data = { 1, 2, 3, 4, 5 };

           public IEnumerator<int> GetEnumerator()
           {
               foreach (var item in data)
               {
                   yield return item;
               }
           }
           IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
       }




    static void Main(string[] args)
           {

               var collection = new SimpleCollection();

               foreach (var i in collection)
               {
                   Console.WriteLine(i);
               }
           }
       }
   }*/
    class Program
    {
        static void Main(string[] args)
        {

            // Dictionary
            /*Dictionary<string, int> ages = new Dictionary<string, int>();

            ages["금도끼"] = 10;
            ages["은도끼"] = 5;
            ages["동도끼"] = 1;

            foreach(var pair in ages)
            {
                Console.WriteLine($"{pair.Key} : {pair.Value}");
            }*/



            //=================================================================
            // null값
            // 참조형식 null을 가질 수 있으며, 값 형식은 기본적으로 null을 가질 수 없습니다

            // string str = null;
            // if(str == null)
            // {
            //       Console.WriteLine("str is null");
            // }

            /* int? nullableInt = null;

             Console.WriteLine(nullableInt.HasValue ? nullableInt.Value.ToString() : "No Value");

             nullableInt = 10;

             Console.WriteLine(nullableInt.HasValue ? nullableInt.Value.ToString() : "No Value");*/

            //string str = null;
            //Console.WriteLine(str ?? "DefaultValue");   //str이 null이면 "Default Value"

            // str = "Hello";

            // Console.WriteLine(str?.Length);  //str이 null이 아니므로 같이 출력 

            /*
            
            str?.Length; 코드를 풀어쓰면 아래 코드와 같습니다.

            if (str != null)
            {
                str.Length;
            }

            */
            // =======================================================
            // Linq는 확장메서드 형태로 제공
            // Linq(Language Integrated Query)를 사용


            int[] numbers = { 1, 2, 3, 4, 5 };

            var evenNumbers = numbers.Where(n => n % 2 == 0);

            foreach(var num in evenNumbers)
            {
                Console.WriteLine(num);
            }

            

        }
    }
}

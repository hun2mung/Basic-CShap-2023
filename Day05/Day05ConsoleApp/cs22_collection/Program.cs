using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs22_collection
{
    class MyList
    {
        int[] array;
        public MyList()
        {
            array = new int[3];     // 최초크기 3
        }
        public int Length
        {
            get { return array.Length; }
        }
        
        // 인덱서
        public int this[int index]
        {
            get
            {
                return array[index];
            }
            set
            {
                if(index >= array.Length)   // 3보다 커지면
                {
                    Array.Resize<int>(ref array, index + 1);
                    Console.WriteLine("MyList Resized : {0}", array.Length);
                }
                array[index] = value;   // 값 할당
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5];
            array[0] = 1;
            array[1] = 2;
            array[2] = 3;
            array[3] = 4;
            array[4] = 5;
            //array[5] = 6; // index out of range!  // 정해진 배열 크기 이상 추가 불가

            Console.WriteLine(array[4]);

            char[] oldString = new char[5]; // 문자열 길이 지정해야되서 오래된 방식! C에서만 사용
            string curString = "";  // 문자열 길이 상관 없음.

            //ArrayList
            ArrayList list1 = new ArrayList();   // 배열과 달리 용량 제한 x!!!
            list1.Add(1);
            list1.Add(2);
            list1.Add(3);
            list1.Add(4);
            list1.Add(5);
            list1.Add(6);

            // 여러가지 메소드
            ArrayList list2 = new ArrayList();
            list2.Add(8);
            list2.Add(4);
            list2.Add(12);
            list2.Add(16);
            list2.Add(2);

            foreach (int item in list2)
            {
                Console.WriteLine(item);
            }

            // list에서 데이터 삭제
            Console.WriteLine("12 삭제 후 ");
            list2.Remove(12);
            Console.WriteLine("2번 째 데이터 삭제");
            list2.RemoveAt(1);

            foreach (int item in list2)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("0번 째 위치에 7을 입력");
            list2.Insert(0, 7); // 0번 째 위치에 7을 입력
            foreach (int item in list2)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("정렬");
            list2.Sort();
            foreach (int item in list2)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("거꾸로");
            list2.Reverse();
            foreach (int item in list2)
            {
                Console.WriteLine(item);
            }

            // 정리
            // ArrayList .Add(), .Insert(x,y), .Remove(x), .RemoveAt(x), .Sort(), .Reverse()

            // 새로 만든 MyList
            MyList mylist = new MyList();
            for (int i = 1; i <= 5; i++)
            {
                mylist[i] = i * 5;
            }

            for (int i = 0; i < mylist.Length; i++)
            {
                Console.WriteLine(mylist[i]);
            }
        }
    }
}

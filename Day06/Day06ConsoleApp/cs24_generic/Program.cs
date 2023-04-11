using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs24_generic
{
    #region < 일반화 클래스>
    class MyArray<T>        // 일반화 클래스  // where T : class 사용할 타입은 무조건 클래스 타입이어야 한다
    {
        T[] array;
    }
    #endregion
    internal class Program
    {
        #region < 일반화>
        // 일반화!!!!!
        static void CopyArray<T>(T[] source, T[] target)
        {
            for (var i = 0; i < source.Length; i++)
            {
                target[i] = source[i];
            }
        }
        #endregion

        #region < 일반화 전 >
        static void CopyArray(int[] source, int[] target)
        {
            for (var i  = 0; i < source.Length; i++)
            {
                target[i] = source[i];
            }
        }

        static void CopyArray(long[] source, long[] target)
        {
            for (var i = 0; i < source.Length; i++)
            {
                target[i] = source[i];
            }
        }

        static void CopyArray(float[] source, float[] target)
        {
            for (var i = 0; i < source.Length; i++)
            {
                target[i] = source[i];
            }
        }
        #endregion

        static void Main(string[] args)
        {
            #region < 일반화시키기>
            int[] source = { 2, 4, 6, 8, 10 };
            int[] target = new int[source.Length];

            CopyArray(source, target); // CopyArray<int>(source, target)와 동일!
            foreach ( var item in target)
            {
                Console.WriteLine(item);
            }

            long[] source2 = { 2100000, 1234567, 567567, 123123, 234234 };
            long[] target2 = new long[source2.Length];

            CopyArray(source2, target2);

            float[] source3 = { 1.23f, 2.34f, 3.45f, 4.56f, 5.67f };
            float[] target3 = new float[source3.Length];

            CopyArray(source3, target3);
            #endregion

            Console.WriteLine("-------------------");

            // 일반화 컬렉션
            List<int> list = new List<int>();
            for (var i = 10; i > 0; i--)
            {
                list.Add(i);
            }

            foreach( var item in list)
            {
                Console.WriteLine(item);
            }

            list.RemoveAt(3);   // 7 삭제

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            list.Sort();

            foreach( var item in list)
            {
                Console.WriteLine(item);
            }
            // 아래와 같은 일반화 컬렉션 자주 봄
            List<MyArray<string>> myStringArray = new List<MyArray<string>>();

            // 일반화 스택
            Stack<float> stFloats = new Stack<float>();
            stFloats.Push(3.15f);
            stFloats.Push(4.28f);
            stFloats.Push(1.23f);

            while ( stFloats.Count > 0 )    // 스택 출력 일반적 방법.
            {
                Console.WriteLine(stFloats.Pop());
            }

            // 일반화 Queue
            Queue<string> qString = new Queue<string>();
            qString.Enqueue("Hello");
            qString.Enqueue("World");
            qString.Enqueue("C#");

            while( qString.Count > 0)
            {
                Console.WriteLine(qString.Dequeue());
            }

            // 일반화 딕셔너리
            Dictionary<string, int> dictNumbers = new Dictionary<string, int>();
            dictNumbers["하나"] = 1;
            dictNumbers["둘"] = 2;
            dictNumbers["셋"] = 3;
            dictNumbers["넷"] = 4;

            Console.WriteLine(dictNumbers["셋"]);
        }
    }
}
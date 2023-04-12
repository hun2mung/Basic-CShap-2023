using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs26_delegate
{
    // 대리자 사용하겠다는 선언
    delegate int CalcDelegate(int a, int b);

    delegate int Compare(int a, int b); // a, b 중 머가 큰지(작은지) 비교 대리자

    #region < Calc 클래스>
    class Calc
    {
        public int Plus(int a, int b)
        {
            return a + b;
        }

        // 정적메소드는 실행 최초에 메모리에 장착되어 프로그램 실행 중 클래스로 직접 언제든 접근 가능
        public static int Minus(int a, int b)
        {
            return a - b;
        }
    }
    #endregion

    internal class Program
    {
        // 오름차순 비교
        static int AscendCompare(int a, int b)
        {
            if (a > b) return 1;
            else if (a==b) return 0;
            else return -1; 
        }
        
        // 내림차순 비교
        static int DescendCompare(int a, int b)
        {
            if (a < b) return 1;
            else if (a==b) return 0;
            else return -1;
        }

        static void BubbleSort(int[] DataSet, Compare comparer)
        {
            int i = 0, j = 0, temp = 0;

            for (i=0; i<DataSet.Length -1; i++)
            {
                for (j=0; j<DataSet.Length - (i+1); j++)
                {
                    if (comparer(DataSet[j], DataSet[j+1]) > 0)    // 대리자 사용
                    {
                        temp = DataSet[j + 1];
                        DataSet[j+1] = DataSet[j];
                        DataSet[j] = temp;  // Swap

                    }
                }
            }
        }

        static void BubbleSort2(int[] DataSet, bool isAscend)
        {
            int i = 0, j = 0, temp = 0;

            if (isAscend == true)
            {
                for (i = 0; i < DataSet.Length - 1; i++)
                {
                    for (j = 0; j < DataSet.Length - (i + 1); j++)
                    {
                        if (DataSet[j] > DataSet[j + 1])    // 대리자 사용
                        {
                            temp = DataSet[j + 1];
                            DataSet[j + 1] = DataSet[j];
                            DataSet[j] = temp;  // Swap

                        }
                    }
                }
            }
            else
            {
                for (i = 0; i < DataSet.Length - 1; i++)
                {
                    for (j = 0; j < DataSet.Length - (i + 1); j++)
                    {
                        if (DataSet[j] < DataSet[j + 1])    // 대리자 사용
                        {
                            temp = DataSet[j + 1];
                            DataSet[j + 1] = DataSet[j];
                            DataSet[j] = temp;  // Swap

                        }
                    }
                }
            }
            
        }


        static void Main(string[] args)
        {
            #region < 클래스 대리자 비교 >
            //일반 클래스 - 직접 호출
            Calc normalcalc = new Calc();
            int x = 10; int y = 15;
            Console.WriteLine(normalcalc.Plus(x, y));

            Console.WriteLine(Calc.Minus(x, y));

            // 대리자를 사용하는 방식 - 대리자 대신 실행
            x = 20; y = 30;
            Calc delCalc = new Calc();
            CalcDelegate Callback;

            Callback = new CalcDelegate(delCalc.Plus);
            int res = Callback(x, y);
            Console.WriteLine(res);

            Callback =new CalcDelegate(Calc.Minus); 
            int res2 = Callback(x, y);
            Console.WriteLine(res2);
            #endregion

            int[] origin = { 4, 7, 8, 2, 9, 1 };

            Console.WriteLine("오름차순 버블정렬");
            BubbleSort(origin, new Compare(AscendCompare));

            foreach(var item in origin)
            {
                Console.Write("{0} ", item);
            }

            Console.WriteLine("내림차순 버블정렬");
            BubbleSort(origin, new Compare(DescendCompare));

            foreach (var item in origin)
            {
                Console.Write("{0} ", item);
            }

            Console.WriteLine("버블정렬2 사용");
            BubbleSort2(origin, true);
            foreach ( var item in origin)
            {
                Console.Write("{0} ", item);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs27_delegateChain
{
    delegate void ThereIsAFire(string location);    // 불 확인 대리자

    delegate int Calc(int a, int b);

    delegate string Concatenate(string[] args);

    #region < Sample 클래스 - 람다식 프로퍼티>
    class Sample
    {
        public int valueA;  // 멤버변수 - 외부에서 접근불가

        public int ValueA   // 프로퍼티
        {
            //get { return valueA; }
            //set { valueA = value; }
            get => valueA;
            set => valueA = value;
        }
    }
    #endregion

    internal class Program
    {
        static void Call119(string location)
        {
            Console.WriteLine("소방서죠? {0}에 불이 났어요!!!", location);
        }

        static void ShoutOut(string location)
        {
            Console.WriteLine("{0}에 불이 났어요!!!", location);
        }
        static void Escape(string location)
        {
            Console.WriteLine("{0}에서 탈출합니다!", location);
        }

        static string ProcConcate(string[] args)
        {
            string result = string.Empty;   // == "";
            foreach (string s in args)
            {
                result += s + "/";
            }
            return result;
        }

        static void Main(string[] args)
        {
            #region < 대리자 체인>
            var loc = "우리집";
            Call119(loc);
            ShoutOut(loc);
            Escape(loc);

            // 불 날 경우 대비 !!!대리자!!!로 미리 연결하여 준비
            var otherloc = "남의집";
            ThereIsAFire fire = new ThereIsAFire(Call119);
            fire += new ThereIsAFire(ShoutOut);
            fire += new ThereIsAFire(Escape);

            fire(otherloc);

            fire -= new ThereIsAFire(ShoutOut); // 대리자에서 메서드 삭제

            fire("저기집");

            //익명함수
            Calc plus = delegate (int a, int b)
            {
                return a + b;
            };

            Calc minus = delegate (int a, int b)
            {
                return a - b;
            };

            Calc sub = (a, b) => { return a / b; };

            Console.WriteLine(plus(6, 7));
            Console.WriteLine(minus(7, 6));

            Calc simpleMinus = (a, b) => a - b; // 람다식
            #endregion

            Concatenate concat = new Concatenate(ProcConcate);
            var result = concat(args);

            Console.WriteLine(result);

            Console.WriteLine("람다식 활용");
            Concatenate concat2 = (arr) =>
            {
                string res = string.Empty;   // == "";
                foreach (string s in args)
                {
                    res += s + "/";
                }
                return res;
            };
            Console.WriteLine(concat2(args));


        }
    }
}

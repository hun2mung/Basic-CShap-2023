using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs25_exception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3 };

            try
            {
                for (var i = 0; i < 5; i++)
                {
                    Console.WriteLine(array[i]);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                // 예외 발생해도 무조건 처리하는 로직
                // file 객체 close
                // db 연결 close
                // 네트워크 소켓 close
                Console.WriteLine("Keep going");
            }
            try
            {
                DivideTest(array[2], 0);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("프로그램 종료!!");

            //try
            //{
            //    throw new Exception("예외!!!");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
        }

        private static void DivideTest(int v1, int v2)
        {
            try
            {
                Console.WriteLine(v1 / v2);
            }
            catch (Exception)
            {
                //  현재 메서드에 예외처리 않고 메서드 호출한 곳에서 예외 잡음!!!
                throw new Exception("DivideTest 메서드에서 예외 발생!");
            }
        }
    }
}

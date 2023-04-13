﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace cs30_filereadwrite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string line = string.Empty;     // 텍스트를 읽어와서 출력

            StreamReader reader = null;

            try
            {
                reader = new StreamReader(@".\python.py");  // 스트림리더 파일 연결

                line = reader.ReadLine();   // 한 줄 씩 읽음

                while(line != null)
                {
                    Console.WriteLine(line); //한줄 읽은거 출력
                    line = reader.ReadLine();   // 다음 줄 읽기
                }

            }
            catch (Exception e)
            {
                Console.WriteLine($"예외! {e.Message}");
            }
            finally
            {
                reader.Close();     // 파일 읽은 후 닫기
            }
            // 읽기 끝

            StreamWriter writer = new StreamWriter(@".\pythonByCSharp.py");

            try
            {
                writer.WriteLine("import sys");
                writer.WriteLine("");
                writer.WriteLine("print(sys.executable)");
            }
            catch(Exception e)
            {
                Console.WriteLine($"예외! {e.Message}");
            }
            finally { writer.Close(); }
            Console.WriteLine("파일 생성 완료!");
            
        }
    }
}

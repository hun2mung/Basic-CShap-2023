using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace num3_App
{
    internal class Program
    {
        static void Main(string[] args)
        {   // 딕셔너리 사용
            var color = new Dictionary<string, string>    // Dictionary<string, string> color = new Dictionary<string, string>
            {
                {"Red", "빨간색" },    // {키, 값}
                {"Orange","주황색" },  // color.ADD("Orange", "주황색"),
                {"Yellow","노란색" },
                {"Green", "초록색" },
                {"Blue","파란색" },
                {"Indigo", "남색" },
                {"Purple", "보라색" },
            };

            Console.Write("무지개 색은 ");

            foreach (string value in color.Values)  // foreach문 
            { 
                Console.Write($"{value}, "); 
            }

            Console.WriteLine("입니다.");

            Console.WriteLine("Key 와 Value 확인");

            string str = "Purple";
            Console.WriteLine($"{str}은 {color[str]}입니다.");


        }
    }
}

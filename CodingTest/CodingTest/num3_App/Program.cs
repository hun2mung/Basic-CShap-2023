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
        {
            var color = new Dictionary<string, string>()
            {
                {"Red", "빨간색" },
                {"Orange","주황색" },
                {"Yellow","노란색" },
                {"Green", "초록색" },
                {"Blue","파란색" },
                {"Indigo", "남색" },
                {"Purple", "보라색" },
            };

            Console.Write("무지개 색은 ");

            foreach (var value in color.Values)
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

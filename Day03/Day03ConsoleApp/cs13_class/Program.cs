using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace cs13_class
{
    internal class Cat   // private 이라도 같은 cs13_class 안에 있기 때문에 접근 가능
    {
        #region < 생성자 >

        /// <summary>
        /// 기본 생성자
        /// </summary>
        public Cat()
        {
            Name = string.Empty;
            Color = string.Empty;
            Age = 0;
        }

        /// <summary>
        /// 사용자 지정생성자
        /// </summary>
        /// <param name="name"></param>
        /// <param name="color"></param>
        /// <param name="age"></param>
        public Cat(string name, string color = "흰색", int age = 1)   // 색과 나이만 초기화
        {
            Name = name;
            Color = color;
            Age = age;
        }

        #endregion

        #region < 멤버변수 - 속성 >
        public string Name;    // 이름
        public string Color;   // 색상
        public int Age;     // 나이
        #endregion

        #region <멤버 메서드 - 기능>
        public void Meow()
        {
            Console.WriteLine("{0} - 야옹~!!", this.Name);
        }
        public void Run()
        {
            Console.WriteLine("{0} 달린다.", Name);
        }
        #endregion
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Cat hellokitty = new Cat();     // hellokitty라는 이름의 객체 생성
            hellokitty.Name = "헬로키티";
            hellokitty.Color = "흰색";
            hellokitty.Age = 50;
            hellokitty.Meow();
            hellokitty.Run();

            // 객체 생성하면서 초기화
            Cat nero = new Cat()
            {
                Name = "네로",
                Color = "검은색",
                Age = 27
            };

            nero.Meow();
            nero.Run();

            Console.WriteLine("{0}의 색상은 {1}, 나이는 {2}세 입니다.", hellokitty.Name, hellokitty.Color, hellokitty.Age);
            Console.WriteLine("{0}의 색상은 {1}, 나이는 {2}세 입니다.", nero.Name, nero.Color, nero.Age);

            Cat yaongi = new Cat();
            Console.WriteLine("{0}의 색상은 {1}, 나이는 {2}세 입니다.", yaongi.Name, yaongi.Color, yaongi.Age);    // 신상이 없음

            Cat norangi = new Cat("노랑이", "노란색");
            Console.WriteLine("{0}의 색상은 {1}, 나이는 {2}세 입니다.", norangi.Name, norangi.Color, norangi.Age);


        }
    }
}

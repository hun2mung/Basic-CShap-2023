using System;

namespace num1_App
{
    class Boiler    // Boiler 클래스 만들기! 
    {
        private byte voltage;   // 리턴 값 변수 선언.
        private int temperature;

        public string Brand;
        public byte Voltage     // 프로퍼티 활용하여 조건 걸기!
        {
            get { return this.voltage; }    // 리턴 값
            set
            {
                if (value == 110 ||  value == 220)
                {
                    this.voltage = value;
                }
                else
                {
                    Console.WriteLine("다시 입력!");
                }
            }

        }
        public int Temperature
        {
            get { return this.temperature; }
            set
            {
                if (value <= 5)
                {
                    Temperature = 5;
                }
                if (value >= 70)
                {
                    temperature = 70;
                }
                else
                {
                    temperature = value;
                }
            }
        }

        internal void PrintAll()
        {
            Console.WriteLine($"브랜드는 {Brand}, 전압은 {Voltage}, 온도는 {Temperature}이다.");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Boiler kitturami = new Boiler { Brand = "귀뚜라미", Voltage = 220, Temperature = 45 };
            kitturami.PrintAll();

            Boiler kitturami1 = new Boiler { Brand = "귀뚜라미", Voltage = 0, Temperature = 1000};
            kitturami1.PrintAll();
        }
    }
}

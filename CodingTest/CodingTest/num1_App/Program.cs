using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace num1_App
{
    class Boiler
    {
        private byte voltage;
        private int temperature;

        public string Brand;
        public byte Voltage
        {
            get { return this.voltage; }
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

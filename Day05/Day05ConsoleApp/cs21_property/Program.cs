using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs21_property
{
    class Boiler
    {
        public int temp;    // 기본 멤버변수

        public int Temp // 프로퍼티(속성)
        {
            get { return temp; }
            set
            {
                if (value <= 10 || value >= 70)
                {
                    temp = 10;  // 10도로 변경
                }
                else
                {
                    temp = value;
                }
            }
        }

        // 위의 get; set; 과 비교    // 아래 Get/Set메서드는 Java에서 사용. C# 거의 안씀

        public void SetTemp(int temp)
        {
            if(temp <= 10 || temp >= 70)
            {
                //Console.WriteLine("수온설정값이 너무 낮거나 높습니다. 10~70도 사이로 지정해주세요");
                //return;
                this.temp = 10;
            }
            this.temp = temp;
        }

        public int GetTemp() { return this.temp;}
    }

    class Car
    {
        string name;
        string color;
        int year;
        string fuelType;
        string tireType;
        string company;
        int price;
        string carIdNumber;
        string carPlateNumber;

        public string Name { get; set; }    // 필터링이 필요없으면 멤버변수 없이 프로퍼티로 대체
        public string Color { get; set; }

        // 들어오는 데이터를 필터링 할 대는 private 멤버변수와 public 프로퍼티 둘 다 사용
        public int Year { get => year;  // get { return year; }
            set
            {
                if (value <= 1990 || value >= 2023)
                {
                    value = 2023;
                }
                year = value;
            }
        }
        public string FuelType { get => fuelType;
            set
            {
                if (value != "휘발유" || value != "경유")
                {
                    value = "휘발유";
                }
                fuelType = value;
            }
        }
        private int door;
        public int Door {
            get { return door; }
            set
            {
                if (value != 2 || value != 4)
                {
                    value = 4;
                }
                door = value;
            }
                }
        public string TireType { get ; set; }
        public string Company { get; set; } = "현대자동차";
        public int Price { get => price; set => price = value; }
        public string CarIdNumber { get ; set ; }
        public string CarPlateNumber { get => carPlateNumber; set => carPlateNumber = value; }
    }

    interface IProduct
    {
        string ProductName { get; set; }

        void Produce();
    }

    class MyProduct : IProduct
    {
        public string ProductName {
            get { return ProductName;  } 
            set { ProductName = value; } 
        }

        public void Produce()
        {
            Console.WriteLine("{0}을 생산합니다.", ProductName);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Boiler boil1 = new Boiler();
            //boil1.temp = 60;

            //boil1.temp = 30000;     // 보일러 수온 3만도?
            boil1.SetTemp(50);
            Console.WriteLine(boil1.GetTemp()); // 옛날 방식

            Boiler boil2 = new Boiler();
            boil2.Temp = 5000;
            Console.WriteLine(boil2.Temp);

            Car ionic = new Car();
            ionic.Name = "아이오닉";
            Console.WriteLine(ionic.Name);

            // 생성할 때 프로퍼티로 초기화
            Car gene = new Car()
            {
                Name = "제네시스",
                FuelType = "휘발유",
                Door = 3,   // value = 4로 변경됨
                Color = "흰색",
                TireType = "광폭타이어",
                Year = 0,
            };

            Console.WriteLine("자동차 제조회사는 {0}", gene.Company);
            Console.WriteLine("자동차 제조년도는 {0}", gene.Year);
            Console.WriteLine("자동차 문갯수는 {0}", gene.Door);
        }
    }
}

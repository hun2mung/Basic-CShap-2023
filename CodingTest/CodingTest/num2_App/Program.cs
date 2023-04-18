using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace num2_App
{
    public class Car // 부모 클래스 정의
    {
        internal string Name;
        internal string Marker;
        internal string Color;
        internal int YearModel;
        internal int MaxSpeed;
        internal string UniqueNumber;
        internal void Start()
        {
            Console.WriteLine($"{Name}의 시동을 겁니다");
        }

        internal void Accelerate()
        {
            Console.WriteLine($"최대시속{MaxSpeed}km/h로 가속합니다");

        }

        internal void TurnRight()
        {
            Console.WriteLine($"{Name}를 우회전합니다");

        }

        internal void Brake()
        {
            Console.WriteLine($"{Name}의 브레이크를 밟습니다");
        }
    }

    public class ElectricCar : Car  // 자식 클래스
    {
        internal virtual void Recharge()
        {
            Console.WriteLine("달리면서 배터리를 충전합니다");   // 오버라이딩되면서 무시됨
        }
    }

    internal class HybridCar : ElectricCar  // 자식 클래스의 자식 클래스
    {


        internal override void Recharge()   // 오버라이딩(재정의)
        {
            Console.WriteLine("달리면서 배터리를 충전합니다");   // Recharge 메소드 실제 출력!!!
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            HybridCar ioniq = new HybridCar();
            ioniq.Name = "아이오닉";
            ioniq.Marker = "현대자동차";
            ioniq.Color = "White";
            ioniq.YearModel = 2018;
            ioniq.MaxSpeed = 220;
            ioniq.UniqueNumber = "54라 3346";

            ioniq.Start();
            ioniq.Accelerate();
            ioniq.Recharge();
            ioniq.TurnRight();
            ioniq.Brake();

        }
    }

}

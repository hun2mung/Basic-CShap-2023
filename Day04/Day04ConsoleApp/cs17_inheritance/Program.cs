using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs17_inheritance
{
    // 상속해줄 부모 클래스
    class Parent
    {
        public string Name;

        public Parent(string Name)
        {
            this.Name = Name;
            Console.WriteLine("{0} from Parent 생성자", Name);
        }

        public void ParentMethod()
        {
            Console.WriteLine("{0} from Parent 메서드", Name);
        }
    }

    // 상속받을 자식 클래스
    class Child : Parent
    {
        public Child(string Name) : base(Name)  // 부모생성자 먼저 실행 뒤 자기 생성자 실행
        {
            Console.WriteLine("{0} from Child 생성자", Name);
        }

        public void ChildMethod()
        {
            Console.WriteLine("{0} from Child 메서드", Name);
        }
    }

    // 클래스간 형변환 DB처리, DI
    class Mammal    // 포유류
    {
        public void Nurse()     // 기르다
        {
            Console.WriteLine("포유류 기르다");
        }
    }

    class Dogs : Mammal
    {
        public void Bark()
        {
            Console.WriteLine("멍멍!!!");
        }
    }

    class Cats : Mammal
    {
        public void Meow()
        {
            Console.WriteLine("야옹!!!");
        }
    }

    class Elephants : Mammal
    {
        public void Poo()
        {
            Console.WriteLine("푸!!!");
        }
    }

    class ZooKeeper
    {
        //public void Wash(Dogs dog)
        //{
        //    ///
        //}
        //public void Wash(Cats cat)
        //{

        //}
        //public void Wash(Elephants elephant)
        //{

        //}

        public void Wash(Mammal mammal)
        {
            if( mammal is Elephants)
            {
                var animal = mammal as Elephants;
                Console.WriteLine("코끼리를 씻깁니다.");
                animal.Poo();
            }
            else if (mammal is Dogs)
            {
                var animal = mammal as Dogs;
                Console.WriteLine("강아지를 씻깁니다.");
                animal.Bark();
            }
            else if ( mammal is Cats)
            {
                var animal = mammal as Cats;
                Console.WriteLine("고양이를 씻깁니다.");
                animal.Meow();
            }

        }

        
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            #region < 기본상속 개념>
            Parent p = new Parent("p");
            p.ParentMethod();

            Console.WriteLine("자식 클래스 생성");
            Child c = new Child("c");
            c.ParentMethod();   // 자식클래스는 부모클래스의 속성, 기능을 모두 쓸 수 있다.(public, protected일 때)
            c.ChildMethod();
            #endregion

            #region < 클래스 간 형식 변환 >

            //Mammal mammal = new Mammal();   // 기본
            Mammal mammal = new Dogs();
            //Mammal.Bark();    // 형변환을 했기에 바로 안됨
            if (mammal is Dogs)
            {
                Dogs midDog = (Dogs)mammal;
                // Dogs midDOg = mammal as Dogs;    // 같다
                midDog.Bark();
            }
            
            //Dogs dogs = new Mammal();
            Dogs dog2 = new Dogs();
            Cats cat2 = new Cats();
            Elephants el2 = new Elephants();


            ZooKeeper Keeper = new ZooKeeper();
            Keeper.Wash(dog2);
            Keeper.Wash(cat2);
            Keeper.Wash(el2);


            #endregion

        }
    }
}

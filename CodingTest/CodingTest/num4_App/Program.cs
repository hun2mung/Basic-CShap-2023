﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace num4_App
{
    public interface IAnimal    // 인터페이스 - 접근제한 한정자는 public으로 고정되어 생략하고 내부에선 선언만 된다.
    {
        int Age { get; set; }
        string Name { get; set; }

        void Eat();
        void Sleep();
        void Sound();
    }

    class Dog : IAnimal // 인터페이스 상속 - 상속 받은 클래스는 인터페이스 내 선언된 멤버 모두 구현 필요!!
    {
        private int age;
        private string name;

        public int Age {
            get { return age; }
            set { age = value; }
        }
        public string Name {
            get { return name; }
            set { name = value; }
        }

        public void Eat()
        {
            Console.WriteLine($"{this.Name}먹는다.");
        }
        public void Sleep()
        {
            Console.WriteLine("잔다.");
        }
        public void Sound()
        {
            Console.WriteLine("짖는다.");
        }
    }

    class Cat : IAnimal
    {
        private int age;
        private string name;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public void Eat()
        {
            Console.WriteLine($"{this.Name}먹는다.");
        }
        public void Sleep()
        {
            Console.WriteLine("잔다.");
        }
        public void Sound()
        {
            Console.WriteLine("짖는다.");
        }
    }

    class Horse : IAnimal
    {
        private int age;
        private string name;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public void Eat()
        {
            Console.WriteLine($"{this.Name} 먹는다.");
        }
        public void Sleep()
        {
            Console.WriteLine($"{this.Name} 잔다.");
        }
        public void Sound()
        {
            Console.WriteLine($"{this.Name} 짖는다.");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog { Name = "강아지", Age = 10};    // 객체 생성

            Console.WriteLine($"{dog.Name}의 나이는 {dog.Age}이다.");
            dog.Eat();
            dog.Sleep();
            dog.Sound();

            Cat cat = new Cat { Name = "고양이", Age = 5 };

            Console.WriteLine($"{cat.Name}의 나이는 {cat.Age}이다.");
            cat.Eat();
            cat.Sleep();
            cat.Sound();

            Horse horse= new Horse{ Name = "말", Age = 10 };

            Console.WriteLine($"{horse.Name}의 나이는 {horse.Age}이다.");
            horse.Eat();
            horse.Sleep();
            horse.Sound();

        }
    }
}

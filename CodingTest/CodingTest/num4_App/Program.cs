using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace num4_App
{
    public interface IAnimal
    {
        int Age { get; set; }
        string Name { get; set; }

        void Eat();
        void Sleep();
        void Sound();
    }

    class Dog : IAnimal
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


    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog { Name = "강아지", Age = 10};

            Console.WriteLine($"{dog.Name}의 나이는 {dog.Age}이다.");
            dog.Eat();
        }
    }
}

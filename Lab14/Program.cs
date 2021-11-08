using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Разработать абстрактный класс Animal, который описывает животное. 
Класс содержит следующие элементы
абстрактное свойство - название животного.
В классе Animal нужно определить следующие методы
конструктор, устанавливающий значение по умолчанию для названия;
абстрактный метод Say(), который выводит звук, который издает животное;
неабстрактный метод ShowInfo(), который выводит на консоль последовательно 
название, а затем звук (вызывая метод Say()).

Разработать классы Cat и Dog, которые реализуют абстрактный класс Animal. 
В классах реализовать следующие элементы
свойство – название животного;
метод Say (), выводящий на экран «Мяу» либо «Гав» соответственно.
Создайте экземпляры классов Cat и Dog и проверьте их работоспособность.*/
namespace Lab14
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog("Барбос");
            Cat cat = new Cat("Муська");
            Cat cat2 = new Cat();
            dog.Say();
            Console.WriteLine();
            cat.Say();
            Console.WriteLine();
            cat2.Say();
            Console.ReadKey();
        }
    }
    abstract class Animal
    {
        public abstract string Name { get; set; }
        public abstract string Sound { get; }
        protected Animal()
        {
            Name = "Безымянка";
        }
        public abstract void Say();
    }
    class Dog : Animal
    {
        public override string Name { get; set; }
        public override string Sound { get; } = "гав!";
        public override void Say()
        {
            Console.WriteLine($" Собака {Name} говорит {Sound}");
        }
        public Dog()
            : base() { }
        public Dog(string name)
        {
            Name = name;
        }
    }
    class Cat : Animal
    {
        public override string Name { get; set; }
        public override string Sound { get; } = "мяу!";
        public override void Say()
        {
            Console.WriteLine($" Кошка {Name} говорит {Sound}");
        }
        public Cat()
            : base() { }
        public Cat(string name)
        {
            Name = name;
        }
    }
}

using System;
using System.Collections.Generic;

namespace Packt.CS7 
{
    public partial class Person : object
    {
        public Person()
        {
            // установка дефолтных значений полей,
            // включая поля только для чтения
            Name = "Unknown";
            Instantiated = DateTime.Now;
        }
        public Person(string initialName)
        {
            Name = initialName;
            Instantiated = DateTime.Now;
        }

        public Tuple<string, int> GetFruitCS4()
        {
            return Tuple.Create("Apples", 5);
        }
        // новый синтаксис C# 7 и новый тип System.ValueTuple
        public (string, int) GetFruitCS7()
        {
            return ("Apples", 5);
        }

        public (string Name, int Number) GetNamedFruit()
        {
            return (Name: "Apples", Number: 5);
        }
        public string SayHello()
        {
            return $"{Name} says 'Hello!'";
        }
        public string SayHello(string name)
        {
            return $"{Name} says 'Hello {name}!'";
        }

        public string OptionalParameters(string command = "Run!",
        double number = 0.0, bool active = true)
        {
            return $"command is {command}, number is {number}, active is {active}";
        }

        public void PassingParameters(int x, ref int y, out int z)
        {
            // параметры out не могут иметь значение по умолчанию и должны быть
            // инициализированы в методе
            z = 99;
            // инкрементирование каждого параметра
            x++;
            y++;
            z++;
        }



        public string Name;
        public DateTime DateOfBirth;
        public WondersOfTheAncientWorld BucketList;
        public List<Person> Children = new List<Person>();
        public const string Species = "Homo Sapien";
        // поля только для чтения
        public readonly string HomePlanet = "Earth";
        public readonly DateTime Instantiated;
    }
   
}


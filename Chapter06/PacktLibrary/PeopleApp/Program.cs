using System;
using Packt.CS7;
using static System.Console;

namespace PeopleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var harry = new Person { Name = "Harry" };
            var mary = new Person { Name = "Mary" };
            var jill = new Person { Name = "Jill" };

            // метод вызова экземпляра
            var baby1 = mary.ProcreateWith(harry);
            // метод статического вызова
            var baby2 = Person.Procreate(harry, jill);

            WriteLine($"{mary.Name} has {mary.Children.Count} children.");
            WriteLine($"{harry.Name} has {harry.Children.Count} children.");
            WriteLine($"{jill.Name} has {jill.Children.Count} children.");
            WriteLine($"{mary.Name}'s first child is named\"{mary.Children[0].Name}\".");

            WriteLine("After Operator\r\n");

            var baby3 = harry * mary;

            WriteLine($"{mary.Name} has {mary.Children.Count} children.");
            WriteLine($"{harry.Name} has {harry.Children.Count} children.");
            WriteLine($"{jill.Name} has {jill.Children.Count} children.");
            WriteLine($"{mary.Name}'s first child is named\"{mary.Children[0].Name}\".");

            WriteLine("Factorial\r\n");

            WriteLine($"5! is {Person.Factorial(5)}");

            WriteLine("Events\r\n");

            harry.Shout += Harry_Shout;
            harry.Poke();
            harry.Poke();
            harry.Poke();
            harry.Poke();

            WriteLine("Interface\r\n");
            Person[] people = {
                new Person { Name = "Simon" },
                new Person { Name = "Jenny" },
                new Person { Name = "Adam" },
                new Person { Name = "Richard" }
            };

            WriteLine("Initial list of people:");
            foreach (var person in people)
            {
                WriteLine($"{person.Name}");
            }
            WriteLine("Use Person's IComparable implementation to sort:");
            Array.Sort(people);
            foreach (var person in people)
            {
                WriteLine($"{person.Name}");
            }

            WriteLine("Use PersonComparer's IComparer implementation to sort:");
            Array.Sort(people, new PersonComparer());
            foreach (var person in people)
            {
                WriteLine($"{person.Name}");
            }

            var t = new Thing();
            t.Data = 42;
            WriteLine($"Thing: {t.Process("42")}");

            var gt = new GenericThing<int>();
            gt.Data = 42;
            WriteLine($"GenericThing: {gt.Process("42")}");

            string number1 = "4";
            WriteLine($"{number1} squared is {Squarer.Square<string>(number1)}");
            byte number2 = 3;
            WriteLine($"{number2} squared is {Squarer.Square<byte>(number2)}");

            ReadLine();
        }


        private static void Harry_Shout(object sender, EventArgs e)
        {
            Person p = (Person)sender;
            WriteLine($"{p.Name} is this angry: {p.AngerLevel}.");
        }
    }
}

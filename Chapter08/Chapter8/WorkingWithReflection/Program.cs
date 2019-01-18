using static System.Console;
using System;
using System.Reflection;
using System.Linq;

namespace WorkingWithReflection
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Assembly metadata: ");
            Assembly assembly = Assembly.GetEntryAssembly();

            WriteLine($" Full name: {assembly.FullName}");
            WriteLine($" Location: {assembly.Location}");

            var attributes = assembly.GetCustomAttributes();

            WriteLine($" Attributes:");
            foreach( Attribute a in attributes)
            {
                WriteLine($"{a.GetType()}");
            }
            var version = assembly.GetCustomAttribute<AssemblyInformationalVersionAttribute>();
            WriteLine($" Version: {version.InformationalVersion}");
            var company = assembly.GetCustomAttribute<AssemblyCompanyAttribute>();
            WriteLine($" Company: {company.Company}");

            [Coder("Mark Price", "22 August 2017")]
            [Coder("Johnni Rasmussen", "13 September 2017")]
            public static void DoStuff()
            {

            }

            ReadKey();
        }
    }
}

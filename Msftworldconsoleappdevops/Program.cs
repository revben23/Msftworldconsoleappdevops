using System;
using System;


namespace Msftworldconsoleappdevops
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Revi Bennett";
            int age = 28;
            Console.WriteLine("Hello World, my name is " +name+", I am " +age+".");
            Console.WriteLine("Hello World, my name is {0}, I am {1}.", name, age);
            Console.ReadKey();
        }

        static void Main2(string[] args)
        {
            string appNName = "Numbergusser";
            string appversion = "1.0.0";
            string author = "Revi Bennett";
            Console.WriteLine ("{0}: Version {1} by {2 }.", appNName, appversion, author);

        }
    }
}

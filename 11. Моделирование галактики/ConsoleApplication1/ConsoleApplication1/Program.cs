using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            User x = new User();
            Console.WriteLine("Hellow");
            Console.WriteLine("My name is CNN");
            Console.WriteLine("And what is your name?");
            x.name=Console.ReadLine();
            Console.WriteLine("Hellow, "+x.name);
            if(x.Exists(x.name))
            {
                Console.WriteLine("As far as I remember:");
                x.Info(x.name);
            }
            else
            {
                Console.WriteLine("Unfortunately I don't know you");
                Console.WriteLine("Let's make friends");
                Console.WriteLine("How old are you?");

            }
            Console.ReadKey();
        }
        class User
        {
            public User()
            {

            }
            public string name;
            public int age;
            public bool Exists(string n)
            {
                bool b=false;

                return b;
            }
            public void Info(string n)
            {

                Console.WriteLine("Your name is " + name);
                Console.WriteLine("You are "+age+" years old");
            }
        }
    }
}

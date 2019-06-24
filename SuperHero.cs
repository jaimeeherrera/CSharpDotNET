using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHero
{
    public class Person
    {
        public Person(string name, string nickname) // Create Constructor that accepts name and nickname 
        {
            Name = name;
            NickName = nickname;
        }
        public string Name { get; set; }
        public string NickName { get; set; }
        public override string ToString()
        {
            return Name;
        }
        public virtual string PrintGreeting()
        {
            return $"Hi! My name is {Name}, you can call me {NickName}.";
            //Creating greeting with Name and nickname
        }
    }

    public class SuperHero : Person
    {
        public SuperHero(string name, string realname, string superpower ) : base (name, null)
        {
            Realname = realname;
            Superpower = superpower;
        }
        public string Realname { get; set; }
        public string Superpower { get; set; }
        public override string PrintGreeting()
        {
            return $" I am {Realname}. My super power is {Superpower}, When I am {Name} ";

        }
    }

    public class Villian : Person 
        {
            public Villian(string name, string namesis) : base(name, nickname : null )
            {
              Namesis = namesis; 

            }
            public string Namesis { get; set; } 
            public override string PrintGreeting()
                {
                    return $"I am {Name}! Have you seen {Namesis}?";
                }
        } 

            public class Program
            {
        public static void Main(string[] args )
        {
            Person civillian = new Person("William", "Bill");
            SuperHero hero = new SuperHero("Mr. Incredible", "super strength", "Wade Turner");
            Villian villain = new Villian("The Joker", "Batman");

            // return name and Greeting
            Console.WriteLine($"{civillian.ToString()}: {civillian.PrintGreeting()}");
            Console.WriteLine($"{hero.ToString()}: {hero.PrintGreeting()}");
            Console.WriteLine($"{villain.ToString()}: {villain.PrintGreeting()}");
            Console.Read();
        }
             }
}
   



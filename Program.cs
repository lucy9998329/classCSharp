using System;

namespace classCsharp
{
    class Program
    {
        class Person
        {
            public string Name;
            public int Age;

            public Person(string name, int age)
            {
                Name = name;
                Age = age;
            }

            public Person(string name)
            {
                Name = name;
            }

            public Person(int age)
            {                
                Age = age;
            }

            public /*static*/ string SayHello(string n, int a)
            {
                //return $"hello my name is ${n} and I am ${a} years old";
                return $"hello my name is ${Name} and I am ${Age} years old";
            }
        }


        static void Main(string[] args)
        {
           /* var jeff = new Person();
            jeff.Name = "Jeff";
            jeff.Age = 35;

            var lucy = new Person();
            lucy.Name = "Lucy";
            lucy.Age = 32;
            Console.WriteLine($"Heloo {jeff.Name}, {jeff.Age}");*/


            var jeff = new Person("Jeff", 35);
            var lucy = new Person("Lucy", 35);
            var kevin = new Person("Kevin", 35);
            Console.WriteLine(jeff.SayHello();)
            Console.WriteLine(lucy.SayHello();)
            Console.WriteLine(kevin.SayHello();)


        }




        /*{
            Console.WriteLine(Greeting("Lisa"));
        }
        static string Greeting(string name)
        {
            return $"Hello {name}";
        }*/



    }
}

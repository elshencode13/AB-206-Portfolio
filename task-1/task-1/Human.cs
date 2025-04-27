using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_1
{
     class Human
    {
       
            public string Name;
            public string Surname;
            private byte Age;

            public Human()
            {

            }
            public Human(string name)
            {
                Name = name;
            }
            public Human(string name, string surname, byte age)
            {
                Name = name;
                Surname = surname;
                Age = age;
            }
            public void ShowFullData()
            {
                Console.WriteLine($"Name: {Name} \nSurname: {Surname}\nAge: {Age}");

            }
            public void GetFullName()
            {
                Console.WriteLine($"Fullname: {Name} {Surname}");
            }

        }
       
    }

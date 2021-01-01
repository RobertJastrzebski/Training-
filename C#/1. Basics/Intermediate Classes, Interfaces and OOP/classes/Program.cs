﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
    public class Person
    {
        public string Name;

        public void Introduce(string to)
        {
            Console.WriteLine("hi {0}, I am {1}", to , Name);
        }


        public static Person Parse(string str)
        {
            var person = new Person();
            person.Name = str;
            return person;
        }


    }
    class Program
    {
        static void Main(string[] args)
        {

            var person = Person.Parse("Robert");
            person.Introduce("Asia");
        }
    }
}

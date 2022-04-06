using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp006.Models
{
    internal class Person
    {
        public string Name { get; set; }
        public string Surname {get;set;}
        public int Id { get; }
        private static int _id;
        static Person()
        {
            _id = 0;
        }
        private  Person()
        {
            Id = ++_id;
        }
        public Person(string name, string surname):this()
        {
            Name = name;
            Surname = surname;

        }

    }
}

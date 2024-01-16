using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_12
{
    class Person
    {
        private string _name;
        private string _lastName;
        private int _age;
        private List<string> _list;

        public string Name { get { return _name; } set { _name = value; } }
        public string LastName { get { return _lastName; } set { _lastName = value; } }
        public int Age { get { return _age; } set { _age = value; } }
        public Person(string name, string lastName, int age)
        {
            Name = name;
            LastName = lastName;
            Age = age;
        }
        public Person()
        {
            Name = "Василий";
            LastName = "Пупкин";
            Age = 100;
        }
        public override string ToString()
        {
            return Name + " " + LastName + " " + Age;
        }
    }
}

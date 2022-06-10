using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_02
{
    public class Person : IEquatable<Person>
    {
        protected string name;
        protected int age;
        public string Name { get => this.name; }
        public int Age { get => this.age; }


        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public bool Equals(Person other)
        {
            if (other == null) return false;
            if (other == this) return true;
            return Object.Equals(this.name, other.name);
        }
        public override string ToString() => $"Pearson: {name} ({age} y.o)\n";

    }
}
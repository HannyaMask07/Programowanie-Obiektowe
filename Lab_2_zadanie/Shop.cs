using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2_zadanie
{
    internal class Shop
    {
        private string name;


        public string Name { get => this.name; }
        public string V { get; }
        public Program.Person[] Persons { get; }
        public Program.Product[] Products { get; }



        public Shop(string v, Program.Person[] persons, Program.Product[] products)
        {
            V = v;
            Persons = persons;
            Products = products;
        }

        internal void Print()
        {
            throw new NotImplementedException();
        }
    }
}

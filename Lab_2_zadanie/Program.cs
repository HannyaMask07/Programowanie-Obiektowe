using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace lab_2_zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            Seller treacher = new Seller("Jan Kowalski", 50);

            Buyer buyer1 = new Buyer("Jaś Fasola 1", 25);
            Buyer buyer2 = new Buyer("Jaś Fasola 2", 21);
            Buyer buyer3 = new Buyer("Jaś Fasola 3", 23);

            buyer1.AddProduct(new Fruit("Apple", 6));
            buyer1.AddProduct(new Meat("Fish", 0.5));

            Person[] persons = { treacher, buyer1, buyer2, buyer3 };

            Product[] products = {
                new Fruit("Apple", 1000),
                new Fruit("Banana", 700),
                new Fruit("Orange", 500),
                new Meat("Fish", 100.0),
                new Meat("Beef", 75.0)
            };

            Shop shop = new Shop("Super Market", persons, products);

            shop.Print();

        }

        public class Person
        {
            private string name;
            private int age;

            public string Name { get => this.name; }
            public int Age { get => this.age;  }

            public Person(string name, int age)
            {
                this.name = name;
                this.age = age;
            }

            public override string ToString()
            {
                return $"{this.name} ({this.age} y.o)";
            }

        }

        public class Seller: Person
        {
            public Seller(string name, int age) : base(name, age)
            {

            }
            public override string ToString()
            {
                return $"Teacher: {base.ToString()}";
            }

        }

        public class Buyer : Person
        {

            protected List<Product> parts = new List<Product>();
            public Buyer(string name, int age) : base(name, age)
            {

            }

            internal void AddProduct(Fruit fruit)
            {
                throw new NotImplementedException();
            }

            internal void AddProduct(Meat meat)
            {
                throw new NotImplementedException();
            }

            internal void RemoveProduct(Fruit fruit)
            {
                throw new NotImplementedException();
            }
            internal void RemoveProduct(Meat meat)
            {
                throw new NotImplementedException();
            }

            public override string ToString()
            {
                return $"Buyer: {base.ToString()}";
            }


        }

        public class Product
        {
            private string name;
            

            public string Name { get => this.name; }
            

            public Product(string name)
            {
                this.name = name;     
            }
            public override string ToString()
            {
                return $"{base.ToString()}";
            }

        }

        public class Fruit : Product
        {
            private int count;

            public int Count { get => this.count; }

            
            public Fruit(string name, int count) : base(name)
            {
                this.count = count;
            }
            public override string ToString()
            {
                return $"{base.ToString()}";
            }

        }

        public class Meat : Product
        {
            private double weight;

            public double Weight { get => this.weight; }
            public double V { get; }

            public Meat(string name, int weight) : base(name)
            {
                this.weight = weight;
            }

            public Meat(string name, double v) : base(name)
            {
                V = v;
            }
            public override string ToString()
            {
                return $"{base.ToString()}";
            }
        }


    }
}

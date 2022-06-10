using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_02
{
    public class Classroom
    {
        private string name;
        private Person[] people;

        public string Name { get => name; }
        public Classroom(string name, Person[] people)
        {
            this.people = people;
            this.name = name;
        }
        public void Test()
        {
            foreach (var item in people)
            {
                Console.WriteLine("dupa");
            }
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Classroom: {name}\n");
            foreach (var item in people)
            {
                sb.AppendLine(item.ToString());

            }
            return sb.ToString();
        }

    }
}
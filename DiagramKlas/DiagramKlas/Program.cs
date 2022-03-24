using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagramKlas
{

    public class Program
    {
        public static void Main()
        {
            Teacher treacher = new Teacher("Maria Skłodowska", 50);

            Student student1 = new Student("Jan Kowaslski", 21, "LAB-01");
            Student student2 = new Student("Jan Kowaslski", 21, "LAB-01");
            Student student3 = new Student("Jaś Fasola", 23, "LAB-02");

            student1.AddTask("Taks A", TaskStatus.Waiting);
            student1.AddTask("Taks B", TaskStatus.Waiting);
            student1.AddTask("Taks C", TaskStatus.Rejected);

            student2.AddTask("Taks A", TaskStatus.Waiting);
            student2.AddTask("Taks B", TaskStatus.Waiting);
            student2.AddTask("Taks C", TaskStatus.Rejected);

            student3.AddTask("Taks D", TaskStatus.Done);
            student3.AddTask("Taks E", TaskStatus.Waiting);
            student3.AddTask("Taks F", TaskStatus.Waiting);

            student3.UpdateTask(1, TaskStatus.Done);
            student3.UpdateTask(2, TaskStatus.Progress);

            Person[] persons = { treacher, student1, student2, student3 };
            Classroom classroom = new Classroom("Sala Komputerowa", persons);

            Console.WriteLine(classroom);

            Console.WriteLine("student1 == student2: " + student1.Equals(student2)); // Output: student1 == student2: true
            Console.WriteLine("student1 == student3: " + student1.Equals(student3)); // Output: student1 == student3: false
        }
    }

    public class Person
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

            return Object.Equals(this.name, other.name) && Object.Equals(this.age, other.age);
        }

        public override string ToString()
        {
            return $"{this.name} ({this.age} y.o)";
        }
    }

    public class Teacher: Person
    {
        public Teacher(string name, int age) : base(name, age)
        {
            
        }

        public override string ToString()
        {
            return $"Teacher: {base.ToString()}";
        }
    }

    public class Student : Person
    {

        protected string group;
        protected List<Task> tasks;

        public string Group {get => this.group; }

        public Student(string name, int age, string group)
            : this(name, age, group, new List<Task>())
        {
            this.group = group;
            
        }


        public Student(string name, int age, string group, List<Task> tasks) : base(name, age)
        {
            this.group = group;
            this.tasks = tasks;
        }

        public override string ToString()
        {
            string result = $"Student: {base.ToString()}";

            result += $"Grooup: {this.group}\n";
            result += $"Tasks: {this.tasks}\n";

            //TODO: add to string to tasks

            return result;
        }

        public bool Equals(Student other)
        {
            if (other == null) return false;
            if (other == this) return true;

            return Object.Equals(this.name, other.name) && Object.Equals(this.age, other.age) && Object.Equals(this.group, other.group);
        }

        internal void AddTask(string v, TaskStatus waiting)
        {
            throw new NotImplementedException();
        }

        internal void UpdateTask(int v, TaskStatus done)
        {
            throw new NotImplementedException();
        }
    }

    
}

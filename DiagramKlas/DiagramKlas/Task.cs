using System;
using System.Collections.Generic;


namespace DiagramKlas
{
    public class Task
    {
        private String name;
        private TaskStatus status;

        public String Name { get => this.name; }

        public TaskStatus TaskStatus { get => this.status; }

        public Task(String name, TaskStatus status)
        {
            this.name = name;
            this.status = status;
        }

        public override string ToString()
        {
            return $"{this.name} [{this.status}]";
        }

        public bool Equals(Task other)
        {
            if (other == null) return false;
            if (other == this) return true;

            return Object.Equals(this.name, other.name) && Object.Equals(this.status, other.status);
        }
    }
}

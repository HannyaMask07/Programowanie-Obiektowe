using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab_06
{
    class Program
    {
        static void Main(string[] args)
        {
            List<User> users = new List<User>()
            {
                new User {Name = "A", Age = 1, Role = "ADMIN",       Marks = {} },
                new User {Name = "B", Age = 2, Role = "MODERATOR",   Marks = {} },
                new User {Name = "C", Age = 3, Role = "TEACHER",     Marks =  {} },
                new User {Name = "A", Age = 4, Role = "STUDENT",     Marks = {} },
            };

            int[] maciek = { 1 }; 

            //Liczba rekordów
            Console.WriteLine(users.Count());
            
            //Lista nazw użytkowników 
            List<string> names_1 = users.Select(user => user.Name).ToList(); //mapowania, projekcja

            //sortowanie na podstawie nazwy
            List<User> users_1 = users.OrderBy(user => user.Name).ToList();

            foreach (User user in users_1)
                Console.WriteLine(user.Name + " " + user.Age);

            //Lista dostępnych ról urzytkowników
            List<string> users_2 = users.Select(user => user.Role).Distinct().ToList();

            foreach (var item in users_2)
                Console.WriteLine(item);

            //Listy pogrupowanych urzytkowników po rolach
            




        }
    }
}

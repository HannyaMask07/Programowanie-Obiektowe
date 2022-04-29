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
                new User {Name = "A", Age = 1},
                new User {Name = "B", Age = 2},
                new User {Name = "C", Age = 3},
                new User {Name = "A", Age = 4},
            };

            Console.WriteLine(users.Count());
            
            Console.WriteLine((from user  in users
                               select user).Count());


            List<string> names_1 = users.Select(user => user.Name).ToList(); //mapowania, projekcja
            List<string> names_2 = (from user in users
                                    select user.Name).ToList(); // mapowania projekcja

            //foreach (string name in names_2)
            //    Console.WriteLine(name);

            List<User> users_1 = users.OrderBy(user => user.Name).ToList();
            List<User> users_2 = (from user in users
                                  orderby user.Name
                                  select user).ToList();

            foreach (User user in users_1)
                Console.WriteLine(user.Name + " " + user.Age);
        }
    }
}

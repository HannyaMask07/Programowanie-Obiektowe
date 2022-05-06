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
                new User {Name = "A", Role = "ADMIN",     Age = 24, Marks = null,  CreatedAt =  new DateTime(2008, 03, 1, 7, 0, 0),RemovedAt = null  , },
                new User {Name = "B", Role = "MODERATOR", Age = 24, Marks = null,  CreatedAt =  new DateTime(2008, 03, 1, 7, 0, 0)       ,RemovedAt = null  , },
                new User {Name = "C", Role = "TEACHER",   Age = 24, Marks = null,  CreatedAt =  new DateTime(2008, 03, 1, 7, 0, 0)        ,RemovedAt = null  , },
                new User {Name = "Wcześniak", Role = "STUDENT",   Age = 23, Marks = new int[] {1, 2, 4, 5,},    CreatedAt = new DateTime(2001, 04, 1, 3, 0, 0)         ,RemovedAt =null   , },
                new User {Name = "N", Role = "STUDENT",   Age = 23, Marks = new int[] {2, 3, 5,},       CreatedAt = new DateTime(2001, 04, 1, 7, 0, 0)        ,RemovedAt =null   , },
                new User {Name = "S", Role = "STUDENT",   Age = 23, Marks = new int[] {2, 4, 5, 3, 3},  CreatedAt = new DateTime(2001, 04, 1, 7, 0, 0)         ,RemovedAt = new DateTime(2010, 03, 1, 7, 0, 0)    , },
                new User {Name = "A", Role = "STUDENT",   Age = 23, Marks = new int[] {1, 2, 4, 5, 6},  CreatedAt = new DateTime(2001, 04, 1, 7, 0, 0)         ,RemovedAt =null   , },
                new User {Name = "C", Role = "TEACHER",   Age = 16, Marks = null,  CreatedAt = new DateTime(2008, 05, 1, 7, 0, 0)       ,RemovedAt = null  , },            
                new User {Name = "A", Role = "STUDENT",   Age = 16, Marks = new int[] {2, 3, 4, 5,},    CreatedAt = new DateTime(2008, 05, 1, 7, 0, 0)         ,RemovedAt =new DateTime(2010, 03, 1, 7, 0, 0)   , },
                new User {Name = "Best", Role = "STUDENT",   Age = 27, Marks = new int[] {3, 4, 5, 6, 6, 6},       CreatedAt = new DateTime(2008, 05, 1, 7, 0, 0)         ,RemovedAt =null   , },
                new User {Name = "G", Role = "STUDENT",   Age = 23, Marks = new int[] {1, 1, 1, 2, 4, 5,},    CreatedAt = new DateTime(2008, 05, 1, 7, 0, 0)         ,RemovedAt =null   , },
                new User {Name = "D", Role = "STUDENT",   Age = 23, Marks = new int[] {1, 2, 4, 5,},    CreatedAt = new DateTime(2008, 05, 1, 7, 0, 0)         ,RemovedAt =null   , },
                new User {Name = "C", Role = "TEACHER",   Age = 28, Marks = null,  CreatedAt = new DateTime(2008, 06, 1, 7, 0, 0)         ,RemovedAt =null   , },                    
                new User {Name = "A", Role = "STUDENT",   Age = 28, Marks = new int[] {2, 3, 4, 5,},    CreatedAt = new DateTime(2008, 06, 1, 7, 0, 0)         ,RemovedAt =null   , },
                new User {Name = "A", Role = "STUDENT",   Age = 28, Marks = new int[] {1, 2, 3, 4, 5,}, CreatedAt = new DateTime(2008, 06, 1, 7, 0, 0)         ,RemovedAt =new DateTime(2010, 03, 1, 7, 0, 0)   , },
                new User {Name = "E", Role = "STUDENT",   Age = 23, Marks = new int[] {1, 2, 4,},    CreatedAt = new DateTime(2008, 07, 1, 7, 0, 0)         ,RemovedAt =null   , },
                new User {Name = "A", Role = "STUDENT",   Age = 23, Marks = new int[] {1, 2, 4, 5,},    CreatedAt = new DateTime(2008, 07, 1, 7, 0, 0)         ,RemovedAt =new DateTime(2010, 03, 1, 7, 0, 0)   , },
                new User {Name = "C", Role = "TEACHER",   Age = 28, Marks = null,  CreatedAt = new DateTime(2008, 07, 1, 7, 0, 0)         ,RemovedAt = null   , },                    
                new User {Name = "A", Role = "STUDENT",   Age = 25, Marks = new int[] {1, 2, 5,},   CreatedAt = new DateTime(2008, 03, 1, 7, 0, 0)         ,RemovedAt =null   , },
                new User {Name = "T", Role = "STUDENT",   Age = 25, Marks = new int[] {1, 2, 3, 4, 5,}, CreatedAt = new DateTime(2008, 03, 1, 7, 0, 0)         ,RemovedAt =new DateTime(2010, 03, 1, 7, 0, 0)   , },

            };



            //Liczba rekordów
            Console.WriteLine("Liczba rekorów:");
            Console.WriteLine(users.Count());
            //

            //Lista nazw użytkowników 
            Console.WriteLine("\nLista nazw użytkowników");
            List<string> names_1 = users.Select(user => user.Name).ToList(); //mapowania, projekcja
            foreach (var item in names_1)
            {
                Console.Write(item + " ");
            }

            //sortowanie na podstawie nazwy
            Console.WriteLine("\n\nSortowanie na podstawie nazwy:");
            List<User> users_1 = users.OrderBy(user => user.Name).ToList();
            foreach (User user in users_1)
                Console.Write(user.Name + " ");
            
            //Lista dostępnych ról urzytkowników
            Console.WriteLine("\n\nLista dostępnych ról urzytkowników:");
            List<string> users_2 = users.Select(user => user.Role).Distinct().ToList();

            foreach (var item in users_2)
                Console.WriteLine(item);

            //Listy pogrupowanych urzytkowników po rolach
            Console.WriteLine("\nListy pogrupowanych użytkowników po rolach");
            var users_3 = users.GroupBy(user => user.Role).ToList();

            foreach (var group in users_3)
            {
                Console.WriteLine(" ");
                foreach (var user in group.ToList())
                {
                    Console.WriteLine( user.Role + " "+ user.Name);
                }
            }

            //Ilość rekordów, dla których podano oceny (nie null i więcej niż 0)
            Console.WriteLine("\nIlość rekordów, dla których podano oceny (nie null i więcej niż 0)");
            var users_4 = users.Count(user => user.Marks != null && user.Marks.Length > 0);
            Console.WriteLine(users_4);

            //Sumę, ilość i średnią wszystkich ocen studentów
            Console.WriteLine("\nSuma, ilość i średnia wszystkich ocen studentów:");
            var users_mS = users.Sum(user => user.Marks?.Sum());
            Console.WriteLine("\nSuma\n" + users_mS + "\n");
            var users_mC = users.Sum(user => user.Marks?.Count());
            Console.WriteLine("Ilość wszystkich ocen\n" + users_mC + "\n");
            var users_mA = (double)users_mS / users_mC;
            Console.WriteLine("Średnia\n" + $"{users_mA:f2} " + "\n");

            //Najlepszą ocenę
            var users_mBest = users.Max(user => user.Marks?.Max());
            Console.WriteLine("Najlepsza ocena: " + users_mBest + "\n");

            //Najgorszą ocenę
            var users_mWorst = users.Min(user => user.Marks?.Min());
            Console.WriteLine("Najlepsza ocena: " + users_mWorst);

            //Najlepszego studenta
            var users_best = users.Select(user => user.Marks?.Average()).Max();

            IEnumerable<string> name_best = from user in users 
                                            where user.Marks?.Average() == users_best
                                            select user.Name;

            foreach (string str in name_best)
            {
                Console.WriteLine("\nNazwa najlepszego studenta: " + str);
            }

            //Najgorszego studenta
            var users_worst = users.Select(user => user.Marks?.Average()).Min();

            IEnumerable<string> name_worst = from user in users
                                            where user.Marks?.Average() == users_worst
                                            select user.Name;

            foreach (string str in name_worst)
            {
                Console.WriteLine("\nNazwa najgorszego studenta: " + str);
            }


            //Listę studentów, którzy posiadają najmniej ocen
            var users_Least = users.Select(user => user.Marks?.Count()).Min();
            var users_Leastx = (from user in users
                                            where user.Marks?.Count() == users_Least
                                            select user.Name).ToList();
            Console.WriteLine("\nLista studentów, którzy posiadają najwięcej ocen: ");
            foreach (string str in users_Leastx)
            {
                Console.Write(str + " ");
            }

            //Listę studentów, którzy posiadają najmniej ocen
            var users_Most = users.Select(user => user.Marks?.Count()).Max();
            var users_Mostx = (from user in users
                                where user.Marks?.Count() == users_Most
                                select user.Name).ToList();
            Console.WriteLine("\nLista studentów, którzy posiadają najmniej ocen: ");
            foreach (string str in users_Mostx)
            {
                Console.Write(str + " ");
            }

            //Listę obiektów zawierających tylko nazwę i średnią ocenę (mapowanie na inny obiekt)

            //Studentów posortowanych od najlepszego
            //List<User> users_sorted_best = users.OrderByDescending(user => user.Marks?.Average()).ToList();
            //Console.WriteLine("\nStudenci posortowani od najlepszego: ");
            //foreach (User str in users_sorted_best)
            //{
            //    Console.Write(str.Name + " " + str.Role + str.Marks?.Average());
            //}

            //Średnią ocenę wszystkich studentów
            //List<User> users_avrg = users.OrderByDescending(user => user.Marks?.Average()).ToList();
            //Console.WriteLine("\nStudenci posortowani od najlepszego: ");
            //foreach (User str in users_avrg)
            //{
            //    Console.WriteLine(str.Name + " " + $"{str.Marks?.Average():f2}");
            //}

            //Srednią ocene wszystkich studentów oraz posortowanie ich od najlepszego
            Console.WriteLine("\nSrednia ocena wszystkich studentów oraz posortowanie ich od najlepszego");
            List<User> users_avrg = users.Where(user => user.Marks != null).OrderByDescending(user => user.Marks?.Average()).ToList();
            foreach (User user in users_avrg)
            {
                Console.WriteLine(user.Name + " " + $"{user.Marks?.Average():f2}");
            }

            //Listę użytkowników pogrupowanych po miesiącach daty utworzenia
            Console.WriteLine("\nListę użytkowników pogrupowanych po miesiącach daty utworzenia");

            var users_date_group = users.GroupBy(user => new { Month = user.CreatedAt?.Month, Year = user.CreatedAt?.Year });

            foreach (var group in users_date_group)
            {
                Console.WriteLine(" ");
                foreach (var user in group)
                {
                    Console.WriteLine("Data dołączenia:" + user.CreatedAt?.Year + "-" + user.CreatedAt?.Month.ToString("00") + " " + user.Name);
                }
            }

            //Listę użytkowników, którzy nie zostali usunięci (data usunięcia nie została ustawiona)
            Console.WriteLine("\nLista użytkowników, którzy nie zostali usunięci");
            var users_not_deleted = users.Where(user => user.RemovedAt == null).Select(user => new { user.Name }).ToList();
            foreach (var user in users_not_deleted)
            {
                Console.WriteLine(user.Name);
            }

            //Najnowszego studenta (najnowsza data utworzenia)

            var users_earliest = (from user in users select user.CreatedAt).Min();
            var name_earliest = from user in users
                                where user.CreatedAt == users_earliest
                                select user.Name;

            foreach (string str in name_earliest)
            {
                Console.WriteLine("\nNazwa najwcześniejszego studenta: " + str);
            }
            







        }
    }
}

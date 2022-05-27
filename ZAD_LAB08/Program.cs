using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;

namespace lab_08_zadanie
{
    class Program
    {
        static void Main(string[] args)
        {

            Stopwatch stopwatch = new Stopwatch();

            Object locker = new Object();

            HashSet<int> primeNum = new HashSet<int>();

            bool looped = true;

            

            stopwatch.Start();
            var v = stopwatch.Elapsed;
            Thread thread1 = new Thread(() =>
            {
                while(looped)
                    for (int i = -2;looped; i+=5)
                    {
                        if (isPrimeNumber(i) == true)
                        {

                            lock (locker) // remove this line and check output to see effect
                            {
                                primeNum.Add(i);
                            }

                        }
                    }
                
            });



            Thread thread2 = new Thread(() =>
            {
                while (looped)
                    for (int i =  -1;looped; i+= 5)
                    {
                        if (isPrimeNumber(i) == true)
                        {

                            lock (locker) // remove this line and check output to see effect
                            {
                                primeNum.Add(i);
                            }

                        }
                    }
                

            });

            Thread thread3 = new Thread(() =>
            {
                while (looped)
                    for (int i = 0; looped; i+=5)
                    {
                        if (isPrimeNumber(i) == true)
                        {

                            lock (locker) // remove this line and check output to see effect
                            {
                                primeNum.Add(i);
                            }

                        }
                    }
                

            });

            Thread thread4 = new Thread(() =>
            {
                while (looped)
                    for (int i = 1; looped; i+=5)
                    {
                        if (isPrimeNumber(i) == true)
                        {

                            lock (locker) // remove this line and check output to see effect
                            {
                                primeNum.Add(i);
                            }

                        }
                    }
               

            });

            Thread thread5 = new Thread(() =>
            {
                while (looped)
                    for (int i = 2; looped; i += 5)
                    {
                        if (isPrimeNumber(i) == true)
                        {

                            lock (locker) // remove this line and check output to see effect
                            {
                                primeNum.Add(i);
                            }

                        }
                    }


            });



            thread1.Start();
            thread2.Start();
            thread3.Start();
            thread4.Start();
            thread5.Start();


            Thread.Sleep(10000);  // sleeps main thread for 10 seconds
            looped = false;

            thread1.Join();
            thread2.Join();
            thread3.Join();
            thread4.Join();
            thread5.Join();

            Console.WriteLine(stopwatch.ElapsedMilliseconds);
            Console.WriteLine(primeNum.Count);

            
        }

        public static bool isPrimeNumber(int number)
        {
            var limit = Math.Floor(Math.Sqrt(number));
            for (int i = 2; i <= limit; ++i)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return number >= 2;
        }


    }
}
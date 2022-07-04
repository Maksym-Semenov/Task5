using System;
using System.Collections.Generic;

namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IFlyAble> FlyAble = new List<IFlyAble>();
            IFlyAble eagle = new Bird("eagle",true);
            FlyAble.Add(eagle);
            IFlyAble chiken = new Bird("chiken", false);
            FlyAble.Add(chiken);
            IFlyAble ostrich = new Bird("ostrich", false);
            FlyAble.Add(ostrich);
            IFlyAble mriya = new Plane("Mriya", 15000);
            FlyAble.Add(mriya);
            IFlyAble ruslan = new Plane("Ruslan", 12000);
            FlyAble.Add(ruslan);
            FlyAble.Add(new Bird("roomster", false));
            FlyAble.Add(new Plane("Boeing", 9000));
            foreach ( IFlyAble item in FlyAble)
            {
                item.Fly();
            }
            //Task 5 Part 2
            Random rnd = new Random();
            List<int> MyColl = new List<int>();
            for (int i = 0; i < 20; i++)
            {
                int value = rnd.Next( -30, 30 );
                MyColl.Add(value);
                Console.WriteLine(value);
            }

            //Find and print all positions of element “-10” in this collection
            for (int i = 0; i < MyColl.Count; i++)
            {
                if (MyColl[i] == -10)
                {
                    Console.WriteLine($"Item {MyColl[i]} have index {i}");
                }
            }
            Console.ReadLine();

            //remove from collection elements > 20
            for (int i = 0; i < MyColl.Count; i++)
            {
                if (MyColl[i] > 20)
                {
                    Console.WriteLine($"Program remove element {MyColl[i]}");
                    MyColl.RemoveAt(i);
                    i--;
                }
            }

            //Insert elements 1,-3,-4 in positions 2, 8, 5. Print new collection
            List<int> MyColl2 = new List<int>() { 1, -3, -4 };
            foreach (var item in MyColl)
            {
                Console.Write($"{item} \t");
            }



            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region без полиморфизма
            //int count = 10;

            //Random r = new Random();

            //int countDruid = r.Next(0, count);
            //int countHunter = r.Next(0, count - countDruid);
            //int countWarrior = count - countDruid - countHunter;
            //Console.WriteLine($"CountDruid: {countDruid} countHunter: {countHunter} countWarrior: {countWarrior}");

            //List<Druid> druids = new List<Druid>();

            //for (int i = 0; i < countDruid; i++)
            //{
            //    druids.Add(new Druid());
            //    Console.WriteLine(druids[i].HeroInformation());
            //    druids[i].Motto();
            //}
            //Console.WriteLine();

            //List<Hunter> hunters = new List<Hunter>();
            //for (int i = 0; i < countHunter; i++)
            //{
            //    hunters.Add(new Hunter());
            //    Console.WriteLine(hunters[i].HeroInformation());
            //    hunters[i].Motto();
            //}
            //Console.WriteLine();

            //List<Warrior> warriors = new List<Warrior>();
            //for (int i = 0; i < countWarrior; i++)
            //{
            //    warriors.Add(new Warrior());
            //    Console.WriteLine(warriors[i].HeroInformation());
            //    warriors[i].Motto();
            //}
            #endregion

            #region с полиморфизмом
            Random r = new Random();

            List<Hero> heroes = new List<Hero>();

            for (int i = 0; i < 10; i++)
            {
                switch (r.Next(3))
                {
                    case 0: heroes.Add(new Druid()); break;
                    case 1: heroes.Add(new Hunter()); break;
                    default: heroes.Add(new Warrior()); break;
                }
                Console.WriteLine(heroes[i].HeroInformation());


                heroes[i].Motto();
            }
            #endregion

            Console.ReadKey();
        }
    }
}

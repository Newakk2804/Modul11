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
            Druid druid = new Druid("druid", 1, 500);
            Console.WriteLine(druid.HeroInformation());

            List<IRampage> rampages = new List<IRampage>()
            {
                new Hunter(),
                new Warrior(),
            };

            foreach (var e in rampages)
            {
                e.UltraAttack(druid);

                Console.WriteLine(druid.HeroInformation());
            }

            Console.ReadKey();
        }
    }
}

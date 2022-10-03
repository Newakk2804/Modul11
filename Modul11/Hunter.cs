using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul11
{
    /// <summary>
    /// Герой "Hunter"
    /// </summary>
    class Hunter : Hero, IRampage
    {
        public override void Motto() { Console.WriteLine($"{this.Name}: Охота началась!"); }

        /// <summary>
        /// Создание Героя
        /// </summary>
        /// <param name="Name">Имя</param>
        /// <param name="Level">Уровень</param>
        /// <param name="HitPoint">Запас здоровья</param>
        public Hunter(string Name, byte Level, uint HitPoint)
            : base(Name, Level, HitPoint)
        {
            this.Charge = 3;
        }

        /// <summary>
        /// Создание героя с автопараметрами
        /// </summary>
        public Hunter() : this("", 1, 0)
        {
        }

        /// <summary>
        /// Бонусный выстрел
        /// </summary>
        /// <returns></returns>
        public uint HeadShot()
        {
            return (Hunter.randomize.Next(4) != 0) ?
                this.Attack() : 
                this.Attack() + (uint)Hunter.randomize.Next(10,20);
        }

        //IRampage

        public int Charge { get; set; }

        public void Recharge()
        {
            this.Charge = 3;
        }

        public void UltraAttack(Hero Target)
        {
            for (int i = 0; i < this.Charge; i++)
            {
                Target.Attacked(10);
            }
            this.Charge = 0;
        }
    }
}

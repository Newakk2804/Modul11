using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul11
{
    /// <summary>
    /// Герой "Druid"
    /// </summary>
    class Druid : Hero
    {
        public override void Motto() { Console.WriteLine($"{this.Name}: Благословляю всех!"); }

        /// <summary>
        /// Создание Героя
        /// </summary>
        /// <param name="Name">Имя</param>
        /// <param name="Level">Уровень</param>
        /// <param name="HitPoint">Запас здоровья</param>
        public Druid(string Name, byte Level, uint HitPoint) 
            : base(Name, Level, HitPoint)
        {
        }

        /// <summary>
        /// Создание героя с автопараметрами
        /// </summary>
        public Druid() : this("", 1, 0)
        {
        }

        /// <summary>
        /// Метод, определяющий логику лечения
        /// </summary>
        /// <param name="Hp"></param>
        public override void Treatment(uint Hp = 10)
        {
            Hp = (uint)(Hp * 1.5);
            base.Treatment(Hp);
        }

        /// <summary>
        /// Лечение
        /// </summary>
        /// <returns></returns>
        public uint Heal()
        {
            return (uint)Druid.randomize.Next(5, 10);
        }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul11
{
    /// <summary>
    /// Ультра атака
    /// </summary>
    interface IRampage
    {
        /// <summary>
        /// Количество зарядов
        /// </summary>
        int Charge { get; set; }

        /// <summary>
        /// Логика перезарядки
        /// </summary>
        void Recharge();
        
        /// <summary>
        /// Логика ультра атаки
        /// </summary>
        /// <param name="Target">Цель для атаки</param>
        void UltraAttack(Hero Target);
    }
}

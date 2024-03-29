using System;
namespace RoleplayGame.Items
{
    public class CapaDeInvisibilidad : IAttackItem, IItem, IDefenseItem
    {
        /// <summary>
        /// El poder de ataque
        /// </summary>
        /// <value></value>
        public int AttackPower
        {
            get
            {
                return 9999;
            }
        }

        /// <summary>
        /// El poder de defensa
        /// </summary>
        /// <value></value>
        public int DefensePower
        {
            get
            {
                return 1;
            }
        }

        public override string ToString()
        {
            return "capa de invisibilidad";
        }
    }
}
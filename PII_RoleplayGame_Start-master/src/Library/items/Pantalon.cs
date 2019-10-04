namespace RoleplayGame.Items
{
    public class Pantalon : IItem, IAttackItem, IDefenseItem
    {
        /// <summary>
        /// El poder de ataque
        /// </summary>
        /// <value></value>
        public int AttackPower
        {
            get
            {
                return 11;
            }
        }

        public string Tipo
        {
            get
            {
                return "Madera";
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
                return 800000000;
            }
        }

        public override string ToString()
        {
            return "Pantalon";
        }
    }
}
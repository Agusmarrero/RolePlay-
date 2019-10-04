
namespace RoleplayGame.Items
{
    public class Calibre : IItem, IAttackItem
    {
        /// <summary>
        /// El poder de ataque
        /// </summary>
        /// <value></value>
        public int AttackPower
        {
            get
            {
                return 20;
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
                return 40;
            }
        }

        public override string ToString()
        {
            return "Calibre 50";
        }
    }
}
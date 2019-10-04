namespace RoleplayGame.Items
{
    public class Palote : IItem, IAttackItem
    {
        /// <summary>
        /// El poder de Ataque
        /// </summary>
        /// <value></value>
        public int AttackPower
        {
            get
            {
                return 10000;
            }
        }

        public override string ToString()
        {
            return "Palote";
        }
    }
}
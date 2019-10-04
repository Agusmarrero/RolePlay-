namespace RoleplayGame.Items
{
    public class Coraza : IItem, IDefenseItem
    {
        /// <summary>
        /// El poder de defensa
        /// </summary>
        /// <value></value>
        public int DefensePower
        {
            get
            {
                return 55;
            }
        }

        public override string ToString()
        {
            return "Coraza";
        }
    }
}
namespace RoleplayGame.Items
{
    /// <summary>
    /// Espada de fuego.
    /// </summary>
    public class EspadaDeFuego : IItem, IAttackItem
    {
        public int AttackPower
        {
            get
            {
                return 30;
            }
        }

        public override string ToString()
        {
            return "EspadaDeFuego";
        }
    }
}
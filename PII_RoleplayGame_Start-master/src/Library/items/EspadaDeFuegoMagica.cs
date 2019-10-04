namespace RoleplayGame.Items
{
    public class EspadaDeFuegoMagica : IItem, IDefenseItem, IAttackItem
    {
        Magic magic = new Magic();
        EspadaDeFuego espada = new EspadaDeFuego();

        /// <summary>
        /// El poder de ataque
        /// </summary>
        /// <value></value>
        public int AttackPower
        {
            get
            {
                return espada.AttackPower * magic.AttackPower;
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
                return magic.DefensePower;
            }
        }

        public override string ToString()
        {
            return "Espada de Fuego Magica";
        }
    }
}
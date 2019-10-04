using System.Collections.Generic;

namespace RoleplayGame.Items
{
    public class GuanteDePoder : IItem, IAttackItem
    {
        public List<Gemas> listaGemas = new List<Gemas>();
        Gemas g = new Gemas();

        /// <summary>
        /// El poder de ataque
        /// </summary>
        /// <value></value>
        public int AttackPower
        {
            get
            {
                return listaGemas.Count * 100000;
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
                return 50;
            }
        }

        public override string ToString()
        {
            return "Guantelete de poder que mato a Tony";
        }
    }
}
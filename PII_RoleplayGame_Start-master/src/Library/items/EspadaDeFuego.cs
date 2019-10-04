namespace RoleplayGame.Items
{
    /// <summary>
    /// Interfaz para crear elementos.
    /// </summary>
    public class EspadaDeFuego : IItem, IAttackItem
    {
        public string Tipo => "Fuego";

        public int AttackPower => 20;
        
    }
}
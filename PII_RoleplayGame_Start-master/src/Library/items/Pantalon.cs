namespace RoleplayGame.Items.AttackPower
{
    public class Pantalon : IItem, IAttackItem, IDefenseItem
    {
        public string Tipo => "Madera";
        public string Color => "Verde"; 
        public int AttackPower => 8000;
        public int DefensePower => 1;

    }
}
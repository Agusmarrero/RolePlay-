using System;
namespace RoleplayGame.Items
{
    public class CapaDeInvisibilidad : IAttackItem, IItem, IDefenseItem
    {
        public CapaDeInvisibilidad()
        {
        }

        public int AttackPower => 9000;

        public int DefensePower => 1;
    }
}
using RoleplayGame.Characters;
using RoleplayGame.Items;
using System;
using System.Collections.Generic;
namespace RoleplayGame.Scenarios
{
    public class EscenarioBatalla : IScenario
    {
        public void Run()
        {
            throw new System.NotImplementedException();
        }

        public void Setup()
        {
            Character agustina = new Troll("Agustina");
            Character Rafa = new Elf("Rafael");
            Character Santy = new Wizard("El Santy");
            Character nico = new Troll("El crack");

            IItem espadadefuego = new EspadaDeFuego();
            IItem palardo = new Palote();
            IItem coraza = new Coraza();
            IItem calibre_sinbalas_quepegaigual = new Calibre();
            IItem pantalardoepico = new Pantalon();
            IItem Epikpa = new CapaDeInvisibilidad();

            List<IItem> Objetos = new List<IItem> { espadadefuego, palardo, coraza, calibre_sinbalas_quepegaigual, pantalardoepico, Epikpa };
            List<Character> pejotas = new List<Character> { agustina, Rafa, Santy, nico };

            Random random = new Random();

            foreach (Character pejota in pejotas)
            {
                for (int i = 0; i < 2; i++)
                {
                    int num = random.Next();
                    pejota.AddItem(Objetos[num]);
                }
            }
        }
    }
}
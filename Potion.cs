using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primerproyecto
{
    class Potion : Item
    {
        int Healing = 20;
        public Potion() {
            int Healing = 20;
        }
        
        public void Apply(Character character)
        {
            character.Heal(Healing);

            Console.WriteLine($"{character.Name} ha usado una poción y se ha recuperado {Healing} puntos de vida. Vida actual: {character.CurrentHP}");

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primerproyecto
{
    class Helmet : Protection
    {

        public Helmet(String name, int armor)
        {
            Name = name;
            Armor = armor;
        }
        public override void Apply(Character character)
        {
            
            character.EquipProtection(this);
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primerproyecto
{
    class Sword : Weapon
    {
        
        public Sword(String name, int damage)
        {
            Name = name;
            Damage = damage;
        }
        public override void Apply(Character character)
        {
            
            character.EquipWeapon(this);
        }
        
    }
}

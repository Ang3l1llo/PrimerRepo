using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primerproyecto
{
    abstract class Weapon : Item
    {
        public String Name { get; set; }
        public int Damage { get; set; }
        public abstract void Apply(Character character);
           
        
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primerproyecto
{
    class Character
    {
        public string Name { get; set; }
        public int Lvl { get; set; }
        public int MaxHitPoints { get; set; }
        public int CurrentHP { get; set; }
        public int BaseDamage { get; set; }
        public int CurrentDamage { get; set; }
        public int BaseArmor { get; set; }
        public int CurrentArmor { get; set; }

        private List<Item> _inventory;

        private Weapon equippedWeapon;

        private Protection equippedProtection;

        public Character(string name)
        {
            Name = name;
            Lvl = 1;
            MaxHitPoints = 100;
            CurrentHP = MaxHitPoints;
            BaseDamage = 10;
            CurrentDamage = BaseDamage;
            BaseArmor = 5;
            CurrentArmor = BaseArmor;
            _inventory = new List<Item>();
        }

        public int Attack()
        {

            if (equippedWeapon != null)
            {
                CurrentDamage = BaseDamage + equippedWeapon.Damage;
            }
            else
            {
                CurrentDamage = BaseDamage;
            }

            return CurrentDamage;
        }
        public int Defense()
        {
            if (equippedProtection != null)
            {
                CurrentArmor = BaseArmor + equippedProtection.Armor;
            }
            else
            {
                CurrentArmor = BaseArmor;
            }

            return CurrentArmor;

        }
        public void Heal(int healing)
        {
            CurrentHP += healing;
            if (CurrentHP > MaxHitPoints)
            {
                CurrentHP = MaxHitPoints;
            }
        }
        public int RecieveDamage(int damage)
        {
            int reducedDamage = Math.Max(0, damage - Defense()); //Devuelve 0 o devuelve el daño recibido una vez restada la def
            CurrentHP -= reducedDamage;
            if (CurrentHP < 0)
            {
                CurrentHP = 0;
            }
            return CurrentHP;

        }
        public void AddToInventory(Item item)
        {
            _inventory.Add(item);
        }
        public void EquipWeapon(Weapon weapon)
        {
            equippedWeapon = weapon;
            CurrentDamage = BaseDamage + weapon.Damage; // Actualiza el daño con el arma equipada
            Console.WriteLine($"{Name} se ha equipado {weapon.Name}, ahora tiene {Attack()} de daño.");

        }
        public void EquipProtection(Protection protection)
        {
            equippedProtection = protection;
            CurrentArmor = BaseArmor + protection.Armor; // Actualiza la armadura
            Console.WriteLine($"{Name} se ha equipado {protection.Name}, ahora tiene {Defense()} de armadura.");
        }
    }
}

using System;

namespace Inheritance
{
    class Program
    {

        static void Main(string[] args)
        {

        }

    }
    public abstract class Equipment
    {
        public virtual void Equip()
        {

        }
    }
    public abstract class Pickup
    {
        public virtual void onPickup()
        {

        }
        public virtual void HitByMouse(float x, float y)
        {

        }
    }
    public class HealPotion : Pickup
    {
        public override void onPickup()
        {
            base.onPickup();
            Console.WriteLine("Collected healpotion");
        }
    }
    public class ManaPotion : Pickup
    {
        public override void onPickup()
        {
            base.onPickup();
            Console.WriteLine("Collected manapotion");
        }
    }
    public class Armor : Equipment
    {
        public override void Equip()
        {
            base.Equip();
            Console.WriteLine("Equiped Shield");
        }
    }
    public class Wapeaon : Equipment
    {
        public override void Equip()
        {
            base.Equip();
            Console.WriteLine("Equiped Sword");
        }
    }
}

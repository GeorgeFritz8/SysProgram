using System;

namespace SusPog
{
    class Program
    {
        static void Main(string[] args) {
            enemy enemy = new enemy();
            Console.WriteLine($"Enemy has {enemy.Health} health \n");
            while (enemy.Health > 0)
            {
                if (Int32.TryParse(Console.ReadLine(), out int result))
                {
                    enemy.takeDamage(result);
                }
                else
                {
                    Console.WriteLine("Please fill in a number \n");
                }
            }
        }
    }

    class enemy
    {
        public static float Health = 20;

        public static void takeDamage(int damageAmount) {
            Health -= damageAmount;
            Console.WriteLine($"The enemy took {damageAmount} damage and has {Health} health remaining");
        }
    }
}

using System;

namespace Class_Method_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //In the Main() method, instantiate the MathMethods class
            MathMethods math = new MathMethods();
            //Call the static methods from MathMethods class
            Console.WriteLine("Input a number:");
            int magic = Convert.ToInt32(Console.ReadLine());
            int hitpoints = MathMethods.Heal(magic);
            Console.WriteLine("Hitpoints after healing: " + hitpoints);
            Console.ReadLine();

            Console.WriteLine("Input enemy defense:");
            int enemyDefense = Convert.ToInt32(Console.ReadLine());
            int damage = MathMethods.Defense(enemyDefense);
            Console.WriteLine("Damage dealt: " + damage);
            Console.ReadLine();

            Console.WriteLine("Input enemy strength:");
            int strength = Convert.ToInt32(Console.ReadLine());
            int attackDamage = MathMethods.Attack(strength);
            Console.WriteLine("Damage dealt with attack: " + attackDamage);
            Console.ReadLine();
        }
    }
}
using System;

namespace Class_Method_Assignment
{
    public class MathMethods
    {
        //Create three methods that take one integer parameter and return an integer
        public static int Heal(int magic)
        {
            int hitpoints = magic + 10;
            return hitpoints;
        }

        public static int Defense(int enemyDefense)
        {
            int enemy_str = 7;
            int weapon_mt = 11;
            int trangle_bonus = -1;
            int crit_coeff = 1;
            int damage = (enemy_str + (weapon_mt + trangle_bonus) * crit_coeff) - enemyDefense;
            return damage;
        }

        public static int Attack(int strength)
        {
            int enemy_def = 4;
            int weapon_mt = 8;
            int triangle_bonus = 1;
            int crit_coeff = 3;
            int damage = (strength + (weapon_mt + triangle_bonus) - enemy_def) * crit_coeff;
            return damage;
        }
    }
}
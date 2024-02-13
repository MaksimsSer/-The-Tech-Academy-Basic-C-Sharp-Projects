using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodAssignment
{
    public class MathMethods
    {
        public static int Heal(int magic)
        {
            int hitpoints = magic + 10;
            return hitpoints;
        }

        public static int Defense(int defense)
        {
            int enemyStr = 7;
            int weaponMt = 11;
            int triangleBonus = -1;
            int critCoeff = 1;
            int damage = (enemyStr + (weaponMt + triangleBonus) - defense) * critCoeff;
            return damage;
        }

        public static int Attack(int strength)
        {
            int enemyDef = 4;
            int weaponMt = 8;
            int triangleBonus = 1;
            int critCoeff = 3;
            int damage = (strength + (weaponMt + triangleBonus) - enemyDef) * critCoeff;
            return damage;
        }
    }
}

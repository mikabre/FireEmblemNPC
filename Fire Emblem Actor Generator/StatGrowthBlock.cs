using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fire_Emblem_Actor_Generator
{
    public class StatGrowthBlock
    {
        public int hp { get; set; }
        public int str { get; set; }
        public int mag { get; set; }
        public int skill { get; set; }
        public int spd { get; set; }
        public int def { get; set; }
        public int res { get; set; }

        public StatGrowthBlock()
        {
            //do fuck all, lol!
        }

        public StatGrowthBlock(int hp, int str, int mag, int skill, int spd, int def, int res)
        {
            this.hp = hp;
            this.str = str;
            this.mag = mag;
            this.skill = skill;
            this.spd = spd;
            this.def = def;
            this.res = res;
        }

        public virtual void Display()
        {
            Console.WriteLine("HP GROWTH: {0}%", hp);
            Console.WriteLine("STR GROWTH: {0}%", str);
            Console.WriteLine("MAG GROWTH: {0}%", mag);
            Console.WriteLine("SKILL GROWTH: {0}%", skill);
            Console.WriteLine("SPD GROWTH: {0}%", spd);
            Console.WriteLine("DEF GROWTH: {0}%", def);
            Console.WriteLine("RES GROWTH: {0}%", res);
        }
    }
}
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

        public virtual string Display()
        {
            string output = "HP GROWTH: " + hp + "%" + Environment.NewLine;
            output += "STR GROWTH: " + str + "%" + Environment.NewLine;
            output += "MAG GROWTH: " + mag + "%" + Environment.NewLine;
            output += "SKILL GROWTH: " + skill + "%" + Environment.NewLine;
            output += "SPD GROWTH: " + spd + "%" + Environment.NewLine;
            output += "DEF GROWTH: " + def + "%" + Environment.NewLine;
            output += "RES GROWTH: " + res + "%" + Environment.NewLine;

            return output;
        }
    }
}
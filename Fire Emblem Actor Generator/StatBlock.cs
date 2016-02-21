using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fire_Emblem_Actor_Generator
{
    public class StatBlock
    {
        public int level { get; set; }
        public int hp { get; set; }
        public int str { get; set; }
        public int mag { get; set; }
        public int skill { get; set; }
        public int spd { get; set; }
        public int def { get; set; }
        public int res { get; set; }
        public int move { get; set; }
        public int con { get; set; }

        public StatBlock()
        {
            //do fuck all, lol
        }

        public StatBlock(int hp, int str, int mag, int skill, int spd, int def, int res, int move, int con)
        {
            level = 1;
            this.hp = hp;
            this.str = str;
            this.mag = mag;
            this.skill = skill;
            this.spd = spd;
            this.def = def;
            this.res = res;
            this.move = move;
            this.con = con;
        }

        public virtual string Display()
        {
            string output = "LEVEL: " + level + Environment.NewLine;
            output += "HP: " + hp + Environment.NewLine;
            output += "STR: " + str + Environment.NewLine;
            output += "MAG: " + mag + Environment.NewLine;
            output += "SKILL: " + skill + Environment.NewLine;
            output += "SPD: " + spd + Environment.NewLine;
            output += "DEF: " + def + Environment.NewLine;
            output += "RES: " + res + Environment.NewLine;
            output += "MOVE: " + move + Environment.NewLine;
            output += "CON: " + con + Environment.NewLine;

            return output;
        }

    }
}
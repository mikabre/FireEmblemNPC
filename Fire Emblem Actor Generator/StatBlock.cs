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

        public virtual void Display()
        {
            Console.WriteLine("LEVEL: {0}", level);
            Console.WriteLine("HP: {0}", hp);
            Console.WriteLine("STR: {0}", str);
            Console.WriteLine("MAG: {0}", mag);
            Console.WriteLine("SKILL: {0}", skill);
            Console.WriteLine("SPD: {0}", spd);
            Console.WriteLine("DEF: {0}", def);
            Console.WriteLine("RES: {0}", res);
            Console.WriteLine("MOVE: {0}", move);
            Console.WriteLine("CON: {0}", con);
        }

    }
}
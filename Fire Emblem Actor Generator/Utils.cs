using Fire_Emblem_Actor_Generator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fire_Emblem_Actor_Generator
{
    static class Utils
    {
        public static void LevelActor(this Actor actor, int level)
        {
            Random rnd = new Random();
            while (actor.statBlock.level < level)
            {
                actor.statBlock.level++;
                if(rnd.Next(1, 101) < actor.statGrowthBlock.hp)
                {
                    actor.statBlock.hp++;
                }
                if (rnd.Next(1, 101) < actor.statGrowthBlock.str)
                {
                    actor.statBlock.str++;
                }
                if (rnd.Next(1, 101) < actor.statGrowthBlock.mag)
                {
                    actor.statBlock.mag++;
                }
                if (rnd.Next(1, 101) < actor.statGrowthBlock.skill)
                {
                    actor.statBlock.skill++;
                }
                if (rnd.Next(1, 101) < actor.statGrowthBlock.spd)
                {
                    actor.statBlock.spd++;
                }
                if (rnd.Next(1, 101) < actor.statGrowthBlock.def)
                {
                    actor.statBlock.def++;
                }
                if (rnd.Next(1, 101) < actor.statGrowthBlock.res)
                {
                    actor.statBlock.res++;
                }
            }
        }
    }
}

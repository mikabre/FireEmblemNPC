using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fire_Emblem_Actor_Generator
{
    static class Utils
    {
        public static StatBlock LevelActor(StatBlock statBlock, StatGrowthBlock statGrowthBlock, int level)
        {
            Random rnd = new Random();
            while (statBlock.level < level)
            {
                var props = statGrowthBlock.GetType().GetProperties();
                foreach (var prop in props)
                {
                    if (LevelStat(prop., rnd))
                    {
                        statBlock.hp++;
                    }
                }

                level = 0;
            }
            return statBlock;
        }

        public static bool LevelStat(int growth, Random rnd)
        {
            if (rnd.Next(1, 100) <= growth)
            {
                return true;
            } else
            {
                return false;
            }
        }
    }
}

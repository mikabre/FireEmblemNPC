using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fire_Emblem_Actor_Generator.Jobs
{
    public class Cleric : Actor
    {
        public string gender { get; set; }
        public string name { get; set; }
        public StatBlock statBlock { get; set; }
        public StatGrowthBlock statGrowthBlock { get; set; }
        public StatGrowthBlock statFollowerGrowthBlock { get; set; }
        public StatGrowthBlock statCustomGrowthBlock { get; set; }

        public Cleric(int level, bool follower)
        {
            statBlock = new StatBlock(14, 0, 4, 4, 5, 0, 4, 5, 5);
            statGrowthBlock = new StatGrowthBlock(55, 15, 45, 40, 45, 15, 40);
            statFollowerGrowthBlock = new StatGrowthBlock(50, 10, 40, 35, 40, 10, 35);
            level = 1;
            Random rnd = new Random();
            if (rnd.Next(0, 1) == 0)
            {
                gender = "Male";
            }
            else
            {
                gender = "Female";
            }
            if(statBlock.level < level)
            {
                if (follower == true)
                {

                }
                else
                {

                }
            }
        }

        void Actor.Display()
        {
            throw new NotImplementedException();
        }
    }
}

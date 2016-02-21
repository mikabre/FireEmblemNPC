using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fire_Emblem_Actor_Generator
{
    public class Actor : IActor
    {
        public string gender { get; set; }
        public string name { get; set; }
        public StatBlock statBlock { get; set; }
        public StatGrowthBlock statGrowthBlock { get; set; }

        public Actor(int level)
        {
            Random rnd = new Random();
            statBlock = new StatBlock();
            statGrowthBlock = new StatGrowthBlock();

            if (rnd.Next(0, 2) == 0)
            {
                gender = "Male";
            }
            else
            {
                gender = "Female";
            }
            if(statBlock.level < level)
            {
              
            }
        }

        public string Display()
        {
            return gender + " " + name + Environment.NewLine + statBlock.Display() + statGrowthBlock.Display();
        }
    }
}

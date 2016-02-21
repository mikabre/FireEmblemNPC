using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fire_Emblem_Actor_Generator
{
    public interface Actor
    {
        string name { get; set; }
        string gender { get; set; }
        StatBlock statBlock { get; set; }
        StatGrowthBlock statGrowthBlock { get; set; }
        StatGrowthBlock statFollowerGrowthBlock { get; set; }
        StatGrowthBlock statCustomGrowthBlock { get; set; }

        void Display();
    }
}

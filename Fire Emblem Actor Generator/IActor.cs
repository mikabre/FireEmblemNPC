using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fire_Emblem_Actor_Generator
{
    public interface IActor
    {
        string name { get; set; }
        string gender { get; set; }
        StatBlock statBlock { get; set; }
        StatGrowthBlock statGrowthBlock { get; set; }

        string Display();
    }
}

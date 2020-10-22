using System;
using System.Collections.Generic;
using System.Text;

namespace ClassDemoOfDiffDesignPatterns.pattern.composite
{
    public class LeafBox:IComponent
    {
        public int Weight { get; set; }

        public LeafBox():this(0)
        {
        }

        public LeafBox(int weight)
        {
            Weight = weight;
        }

        public int TotalWeight()
        {
            return Weight;
        }
    }
}

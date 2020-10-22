using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace ClassDemoOfDiffDesignPatterns.pattern.composite
{
    public class Composite:IComponent
    {
        private List<IComponent> components = new List<IComponent>();

        public void Add(IComponent comp)
        {
            components.Add(comp);
        }

        public void Remove(IComponent comp)
        {
            components.Remove(comp);
        }



        //public int Weight { get; }

        public int TotalWeight()
        {
            int sum = 0;
            foreach (IComponent component in components)
            {
                sum += component.TotalWeight();
            }

            return sum;
        }
    }
}

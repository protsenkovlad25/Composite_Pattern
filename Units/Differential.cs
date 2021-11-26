using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Car_Composite.Components;
using Car_Composite.Details;

namespace Car_Composite.Units
{
    class Differential : Composite
    {
        public Differential(int quantity, int weight) 
            : base(quantity, weight)
        {
            Name = "Differential";
            Components.Add(new Gears(5, 1));
            Components.Add(new Bearing(3, 1));
            Components.Add(new Shank(1, 1));
        }
}
}

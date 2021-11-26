using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Car_Composite.Components;
using Car_Composite.Details;

namespace Car_Composite.Units
{
    class Wheel : Composite
    {
        public Wheel(int quantity, int weight) 
            : base(quantity, weight)
        {
            Name = "Wheel";
            Components.Add(new Disk(1, 1));
            Components.Add(new Tire(1, 1));
        }
    }
}

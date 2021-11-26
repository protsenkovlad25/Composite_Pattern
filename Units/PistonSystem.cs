using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Car_Composite.Components;
using Car_Composite.Details;

namespace Car_Composite.Units
{
    class PistonSystem : Composite
    {
        public PistonSystem(int quantity, int weight) 
            : base(quantity, weight)
        {
            Name = "PistonSystem";
            Components.Add(new Piston(4, 1));
            Components.Add(new Crankshaft(1, 1));
            Components.Add(new Link(4, 1));
            Components.Add(new Gasket(1, 1));
        }
}
}

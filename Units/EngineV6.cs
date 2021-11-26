using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Car_Composite.Components;
using Car_Composite.Details;

namespace Car_Composite.Units
{
    class EngineV6 : Composite
    {
        public EngineV6(int quantity, int weight) 
            : base(quantity, weight)
        {
            Name = "EngineV6";
            Components.Add(new PistonSystem(1, 1));
            Components.Add(new ValueSystem(1, 1));
            Components.Add(new IntakeManifold(1, 1));
            Components.Add(new ExhaustManifold(2, 1));
            Components.Add(new Radiator(1, 1));
        }
}
}

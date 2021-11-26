using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Car_Composite.Components;
using Car_Composite.Details;

namespace Car_Composite.Units
{
    class ValueSystem : Composite
    {
        public ValueSystem(int quantity, int weight) 
            : base(quantity, weight)
        {
            Name = "ValueSystem";
            Components.Add(new Value(24, 1));
            Components.Add(new Camshaft(2, 1));
        }
}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Car_Composite.Components;
using Car_Composite.Details;

namespace Car_Composite.Units
{
    class Car : Composite
    {
        public Car(int quantity, int weight) 
            : base(quantity, weight)
        {
            Name = "Car";
            Components.Add(new EngineV6(1, 1));
            Components.Add(new Wheel(4, 1));
            Components.Add(new Transmission(1, 1));
            Components.Add(new Differential(2, 1));
            Components.Add(new Door(4, 1));
            Components.Add(new GasTank(1, 1));
        }
}
}

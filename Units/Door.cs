using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Car_Composite.Components;
using Car_Composite.Details;

namespace Car_Composite.Units
{
    class Door : Composite
    {
        public Door(int quantity, int weight) 
            : base(quantity, weight)
        {
            Name = "Door";
            Components.Add(new Glass(1, 1));
            Components.Add(new DoorCard(1, 1));
        }
}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Composite.Components
{
    abstract class Component
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public int Weight { get; set; }

        public abstract Total Info(Total result, int quantity);

        public Component(int quantity, int weight)
        {
            Quantity = quantity;
            Weight = weight;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Composite.Components
{
    class Leaf : Component
    {
        public bool component = false;

        public Leaf(int quantity, int weight) 
            : base(quantity, weight)
        {
        }

        public override Total Info(Total result, int quantity)
        {
            Console.WriteLine($"    {Name} (Q-{Quantity}, W-{Weight})");

            result.TotalQuantity += (Quantity * quantity);
            result.TotalWeight += (Weight * Quantity * quantity);

            return result;
        }
    }
}

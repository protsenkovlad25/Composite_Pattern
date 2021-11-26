using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Composite.Components
{
    class Leaf : Component
    {
        public Leaf(int quantity, int weight) 
            : base(quantity, weight)
        {
        }

        public override Total Info(Total result, int quantity)
        {
            Console.WriteLine($"    {Name} ({Quantity}, {Weight})");

            result.TotalQuantity += (Quantity * quantity);
            result.TotalWeight += Weight;

            return result;
        }
    }
}

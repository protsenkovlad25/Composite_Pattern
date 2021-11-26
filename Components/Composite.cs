using System;
using System.Collections.Generic;

namespace Car_Composite.Components
{
    class Composite : Component
    {
        public List<Component> Components { get; set; } = new List<Component>();

        public Composite(int quantity, int weight)
            : base(quantity, weight)
        {
        }

        public override Total Info(Total result, int quantity)
        {
            Console.WriteLine($"{Name} ({Quantity}, {Weight})");
            
            foreach (Component component in this.Components)
            {
                result = component.Info(result, Quantity);
            }

            result.TotalQuantity += Quantity;
            result.TotalWeight += Weight;

            return result;
        }
    }
}

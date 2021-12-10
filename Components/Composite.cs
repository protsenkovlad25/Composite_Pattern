using System;
using System.Collections.Generic;

namespace Car_Composite.Components
{
    class Composite : Component
    {
        public bool component = true;

        public List<Component> Components { get; set; } = new List<Component>();

        public Composite(int quantity, int weight)
            : base(quantity, weight)
        {
        }

        public override Total Info(Total result, int quantity)
        {
            Console.WriteLine($"{Name}");
            
            foreach (Component component in this.Components)
            {
                result = component.Info(result, Quantity);
            }

            result.TotalQuantity += Quantity;

            return result;
        }
    }
}

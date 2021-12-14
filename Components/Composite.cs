using System;
using System.Collections.Generic;

namespace Car_Composite.Components
{
    class Composite : Component
    {
        public bool component = true;
        public int weight = 0;

        public List<Component> Components { get; set; } = new List<Component>();

        public Composite(int quantity, int weight)
            : base(quantity, weight)
        {
        }

        public override Total Info(Total result, int quantity)
        {
            foreach (Component component in this.Components)
            {
                result = component.Info(result, Quantity);
                Weight += component.Weight;
            }

            Console.WriteLine($"{Name} (W-{Weight})");

            result.TotalQuantity += Quantity;

            return result;
        }
    }
}

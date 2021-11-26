using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Car_Composite.Components;

namespace Car_Composite.Details
{
    class Link : Leaf
    {
        public Link(int quantity, int weight) 
            : base(quantity, weight)
        {
            Name = "Link";
        }
}
}

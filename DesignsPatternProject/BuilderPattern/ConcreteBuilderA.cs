using System;
using System.Collections.Generic;
using System.Text;

namespace DesignsPatternProject
{
    class ConcreteBuilderA:Builder
    {
        private Product product = new Product();

        public override void BuildPartA()
        {
            product.Add("part a");
        }

        public override void BuildPartB()
        {
            product.Add("part b");
        }

        public override Product GetRestult()
        {
            return product;
        }

    }
}

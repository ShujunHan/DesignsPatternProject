using System;
using System.Collections.Generic;
using System.Text;

namespace DesignsPatternProject
{
    class ConcreateBuilderB:Builder
    {
        private Product product = new Product();

        public override void BuildPartA()
        {
            product.Add("part X");
        }

        public override void BuildPartB()
        {
            product.Add("part Y");
        }

        public override Product GetRestult()
        {
            return product;
        }

    }
}

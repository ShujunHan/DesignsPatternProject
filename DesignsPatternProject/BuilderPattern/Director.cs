using System;
using System.Collections.Generic;
using System.Text;

namespace DesignsPatternProject
{
    class Director
    {
        public void Build(Builder builder)
        {
            builder.BuildPartA();
            builder.BuildPartB();
        }
    }
}

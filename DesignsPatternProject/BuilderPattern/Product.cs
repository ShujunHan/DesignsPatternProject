using System;
using System.Collections.Generic;
using System.Text;

namespace DesignsPatternProject
{
    class Product
    {
        List<string> list = new List<string>();

        public void Add(string content)
        {
            list.Add(content);
        }

        public void Show()
        {
            Console.WriteLine(" Display Product");
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }
        }

    }
}

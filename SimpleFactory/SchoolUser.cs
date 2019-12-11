using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactory
{
    class SchoolUser
    {
        public string fristName;
        public string lastName;
        public string userType;

        public void Show()
        {
            Console.WriteLine("fristName" + fristName);
            Console.WriteLine("lastName" + lastName);
            Console.WriteLine("userType" + userType);
        }
    }
}

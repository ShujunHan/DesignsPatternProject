using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactory
{
    class SchoolTeacher : SchoolUser
    {
        public SchoolTeacher()
        {
            fristName = "Patercia";
            lastName = "Terry";
            userType = "Teacher";
        }
    }
}

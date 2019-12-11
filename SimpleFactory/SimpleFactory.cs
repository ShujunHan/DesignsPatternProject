using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactory
{
    class SimpleFactory
    {
        public static SchoolUser GetSchoolUser(string user , string passworld)
        {
            if ("Patercia" == user && "Patercia" == passworld)
            {
                return new SchoolPrincipal();
            }
            if ("Teacher" == user && "Teacher" == passworld)
            {
                return new SchoolTeacher();
            }

            return null;
        }
    }
}

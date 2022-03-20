using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsTestUnitTest
{
    public class LastName
    {
        public string GetLastName(int empId)
        {
            string name;
            if (empId == 1)
            {
                name = "chitruk";
            }

            else
            {
                name = "Not Found";
            }
            return name;
        }

    }
}

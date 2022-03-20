using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSTest
{
    public class MobileNo
    {
        public string GetPhoneNo(int empId)
        {
            string number;
            if (empId == 1)
            {
                number = "8208508814";
            }

            else
            {
                number = "Not Found";
            }
            return number;
        }
    }
}

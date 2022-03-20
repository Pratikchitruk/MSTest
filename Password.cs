using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSTest
{
    public class Password
    {
        public string GetPassword(int empId)
        {
            string password;
            if (empId == 1)
            {
                password = "1234567";
            }

            else
            {
                password = "Not Found";
            }
            return password;
        }
    }
}

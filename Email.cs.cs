using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSTest
{
    public class Email
    {
        public string GetEmail(int empId)
        {
            string email;
            if (empId == 1)
            {
                email = "pratik.chitruk@gmail.com";
            }

            else
            {
                email = "Not Found";
            }
            return email;
        }
    }
}

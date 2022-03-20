using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSTest
{
    public class FirstName
    {
        public string GetFirstName(int empId)
        {
            string name;
            if (empId == 1)
            {
                name = "pratik";
            }
           
            else
            {
                name = "Not Found";
            }
            return name;

            
        }

    }
}

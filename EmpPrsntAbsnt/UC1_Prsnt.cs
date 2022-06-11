using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    internal class UC1_Prsnt
    {
        public const int IsAbsnt = 0;
        public const int IsPresent = 1;

        public int IsEmployeePresent()
        {
            return new Random().Next(0, 2);
        }
        public void CalculateWage()
        {
            switch (IsEmployeePresent())
            {
                case IsAbsnt:
                    Console.WriteLine("Employee is Not Present");
                    break;
                case IsPresent:
                    Console.WriteLine("Employee is Present");
                    break;
            }


        }
 
    }
}

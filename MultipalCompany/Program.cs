﻿namespace EmpWageMultipleCmpnyWithDict
{

    class program
    {

        public static void Main(String[] args)
        {
            EmpWage Empwage = new EmpWage();
            Empwage.AddCompany("Dell", 23, 22, 11, 44, 33);
            Empwage.AddCompany("Tcs", 3, 2, 11, 4, 3);
            Empwage.CalculateWage("Tcs");
            Empwage.CalculateWage("Dell");
        }
    }
}

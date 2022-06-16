using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpwagewithCmpny
{
    internal class EmpWageCmpny
    {
        public int EmpCheak = 1;
        // public int Wage_Per_Hours = 20;
        // public int FullTime_Daily_Hours = 8;
        // public int PartTime_Day_Hours = 4;
        public const int FullTime = 1;
        public int DailyWage = 0;
        public int Num_Working_permonth = 20;
        public const int ISAbest = 0;
        public float EmpDailyWage = 0;
        public const int IsPartTime = 2;
        public float EmpMonthlyWage = 0;
        //public const int Max_WorkingDay = 20;
        // public const int Max_WorkingHrs = 100;
        private Dictionary<String, Company> Compaies = new Dictionary<String, Company>();
        public string[] Companylist;
        public int Arrayindex = 0;
        public EmpWageCmpny(int number)
        {
            Companylist = new String[2 * number];
        }
        public void AddCompany(String CompanyName, int EmpWagePerHourse, int FullTime_Daily_Hours, int PartTime_Day_Hours, int Max_WorkingHrs, int Max_WorkingDay)
        {
            Company company = new Company(CompanyName.ToLower(), EmpWagePerHourse, FullTime_Daily_Hours, PartTime_Day_Hours, Max_WorkingDay, Max_WorkingHrs);
            Compaies.Add(CompanyName.ToLower(), company);
            Companylist[Arrayindex] = CompanyName;
            Arrayindex++;
        }
        public int IsEmpPeresnt()
        {
            return new Random().Next(0, 3);
        }

        public void CalculateWage(String CompanyName)
        {
            int DayNumber = 1;
            int EmpWorkingHrs = 0;
            int TotalWorkingHrs = 0;

            if (!Compaies.ContainsKey(CompanyName.ToLower()))
                throw new ArgumentNullException("Company don't exist");

            Compaies.TryGetValue(CompanyName.ToLower(), out Company company);
            while (DayNumber <= company.Max_WorkingDay && TotalWorkingHrs <= company.Max_WorkingHrs)
            {
                switch (IsEmpPeresnt())
                {
                    case ISAbest:
                        EmpWorkingHrs = 0;
                        break;
                    case IsPartTime:
                        EmpWorkingHrs = company.PartTime_Day_Hours;
                        break;
                    case FullTime:
                        EmpWorkingHrs = company.FullTime_Daily_Hours;
                        break;
                }
                EmpDailyWage = EmpWorkingHrs * company.EmpWagePerHourse;
                EmpMonthlyWage += EmpDailyWage;
                DayNumber++;
                TotalWorkingHrs += EmpWorkingHrs;
            }
            Companylist[Arrayindex] = Convert.ToString(TotalWorkingHrs);
            Arrayindex++;

            Console.WriteLine("\n Total WorkingDays : " + (DayNumber - 1) + "\nTotalWorkingHrs : " + TotalWorkingHrs);
        }

        public void displayArray()
        {
            for(int i = 0; i<Companylist.Length; i+=2)
            {
                Console.WriteLine("Monthly wage for {0} and {1}" ,Companylist[i] ,Companylist[i+1]);
            }
        }

    }
}
   

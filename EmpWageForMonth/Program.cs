namespace EmployeeWage
{
    class program
    {
        public static void Main(String[]args)
        {
            //UC1_Prsnt present = new UC1_Prsnt();
            //present.CalculatePresent();

            UC5_EmpWageForMonth dlywage = new UC5_EmpWageForMonth();
            dlywage.CalculateWage();
        }
    }
}

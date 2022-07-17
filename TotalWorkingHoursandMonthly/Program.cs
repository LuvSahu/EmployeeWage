namespace EmployeeWage
{
    class program
    {
        public static void Main(String[]args)
        {
            //UC1_Prsnt present = new UC1_Prsnt();
            //present.CalculatePresent();

            UC6_TotalworkingHoursandMonthly dlywage = new UC6_TotalworkingHoursandMonthly();
            dlywage.CalculateWage();
        }
    }
}

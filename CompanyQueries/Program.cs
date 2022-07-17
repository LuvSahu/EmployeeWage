namespace EmployeeWage
{
    class program
    {
        public static void Main(String[]args)
        {
            //UC1_Prsnt present = new UC1_Prsnt();
            //present.CalculatePresent();

            //UC2_dailywage dlywage = new UC2_dailywage();
            //dlywage.CalculateWage();

            //RefactorCode refactorCode = new RefactorCode();
            //refactorCode.CalculateEmpWage();

            EmployeeWageComputation employeeComputation = new EmployeeWageComputation(2);
            employeeComputation.AddCompany("TATA", 20, 8, 4, 100, 20);
            employeeComputation.CalculateEmpWage("TATA");
            employeeComputation.AddCompany("MAHINDRA", 30, 8, 4, 100, 20);
            employeeComputation.CalculateEmpWage("MAHINDRA");

            //employeeComputation.displayArray();
            Console.WriteLine("enter the name of the company you want to see the total wage of: ");
            string Name = Console.ReadLine();
            employeeComputation.view_Wage(Name);
        }
    }
}

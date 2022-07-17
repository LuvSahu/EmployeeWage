namespace EmpwagewithCmpny
{

    class program
    {

        public static void Main(String[] args)
        {
            EmpWageCmpny Empwage = new EmpWageCmpny(2);
            Empwage.AddCompany("Google", 23, 22, 11, 44, 33);
            Empwage.AddCompany("Atotech", 3, 2, 11, 4, 3);
            Empwage.displayArray();
            Empwage.CalculateWage("Google");
            Empwage.CalculateWage("Atotech");
        }
    }
}

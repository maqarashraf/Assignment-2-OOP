namespace Assignment_2_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee[] EmpArr = new Employee[3];

            EmpArr[0] = new Employee(
                1,
                "Ahmed",
                SecurityLevel.DBA,
                25000,
                new HiringDate(10, 5, 2020),
                Gender.M
            );

            EmpArr[1] = new Employee(
                2,
                "Sara",
                SecurityLevel.Guest,
                10000,
                new HiringDate(15, 8, 2022),
                Gender.F
            );

            EmpArr[2] = new Employee(
                3,  
                "Omar",
                SecurityLevel.Senior, 
                30000,
                new HiringDate(20, 3, 2019),
                Gender.M
            );

            foreach (Employee employee in EmpArr)
            {
                Console.WriteLine(employee);
                Console.WriteLine("-------------------------");
            }
        }
    }
}

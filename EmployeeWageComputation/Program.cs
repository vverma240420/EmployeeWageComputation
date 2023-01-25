namespace EmployeeWageComputation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ispresent = 1;
            Console.WriteLine("Welcome to EmployeeWage Computation");

            //UC1- EmployeeAttendence
            Random random = new Random();
            int empAttendence = random.Next(0, 2); //0 or 1
            if(empAttendence == ispresent)
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {

                Console.WriteLine("Employee is Absent");
            }
            Console.ReadLine();
        }
    }
}
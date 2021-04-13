using System;
using System.Threading.Tasks;

namespace Singleton_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {

            Parallel.Invoke(()=>PrintStudentDetails(),()=>PrintEmployeeDetails());

            Console.ReadLine();
        }

        private static void PrintEmployeeDetails()
        {
            Singleton fromStudent = Singleton.GetInstance;
            fromStudent.PrintDetails("From Student");
        }

        private static void PrintStudentDetails()
        {
            Singleton fromEmployee = Singleton.GetInstance;
            fromEmployee.PrintDetails("From Employee");
        }
    }
}

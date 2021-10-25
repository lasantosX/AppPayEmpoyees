using AppPayEmpoyees.Controllers;
using System;

namespace AppPayEmpoyees
{
    class Program
    {
        static void Main(string[] args)
        {
            //REFERENCE OBJECT ControllerCalculatePay 
            var objControllerCalculatePay = new ControllerCalculatePay();

            //CALL METHOD TO CREATE FILE WITH DATA
            objControllerCalculatePay.CreateFileData();

            Console.WriteLine("Total Values to pay the employees.");
            Console.WriteLine();

            //CALL METHOD FOR CALCULATE VALUES TO PAY FOR ANY EMPLOYEES
            objControllerCalculatePay.CalculatePayEmployee();

        }
    }
}

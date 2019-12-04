using System;

namespace PaySlipOOP
{
    public class Print : IPrint
    {
        public void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }

        public void PrintInitMessage()
        {
            PrintMessage("Welcome to the payslip generator!");
        }

        public void PrintOutcomes(string firstName, string lastName, string startDate, string endDate, int grossIncome,
            int tax, int netIncome, double super)
        { 
            PrintMessage("\n"); 
            PrintMessage("Your payslip has been generated:"); 
            PrintMessage("\n");
            PrintMessage($"Name: {firstName} {lastName}");
            PrintMessage($"Pay Period : {startDate} - {endDate}");
            PrintMessage($"Gross Income : {grossIncome}");
            PrintMessage($"Income Tax: {tax}");
            PrintMessage($"Net Income: {netIncome}");
            PrintMessage($"Super: {super}");
            PrintMessage("Thank you for using MYOB!");
        }
    }
}  
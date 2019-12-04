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
        
        public void PrintFinalMessage()
        {
            PrintMessage("Thank you for using MYOB!");
        }

        public void PrintName(string firstName, string lastName)
        { 
            PrintMessage($"Name: {firstName} {lastName}");
        }

        public void PrintPayPeriod(string startDate, string endDate)
        {
            PrintMessage($"Pay Period : {startDate} - {endDate}");
        }

        public void PrintGrossIncome(int grossIncome)
        {
            PrintMessage($"Gross Income : {grossIncome}");
        }

        public void PrintIncomeTax(int tax)
        {
            PrintMessage($"Income Tax: {tax}");
        }

        public void PrintNetIncome(int netIncome)
        {
            PrintMessage($"Net Income: {netIncome}");
        }

        public void PrintSuper(double super)
        {
            PrintMessage($"Super: {super}");
        }
    }
}
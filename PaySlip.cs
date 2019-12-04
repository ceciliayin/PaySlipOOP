using System;

namespace PaySlipOOP
{ 
    public class PaySlip : IPaySlip
    {
        private readonly IPrint _print;
        private readonly IRead _read;
        private readonly ICalculation _calculator;
        
        public PaySlip(IPrint printAndRead, ICalculation calculator,IRead read)
        {
            _print = printAndRead;
            _read = read;
            _calculator = calculator;
        }

        private string[] UserInputs = new string[6]{".",".",".",".",".","."};
        
        string FirstName;
        string LastName;
        int AnnualSalary;
        int SuperRate;
        string StartDate;
        string EndDate;
        
        public void PaySlipCalculator()
        {
            string[] initialMessage = new string[6] {"Please input your name: ", 
                "Please input your surname: ","Please enter your annual salary: ","Please enter your super rate ",
                "Please enter your payment start date: ","Please enter your payment end date: "};
            
            _print.PrintInitMessage();
            
            int stringCounter=0;
            while ( stringCounter !=6) 
            {
                _print.PrintMessage(initialMessage[stringCounter]);
                UserInputs[stringCounter]=_read.ReadString();
                stringCounter++;
            }
            
            GetUserInputs();
            GetOutcomes();
        }

        private void GetUserInputs()
        {
            FirstName = UserInputs[0];
            LastName= UserInputs[1];
            AnnualSalary = Convert.ToInt32(UserInputs[2]);
            SuperRate = Convert.ToInt32(UserInputs[3]);
            StartDate = UserInputs[4];
            EndDate = UserInputs[5];
        }
        private void GetOutcomes()
        {    
            int grossIncome=_calculator.CalculateGrossIncome(AnnualSalary);
            int tax=_calculator.CalculateIncomeTax(AnnualSalary);
            int netIncome=_calculator.CalculateNetIncome(grossIncome,tax);
            double super = _calculator.CalculateSuper(grossIncome,SuperRate);
            
            _print.PrintMessage("\n");
            _print.PrintMessage("Your payslip has been generated:");
            _print.PrintMessage("\n");
            _print.PrintName(FirstName,LastName);
            _print.PrintPayPeriod(StartDate,EndDate);
            _print.PrintGrossIncome(grossIncome);
            _print.PrintIncomeTax(tax);
            _print.PrintNetIncome(netIncome);
            _print.PrintSuper(super);
            _print.PrintMessage("\n");
            _print.PrintFinalMessage();
        }
    }
}
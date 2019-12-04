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
        
        private string _firstName;
        private string _lastName;
        private int _annualSalary;
        private int _superRate;
        private string _startDate;
        private string _endDate;
        
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
            _firstName = UserInputs[0];
            _lastName= UserInputs[1];
            _annualSalary = Convert.ToInt32(UserInputs[2]);
            _superRate = Convert.ToInt32(UserInputs[3]);
            _startDate = UserInputs[4];
            _endDate = UserInputs[5];
        }
        private void GetOutcomes()
        {    
            int grossIncome=_calculator.CalculateGrossIncome(_annualSalary);
            int tax=_calculator.CalculateIncomeTax(_annualSalary);
            int netIncome=_calculator.CalculateNetIncome(grossIncome,tax);
            double super = _calculator.CalculateSuper(grossIncome,_superRate);
            
            _print.PrintOutcomes(_firstName,_lastName,_startDate, _endDate, grossIncome, tax, netIncome, super);
        }
    }
}
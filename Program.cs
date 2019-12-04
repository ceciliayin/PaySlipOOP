using System;

namespace PaySlipOOP
{
    class Program
    {
        static void Main()
        {
            IPaySlip paySlip=new PaySlip(new Print(), new Calculation(),new Read());
            paySlip.PaySlipCalculator();
        }
    }
}
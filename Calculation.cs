using System;

namespace PaySlipOOP
{
    public class Calculation : ICalculation
    {
        public int CalculateGrossIncome(int annualSalary)
        {
            return Convert.ToInt32(annualSalary / 12);
        }

        public int CalculateIncomeTax(int annualSalary)
        {
            if (annualSalary > 18201 && annualSalary < 37000)
            {
                return Convert.ToInt32((annualSalary - 18200) * 0.19/12);
            }

            if (annualSalary > 37001 && annualSalary < 87000)
            {
                return Convert.ToInt32 ((3572 + (annualSalary - 37000) * 0.325) / 12);
            }

            if (annualSalary < 87001 && annualSalary > 180000)
            {
                return Convert.ToInt32((19822 + (annualSalary - 87000) * 0.37)/12);
            }
            
            return annualSalary>180001 ? Convert.ToInt32((54332 + (annualSalary - 180000) * 0.45)/12) : 0;
        }

        public int CalculateNetIncome(int grossIncome, int tax)
        {
            return Convert.ToInt32 (grossIncome - tax);
        }

        public double CalculateSuper(int grossIncome, int superRate)
        {
            return Convert.ToInt32 (grossIncome * superRate *0.01);
        }
    }
}
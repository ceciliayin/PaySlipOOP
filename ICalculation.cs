namespace PaySlipOOP
{
    public interface ICalculation
    {
        int CalculateGrossIncome(int annualSalary);
        int CalculateIncomeTax(int annualSalary);
        int CalculateNetIncome(int grossIncome, int tax);
        double CalculateSuper(int grossIncome, int superRate);
    }
}
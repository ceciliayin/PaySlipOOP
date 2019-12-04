namespace PaySlipOOP
{
    public interface IPrint
    {
        void PrintMessage(string message);
        void PrintInitMessage();
        void PrintFinalMessage();
        void PrintName(string firstName, string lastName);
        void PrintPayPeriod(string startDate, string endDate);
        void PrintGrossIncome(int grossIncome);
        void PrintIncomeTax(int tax);
        void PrintNetIncome(int netIncome);
        void PrintSuper(double super);
    }
}
namespace PaySlipOOP
{
    public interface IPrint
    {
        void PrintMessage(string message);
        void PrintInitMessage();
        void PrintOutcomes(string firstName, string lastName, string startDate, string endDate, int grossIncome,
            int tax, int netIncome, double super);
    }
}
using System;

namespace PaySlipOOP
{
    public class Read : IRead
    {
        public string ReadString()
        {
            return Console.ReadLine();
        }
    }
}
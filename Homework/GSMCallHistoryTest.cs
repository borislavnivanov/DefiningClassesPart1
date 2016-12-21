using System;


namespace Homework
{
    public class GSMCallHistoryTest
    {
        public static void TestCallHistory()
        {
            GSM phoneOne = new GSM("Galaxy S7 Edge", "Samsung");

            Call first = new Call(phoneOne, DateTime.Now, "0864195525", 167);
            phoneOne.AddCallHistory(first);

            Call second = new Call(phoneOne, DateTime.Now, "0864195545", 220);
            phoneOne.AddCallHistory(second);

            Call thurd = new Call(phoneOne, DateTime.Now, "0846195545", 1000);
            phoneOne.AddCallHistory(thurd);

            phoneOne.PrintCallHistory();
            phoneOne.CallPrice();
            phoneOne.DeleteCallHistory(2);
            phoneOne.PrintCallHistory();
            phoneOne.CallPrice();

            phoneOne.ClearCallHistory();
            phoneOne.PrintCallHistory();
        }
    }
}

using System;

namespace Homework
{
    public class MainStart
    {
        public static void Main()
        {
            GSM phoneOne = new GSM("Galaxy S7", "Samsung");

            Console.WriteLine(phoneOne.ToString());

            GSMTest printPhones = new GSMTest();
            printPhones.PrintPhones();

            printPhones.DisplayInfoIphone4S();

            GSMCallHistoryTest.TestCallHistory();
        }
    }
}

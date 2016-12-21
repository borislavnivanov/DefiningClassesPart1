using System;


namespace Homework
{
    public class GSMTest
    {
        public void PrintPhones()
        {
            GSM[] mobilePhones = this.CreatePhones();
            foreach (var item in mobilePhones)
            {
                Console.WriteLine(item);
            }
        }

        public GSM[] CreatePhones()
        {
            GSM[] mobilePhones =
            {
                new GSM("Galaxy S7 Edge", "Samsung", new Battery(BatteryType.LiIon), new Display()),
                new GSM("G3", "LG", 800, "Ivan Ivanov", new Battery(BatteryType.NiCd), new Display(5.5, "16M")),
                new GSM("M2", "Sony", 200, "Ivan Ivanov", new Battery(BatteryType.LiIon, "H58-758", 80, 20), new Display(5, "16M")),
                new GSM("P9", "Huawei")
            };

            return mobilePhones;
        }

        public void DisplayInfoIphone4S()
        {
            Console.WriteLine(GSM.Iphone4s);
        }
    }
}

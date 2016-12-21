using System;
using System.Collections.Generic;

using System.Text;


namespace Homework
{
    public class GSM
    {
        public static readonly GSM Iphone4s = new GSM("Iphone 4S", "Apple", new Battery(BatteryType.NiMH), new Display());
        private string model;
        private string manufacturer;
        private string owner = null;
        private Battery batteryInfo;
        private Display displayInfo;
        private decimal price;
        private List<Call> callHistory;

        public GSM(string model, string manufacturer)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.callHistory = new List<Call>();
        }
        public GSM(string model, string manufacturer, Battery batteryInfo, Display displayInfo)
            : this(model, manufacturer)
        {
            this.batteryInfo = batteryInfo;
            this.displayInfo = displayInfo;
        }
        public GSM(string model, string manufacturer,decimal price, string owner, Battery batteryInfo, Display displayInfo)
             : this(model, manufacturer, batteryInfo,displayInfo)
        {
            this.price = price;
            this.owner = owner;
        }


        public string Model
        {
            get { return this.model; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Please enter valid model number");
                }
                this.model = value;
            }
        }

        public string Manufacturer
        {
            get { return this.manufacturer; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Please enter valid manufacturer");
                }
                this.manufacturer = value;
            }
        }
        public decimal Price { get; set; }
        public string Owner { get; set; }
        public Battery BatteryInfo { get; set; }
        public Display Displayinfo { get; set; }
        public List<Call> CallHistory { get; set; }


        public override string ToString()
        {
            var builder = new StringBuilder();

            builder.Append("Model: ").Append(this.Model).Append("\r\n");
            builder.Append("Manufacturer: ").Append(this.Manufacturer).Append("\r\n");
            builder.Append("Price: ").Append(this.Price).Append("\r\n");
            builder.Append("Owner: ").Append(this.Owner).Append("\r\n");

            if (this.BatteryInfo != null)
            {
                builder.Append(BatteryInfo.ToString());
            }
            else
            {
                builder.Append("Battery Hours Idle: ").Append("\r\n");
                builder.Append("Battery Hours Talk: ").Append("\r\n");
                builder.Append("Battery Model: ").Append("\r\n");
                builder.Append("Battery Type: ").Append("\r\n");
            }

            if (this.Displayinfo != null)
            {
                builder.Append(this.Displayinfo.ToString());
            }
            else
            {
                builder.Append("Display Size: ").Append("\r\n");
                builder.Append("Display Colors: ").Append("\r\n");
            }
            return builder.ToString();
        }

        public void AddCallHistory(Call call)
        {
            this.CallHistory.Add(call);
        }
        public void DeleteCallHistory(int index)
        {
            this.CallHistory.Remove(this.callHistory[index]);
        }
        public void ClearCallHistory()
        {
            this.CallHistory.Clear();
        }
        public void PrintCallHistory()
        {
            foreach (var item in this.CallHistory)
            {
                Console.WriteLine(item);
            }
        }
        public void CallPrice()
        {
            double sum = 0;
            for (int i = 0; i < this.callHistory.Count; i++)
            {
                sum += (this.callHistory[i].Duration / 60) * 0.37;
            }
            Console.WriteLine($"Total price : {sum:F2} leva");
        }
    }

}

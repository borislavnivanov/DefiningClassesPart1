
using System.Text;


namespace Homework
{
    public class Battery
    {
        private string model;
        private double iddleTime;
        private double talkTime;
        private BatteryType bateryType;

        public Battery()
        {
        }

        public Battery(BatteryType type)
        {
            this.bateryType = type;
        }

        public Battery(BatteryType type, string model)
        {
            this.model = model;
        }

        public Battery(BatteryType type, string model, double iddleTime, double talkTime)
            : this(type, model)
        {
            this.iddleTime = iddleTime;
            this.talkTime = talkTime;
        }

        public string Model { get; set; }
        public double IddleTime { get; set; }
        public double TalkTime { get; set; }
        public BatteryType BatteryTipe { get; set; }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("Battery Hours Idle: ").Append(this.IddleTime).Append("\r\n");
            builder.Append("Battery Hours Talk: ").Append(this.TalkTime).Append("\r\n");
            builder.Append("Battery Model: ").Append(this.Model).Append("\r\n");
            builder.Append("Battery Type: ").Append(this.BatteryTipe).Append("\r\n");
            return builder.ToString();
        }
    }
}

        

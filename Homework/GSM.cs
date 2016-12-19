using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class GSM
    {
        private string model;
        private string manufacture;
        private string owner;



        class Battery
        {
            private string model;
            private string iddleTime;
            private string TalkTime;
        }

        class Display
        {
            private int size;
            private int colours;
        }

        public enum BatteryType
        {
            LiIon,NiMH, NiCd,Other
        }
    }
}


using System.Text;


namespace Homework
{
    public class Display
    {
        private double size;
        private string colors;

        public Display()
        {

        }

        public Display(double size, string colors)
        {
            this.size = size;
            this.colors = colors;
        }

        public double Size
        {
            get
            {
                return this.size;
            }
            set
            {
                this.size = value;
            }
        }
        public string Colors
        {
            get
            {
                return this.colors;
            }
            set
            {
                this.colors = value;
            }
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("Display size: ").Append(this.Size).Append("\r\n");
            builder.Append("Display Colors: ").Append(this.Colors).Append("\r\n");
            return builder.ToString();
        }
    }
}

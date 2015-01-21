using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaptopShop
{
    class Battery
    {
        private string type;
        private double batteryHours;

        public string Type
        {
            get { return this.type; }
            set
            {
                if (value != null && value.Length < 1) throw new ArgumentException("Invalid battery type!");
                this.type = value;
            }
        }
        public double BatteryHours
        {
            get { return this.batteryHours; }
            set
            {
                if (value < 1) throw new ArgumentException("Invalid value for battery hours");
                this.batteryHours = value;
            }
        }
        public Battery(string type, double batteryHours = 0)
        {
            this.Type = type;
            this.BatteryHours = batteryHours;
        }
        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            if (this.Type != null)
            {
                output.AppendLine("battery: " + this.Type);
                
            }
            if (this.BatteryHours > 0)
            {
                output.AppendLine("battery life: " + this.BatteryHours);
            }
            return output.ToString();

        }
    }
}

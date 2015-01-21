using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCCatalog
{
    class Component
    {
        private string componentName;
        private string details;
        private decimal componentPrice;

        public string ComponentName
        {
            get { return this.componentName; }
            set
            {
                if (string.IsNullOrEmpty(value)) throw new ArgumentException("Invalid component name!");
                this.componentName = value;
            }
        }
        public string Details
        {
            get
            {
                return this.details;
            }
            set
            {
                if (value != null && value.Length < 0) throw new ArgumentException("Invalid value for details!");
                this.details = value;
            }
        }
        public decimal ComponentPrice
        {
            get { return this.componentPrice; }
            set
            {
                if (value <= 0) throw new ArgumentException("Value cannot be 0 or negative!");
                this.componentPrice = value;
            }
        }
        public Component(string componentName, decimal componentPrice, string details = null)
        {
            this.ComponentName = componentName;
            this.ComponentPrice = componentPrice;
            this.Details = details;
        }
        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.AppendLine("Component name: " + this.ComponentName);
            if (details != null) output.AppendLine("Component details: " + this.Details);
            output.AppendLine("Component price: " + this.ComponentPrice);
            return output.ToString();
          
        }
        
    }
}

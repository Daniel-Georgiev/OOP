using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCCatalog
{
    class Computer
    {
        private string name;
        private Component processor;
        private Component graphicsCard;
        private Component motherboard;
        public decimal price;
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrEmpty(value)) throw new ArgumentException("Invalid value for computer name!");
                this.name = value;
            }
        }
        public decimal Price
        {
            get
            {
                price += (decimal)processor.ComponentPrice;
                price += (decimal)graphicsCard.ComponentPrice;
                price += (decimal)motherboard.ComponentPrice;
                return price;
            }
        }
        public Component Processor { get; set; }
        public Component GraphicsCard { get; set; }
        public Component Motherboard { get; set; }
        public Computer(string name, Component processor, Component graphicsCard, Component motherboard)
        {
            this.Name = name;
            this.Processor = processor;
            this.GraphicsCard = graphicsCard;
            this.Motherboard = motherboard;
        }
        public override string ToString()
        {
            StringBuilder PCoutput = new StringBuilder();
            PCoutput.AppendLine("PC name: " + this.Name);
            PCoutput.AppendLine("Processor: " + this.Processor);
            PCoutput.AppendLine("Graphics card: " + this.GraphicsCard);
            PCoutput.AppendLine("Motherboard: " + this.GraphicsCard);
            PCoutput.AppendLine("Price: " + this.Price);
            return PCoutput.ToString();
            
        }
    }
}

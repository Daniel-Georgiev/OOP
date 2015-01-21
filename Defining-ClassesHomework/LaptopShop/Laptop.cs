using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaptopShop
{
    class Laptop
    {
        private string model;
        private string manufactorer;
        private string processor;
        private double ram;
        private string graphicsCard;
        private string hdd;
        private string screen;
        private Battery battery;
        private decimal price;
        public string Model
        {
            get { return this.model; }
            set
            {
                if (string.IsNullOrEmpty(value)) throw new ArgumentException("Invalid value for model!");
                this.model = value;
            }
        }
        public string Manufactorer
        {
            get { return this.manufactorer; }
            set
            {
                if (value != null && value.Length < 0) throw new ArgumentException("Invalid value for manufactorer!");
                this.manufactorer = value;
            }
        }
        public string Processor
        {
            get { return this.processor; }
            set
            {
                if (value != null && value.Length < 0) throw new ArgumentException("Invalid value for processor!");
                this.processor = value;
            }
        }
        public double Ram
        {
            get { return this.ram; }
            set
            {
                if (value < 0) throw new ArgumentException("Invalid value for ram!");
                this.ram = value;
            }
        }
        public string GraphicsCard
        {
            get { return this.graphicsCard; }
            set
            {
                if (value != null && value.Length < 0) throw new ArgumentException("Invalid value for graphics card!");
                this.graphicsCard = value;
            }
        }
        public string Hdd
        {
            get { return this.hdd; }
            set
            {
                if (value!=null && value.Length<0) throw new ArgumentException("Hard disk cannot hold negative GB!");
                this.hdd = value;
            }
        }
        public string Screen
        {
            get { return this.screen; }
            set
            {
                if (value!=null && value.Length < 0) throw new ArgumentException("Screen cannot be negative!");
                this.screen = value;
            }
        }
        public Battery Battery { get; set; }
        public decimal Price
        {
            get { return this.price; }
            set
            {
                if (value < 0) throw new ArgumentException("Price cannot be negative!");
                this.price = value;
            }
        }
        public Laptop(string model, decimal price, string manufactorer = null, string processor = null, double ram = 0, string graphicsCard = null, string hdd = null, string screen = null, Battery battery = null)
        {
            this.Model = model;
            this.Price = price;
            this.Manufactorer = manufactorer;
            this.Processor = processor;
            this.Ram = ram;
            this.GraphicsCard = graphicsCard;
            this.Hdd = hdd;
            this.Screen = screen;
            this.Battery = battery;
        }
        public override string ToString()
        {
            StringBuilder LaptopStr = new StringBuilder();
            LaptopStr.AppendLine("Model: "+this.Model);
            if(this.Manufactorer != null) LaptopStr.AppendLine("Manufacturer: "+this.Manufactorer);
            if(this.Processor != null) LaptopStr.AppendLine("Processor: "+this.Processor);
            if(this.Ram>0) LaptopStr.AppendFormat("RAM: {0} GB\n",this.Ram);
            if(this.GraphicsCard!= null) LaptopStr.AppendLine("Graphics card: "+ this.GraphicsCard);
            if(this.Hdd!=null) LaptopStr.AppendFormat("HDD: {0}\n",this.Hdd);
            if (this.Screen != null) LaptopStr.AppendLine("Screen: "+ this.Screen);
            if (this.Battery != null) LaptopStr.AppendLine(this.Battery.ToString());
            LaptopStr.AppendLine("price: " + this.Price);

            return LaptopStr.ToString();
            


        }

    }
}

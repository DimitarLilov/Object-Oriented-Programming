using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.LaptopShop
{
    class Laptop
    {
        private string model;
        private string manufacturer;
        private string processor;
        private int ram;
        private string graphicsCard;
        private string hdd;
        private string screen;
        private Battery batt;
        private double price;


        public Laptop(string model, double price)
        {
            this.Model = model;
            this.Price = price;
        }
        public Laptop(string model, double price, Battery battery, string manufact)
            : this(model, price)
        {
            this.batt = battery;
            this.Manufact = manufacturer;
        }
        public Laptop(string model, double price, Battery battery, string manufact = null, string processor = null, int ram = 0, string graphicsCard = null, string hdd = null, string screen = null) : this(model, price, battery, manufact)
        {
            this.Processor = processor;
            this.Ram = ram;
            this.GraphicsCard = graphicsCard;
            this.Hdd = hdd;
            this.Screen = screen;
        }
        public string Model
        {
            get { return this.model; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The model of the laptop is mandatory!");
                }
                this.model = value;
            }
        }
        public string Manufact
        {
            get { return this.manufacturer; }
            set { this.manufacturer = value; }
        }
        public string Processor
        {
            get { return this.processor; }
            set { this.processor = value; }
        }
        public int Ram
        {
            get { return this.ram; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Ram must be > 0");
                }
                this.ram = value;
            }
        }
        public string GraphicsCard
        {
            get { return this.graphicsCard; }
            set { this.graphicsCard = value; }
        }
        public string Hdd
        {
            get { return this.hdd; }
            set { this.hdd = value; }
        }
        public string Screen
        {
            get { return this.screen; }
            set { this.screen = value; }
        }
        public double Price
        {
            get { return this.price; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("The price must be set and > 0");
                }
                this.price = value;
            }
        }
        public void AddBattery(Battery battery)
        {
            this.batt = battery;
        }
        public override string ToString()
        {
            string output = "Model : " + this.model + "\n";
            if (!String.IsNullOrEmpty(this.manufacturer))
                output += "Manufacturer: " + this.manufacturer + "\n";
            if (!String.IsNullOrEmpty(this.processor))
                output += "Processor: " + this.processor + "\n";
            if (this.Ram != 0)
                output += "RAM: " + this.ram + " GB" + "\n";
            if (!String.IsNullOrEmpty(this.graphicsCard))
                output += "Graphics card: " + this.graphicsCard + "\n";
            if (!String.IsNullOrEmpty(this.hdd))
                output += "HDD: " + this.hdd + "\n";
            if (!String.IsNullOrEmpty(this.screen))
                output += "Screen: " + this.screen + "\n";
            output += batt + "\n";

            output += "Price: " + this.price + " lv.\n";
            return output;
        }
    }
}

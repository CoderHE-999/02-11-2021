using System;
using System.Collections.Generic;
using System.Text;

namespace SellProduct
{
    class Milk:Product
    {
        public Milk(string name , double price , int count , double totalIncome , double volume , double fatrate):base(name , price , count , totalIncome)
        {
            this.Volume = volume;
            this.Fatrate = fatrate;
        }

        public double Volume;
        public double Fatrate;

        public override string ShowInfo()
        {
            return base.ShowInfo() + $"\nVolume: {this.Volume}\nFatrrate: {this.Fatrate}";

        }
    }
}

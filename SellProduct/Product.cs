using System;
using System.Collections.Generic;
using System.Text;

namespace SellProduct
{
    class Product
    {
        public Product(string name , double price , int count , double totalincome)
        {
            this.Name = name;
            this.Price = price;
            
        }
        public Product(string name)
        {
            this.Name = name;
            
            
        }

        private string _name;
        private double _price;

        public int Count { get; private set; } = 10;
        

        public double TotalIncome { get; private set; }

        public string Name {
            get => _name;
            set
            {
                if (value.Length >= 3 && value.Length <= 23) this._name = value;
            }
        }

        public double Price {
            get => _price;
            set
            {
                if (value > 0) this._price = value;
            }
        }

        public bool Sell()
        {
            if (this.Count > 0)
            {
                this.Count -= Count;
                this.TotalIncome += Price;
                return true;
            }

            return false;
        }

        

        public virtual string ShowInfo()
        {
            return $"Name: {this.Name}\nCount: {this.Count}\nPrice: {this.Price}\nTotal income: {this.TotalIncome}";
        }
    }
}

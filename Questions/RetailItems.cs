using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions
{
    class RetailItems
    {
        //data fields
        private string itemName;
        private string desription;
        private double price;
        private int quantity;

        //constructors 
        public RetailItems() { }

        public RetailItems(string itemName, string desription, double price, int quantity)
        {
            this.itemName = itemName;
            this.desription = desription;
            this.price = price;
            this.quantity = quantity;
        }

        //Accessers Modifiers

        public string ItemName
        {
            get { return itemName; }
            set { itemName = value; }
        }

        public string Desription
        {
            get { return desription; }
            set { desription = value; }

        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
    }
  }

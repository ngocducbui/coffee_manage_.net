using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeManager.DTL
{
  public class Menu
    {

        private string foodName;
        private int count;
        private float price;
        private float totalPrice;

        public float TotalPrice
        {
            get { return totalPrice; }
            set { totalPrice = value; }
        }

        public float Price
        {
            get { return price; }
            set { price = value; }
        }

        public int Count
        {
            get { return count; }
            set { count = value; }
        }

        public string ProductName
        {
            get { return foodName; }
            set { foodName = value; }
        }

        public Menu(string foodName, int count, float price, float totalPrice = 0)
        {
            this.ProductName = foodName;
            this.Count = count;
            this.Price = price;
            this.TotalPrice = totalPrice;
        }

        public Menu(DataRow row)
        {
            this.ProductName = row["Name"].ToString();
            this.Count = (int)row["Count"];
            this.Price = (float)Convert.ToDouble(row["Price"].ToString());
            this.TotalPrice = (float)Convert.ToDouble(row["totalPrice"].ToString());
        }

        

        
    }
}

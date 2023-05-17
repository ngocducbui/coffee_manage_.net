using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeManager.DTL
{
    public class Product
    {
        private int id;
        private string name;
        private float price;
        private int categoryID;

        public int CategoryID { get => categoryID; set => categoryID = value; }
        public float Price { get => price; set => price = value; }
        public string Name { get => name; set => name = value; }
        public int Id { get => id; set => id = value; }

        public Product(int idCategory, float price, string name, int id)
        {
            this.CategoryID = idCategory;
            this.Price = price;
            this.Name = name;
            this.Id = id;
        }
        public Product(DataRow row)
        {
            this.Id = (int)row["Id"];
            this.Name = row["Name"].ToString();
            this.CategoryID = (int)row["IdCategory"];
            this.Price = (float)Convert.ToDouble(row["Price"].ToString());
        }
    }
}

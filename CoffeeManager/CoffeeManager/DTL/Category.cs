using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeManager.DTL
{
   public class Category
    {
        private int id;
        private string name;

        public string Name { get => name; set => name = value; }
        public int Id { get => id; set => id = value; }

        public Category(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public Category(DataRow row)
        {
            this.Id = (int)row["Id"];
            this.Name = row["Name"].ToString();
        }

    }
}

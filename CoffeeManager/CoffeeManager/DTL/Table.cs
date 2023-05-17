using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeManager.DTL
{
   public class Table
    {
        private int id;
        private string name;
        private string status;


        public string Status { get => status; set => status = value; }
        public string Name { get => name; set => name = value; }
        public int Id { get => id; set => id = value; }

        public Table(int id, string name, string status)
        {
            this.Id = id;
            this.Name = name;
            this.Status = status;
        }

        public Table(DataRow row)
        {
            this.id = (int)row["Id"];
            this.name = row["Name"].ToString();
            this.status = row["Status"].ToString();
        }
       
    }
}

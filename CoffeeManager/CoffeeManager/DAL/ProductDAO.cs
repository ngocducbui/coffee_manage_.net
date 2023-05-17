using CoffeeManager.DTL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeManager.DAL
{
    public class ProductDAO
    {
        private static ProductDAO instance;

        public static ProductDAO Instance
        {
            get { if (instance == null) instance = new ProductDAO(); return ProductDAO.instance; }
            private set { ProductDAO.instance = value; }
        }

        private ProductDAO() { }

        public List<Product> GetFoodByCategoryID(int idCategory)
        {
            List<Product> list = new List<Product>();

            string query = "select * from Product where idCategory = " + idCategory;

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Product products = new Product(item);
                list.Add(products);
            }

            return list;
        }
        public List<Product> getListProduct()
        {
            List<Product> list = new List<Product>();

            string query = "select * from Product";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Product products = new Product(item);
                list.Add(products);
            }
            return list; 
        }
        public bool inserProduct(string name, int id, float price)
        {
            string query = string.Format("INSERT Product(Name,IdCategory,Price)VALUES (N'{0}',{1},{2})",name,id,price);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool updateProduct(int idProduct, string name, int id, float price)
        {
            string query = string.Format("UPDATE Product SET name = N'{0}', idCategory = {1}, price = {2} WHERE id = {3}", name, id, price, idProduct);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool deleteProduct(int idProduct)
        {
            BillInforDAO.Instance.DeleteBillInfoByFoodID(idProduct);
            string query = string.Format("Delete Product where id = {0}", idProduct);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public List<Product> SearchProductByName(string name)
        {

            List<Product> list = new List<Product>();

            string query = string.Format("SELECT * FROM Product WHERE Name like(N'%{0}%')", name);

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Product p = new Product(item);
                list.Add(p);
            }

            return list;
        }
    }
}

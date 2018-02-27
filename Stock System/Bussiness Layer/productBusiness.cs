using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_System.Mahmoud_Hassa
{
    class productBusiness
    {
        public static List<object> fillProduct()
        {
            List<object> prodsList = new List<object>();
            var prod = from p in Program.context.Products
                       select new { Id = p.Id, Name = p.Name, Company = p.Company, p.Discription, p.Quantity, p.SalePrice };
            prodsList.AddRange(prod);
            return prodsList;
        }

        public static List<Product> SearchByName(string name)
        {
            var query =
                (from p in Program.context.Products
                where p.Name.Contains(name)
                select p).ToList<Product>();
            return query;
        }

        public static Product serchById(int id)
        {
            return Program.context.Products.Where(p1 => p1.Id == id).First();
        }
        
        public static void updateProduct(int prodId, string prodName, string companyName, string description, float salesPrice, int quantity)
        {
            var prod = serchById(prodId);
            prod.Name = prodName;
            prod.Company = companyName;
            prod.Discription = description;
            prod.SalePrice = salesPrice;
            prod.Quantity = quantity;

            Program.context.SaveChanges();
        }

        public static void AddProduct(string prodName, string companyname, string Description, float salesPrice, int quantity)
        {
            Product p = new Product { Name = prodName, Company = companyname, Discription = Description, SalePrice = salesPrice, Quantity = quantity };
            Program.context.Products.Add(p);
            Program.context.SaveChanges();
        }

        public static object getProductReport(DateTime beginDate)
        {
            var db = Program.context.prudctReport(beginDate);
            return db;
        }
    }
}

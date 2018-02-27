using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_System.Bussiness_Layer
{
    class CustomerQ
    {
        public static List<Customer> DisplayAll()
        {
            return (from c in Program.context.Customers
                    select c).ToList();
        }
        public static List<Customer> filter(Func<Customer, bool> del)
        {
            return Program.context.Customers.Where(del).Select(c => c).ToList();
        }
        public static void Add(string name, string phone, string address, decimal rate)
        {
            var supplier = new Customer
            {
                Name = name,
                Phone = phone,
                Address = address,
                Rate = rate.ToString()
            };
            Program.context.Customers.Add(supplier);
            Program.context.SaveChanges();
        }
        public static void Update(int id, string name, string phone, string address, decimal rate)
        {
            Customer cust = Program.context.Customers.Find(id);
            if (cust == null)
            {
                return;
            }
            cust.Name = name;
            cust.Phone = phone;
            cust.Address = address;
            cust.Rate = rate.ToString();
            Program.context.SaveChanges();
        }
        //check if I pre-deal with this customer.
        public static bool CheckPreDeal(int custID)
        {
            var order = (from o in Program.context.Sales_Order
                         where o.Customer_Id == custID
                         select o).FirstOrDefault();
            if (order == null)
                return false;
            else
                return true;
        }
        public static void Delete(int custID)
        {
            if (!CheckPreDeal(custID))
            {
                Customer sup = Program.context.Customers.Find(custID);
                Program.context.Customers.Remove(sup);
                Program.context.SaveChanges();
            }
        }
    }
}

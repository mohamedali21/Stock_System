using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_System.Bussiness_Layer
{
    class SupplierQ
    {
        public static List<Supplier> DisplayAll()
        {
            return (from e in Program.context.Suppliers
                    select e).ToList();
        }
        public static List<Supplier> filter(Func<Supplier, bool> del)
        {
            return Program.context.Suppliers.Where(del).Select(c => c).ToList();
        }
        public static void Add(string name, string phone, string address,decimal rate)
        {
            var supplier = new Supplier
            {
                Name =name,
                phone =phone,
                Address =address,
                Rate =rate.ToString()
            };
            Program.context.Suppliers.Add(supplier);
            Program.context.SaveChanges();
        }
        public static void Update(int id, string name, string phone, string address, decimal rate)
        {
            Supplier sup = Program.context.Suppliers.Find(id);
            if (sup == null)
            {
                return;
            }
            sup.Name = name;
            sup.phone = phone;
            sup.Address = address;
            sup.Rate = rate.ToString();
            Program.context.SaveChanges();
        }
        //check if I pre-deal with this supplier.
        public static bool CheckPreDeal(int supID)
        {
            var order = (from o in Program.context.Purchase_Order
                        where o.Supplier_Id == supID
                        select o).FirstOrDefault();
            if (order == null)
                return false;
            else
                return true;
        }
        public static void Delete(int supID)
        {
            if(!CheckPreDeal(supID))
            {
                Supplier sup = Program.context.Suppliers.Find(supID);
                Program.context.Suppliers.Remove(sup);
                Program.context.SaveChanges();
            }
        }
    }
}

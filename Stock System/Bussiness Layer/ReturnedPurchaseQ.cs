using Stock_System.Bussiness_Layer.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_System.Bussiness_Layer
{
    class ReturnedPurchaseQ
    {

      
        public static List<InvoiceItemsVM> DisplayInvoice(int id)
        {
            List<InvoiceItemsVM> invoiceItemsList = new List<InvoiceItemsVM>();
            var purchaseInvoiceItems = (from s in Program.context.Purchase_Order_Detalis
                                     where s.Pruchase_Order_Id == id
                                     select s).ToList();
            foreach (var item in purchaseInvoiceItems)
            {
                InvoiceItemsVM invoiceItemsVM = new InvoiceItemsVM
                {
                    Product_Id = item.Product_Id,
                    ProductName = (from
                                   p in Program.context.Products
                                   where p.Id == item.Product_Id
                                   select p.Name).FirstOrDefault(),
                    Quantity = item.Quantity,
                    Price = (from p in Program.context.Products
                             where p.Id == item.Product_Id
                             select p.SalePrice).FirstOrDefault()
                };
                invoiceItemsList.Add(invoiceItemsVM);
            }
            return invoiceItemsList;
        }
        public static void AddReurnedInvoice(int purchaseInvoiceId)
        {
            var returnedOrder = (from r in Program.context.Purchase_Returned_Cheque
                                 where r.Purchase_Id == purchaseInvoiceId
                                 select r).FirstOrDefault();
            if (returnedOrder == null)
            {
                Purchase_Returned_Cheque returned = new Purchase_Returned_Cheque()
                {
                    NumOfPriducts = 0,
                    Date = DateTime.Now.Date,
                    Purchase_Id = purchaseInvoiceId
                };
                Program.context.Purchase_Returned_Cheque.Add(returned);
                Program.context.SaveChanges();
            }
        }
        private static Product GetProduct(int prodID)
        {
            return (from p in Program.context.Products
                    where p.Id == prodID
                    select p).FirstOrDefault();
        }
        public static Purchase_Returned_Cheque ReturnedOrder(int invoiceID)
        {
            return (from r in Program.context.Purchase_Returned_Cheque
                    where r.Purchase_Id == invoiceID
                    select r).FirstOrDefault();
        }
        public static void AddReturnedItem(int prodID, int invoiceID, int quantity, double totalPrice, string description)
        {
            int returnedOderId = ReturnedOrder(invoiceID).Id;
            Purchase_Returned_Cheque_Details returnedItem = new Purchase_Returned_Cheque_Details()
            {
                Product_Id = prodID,
                Purchase_Returned_Cheque_Id = returnedOderId,
                Quantity = quantity,
                TotalPrice = totalPrice,
                Description = description
            };
            Program.context.Purchase_Returned_Cheque_Details.Add(returnedItem);
            Product prod = GetProduct(prodID);
            ReturnedOrder(invoiceID).NumOfPriducts += 1;
            prod.Quantity -= quantity;
            Program.context.SaveChanges();
        }
        public static List<ViewModel.ReturnedOrders> DisplayAllReturnedOrders()
        {
            List<ViewModel.ReturnedOrders> returnedOdersList = new List<ViewModel.ReturnedOrders>();
            var returnedOders = (from r in Program.context.Purchase_Returned_Cheque
                                 select r).ToList();
            foreach (var item in returnedOders)
            {
                double amount = CalculateTotalAmount(item.Purchase_Id);
                ViewModel.ReturnedOrders returnedPurchase = new ViewModel.ReturnedOrders()
                {
                    Id = item.Id,
                    InvoiceID = item.Purchase_Id,
                    ReleaseDate = item.Date,
                    InvoiceDate = (from i in Program.context.Purchase_Order
                                   where i.Id == item.Purchase_Id
                                   select i.RecivedDate).FirstOrDefault(),
                    NumOfProducts = item.NumOfPriducts,
                    TotalAmount = amount
                };
                returnedOdersList.Add(returnedPurchase);
            }
            return returnedOdersList;
        }
       
        public static List<ReturnedInvoiceDetails> DisplayAllRetrunedItems(int invoiceID)
        {
            int returnedOderId = ReturnedOrder(invoiceID).Id;
            List<ReturnedInvoiceDetails> returnedItemsList = new List<ReturnedInvoiceDetails>();
            var returnedItems = (from s in Program.context.Purchase_Returned_Cheque_Details
                                 where s.Purchase_Returned_Cheque_Id == returnedOderId
                                 select s).ToList();
            foreach (var item in returnedItems)
            {
                ReturnedInvoiceDetails itemsVM = new ReturnedInvoiceDetails
                {
                    Product_Id = item.Product_Id,
                    ProductName = (from p in Program.context.Products
                                   where p.Id == item.Product_Id
                                   select p.Name).FirstOrDefault(),
                    Quantity = item.Quantity,
                    TotalPrice = item.Quantity * (from p in Program.context.Products
                                                  where p.Id == item.Product_Id
                                                  select p.SalePrice).FirstOrDefault(),
                    Description = item.Description,
                };
                returnedItemsList.Add(itemsVM);
            }
            return returnedItemsList;
        }
        //Calculate TotalAmount of returned order
        public static double CalculateTotalAmount(int invoiceID)
        {
            double totalAmount = 0;
            int returnedOderId = ReturnedOrder(invoiceID).Id;
            var returnedItems = (from s in Program.context.Purchase_Returned_Cheque_Details
                                 where s.Purchase_Returned_Cheque_Id == returnedOderId
                                 select s).ToList();
            foreach (var item in returnedItems)
            {
                totalAmount += item.TotalPrice;
            }
            return totalAmount;
        }
        public static bool ReturnedItemCheck(int prodID, int invoiceID)
        {
            int returnedOderId = ReturnedOrder(invoiceID).Id;
            var returnedItem = (from s in Program.context.Purchase_Returned_Cheque_Details
                                where s.Purchase_Returned_Cheque_Id == returnedOderId && s.Product_Id == prodID
                                select s).FirstOrDefault();
            if (returnedItem == null)
                return false;
            else
                return true;
        }
        public static void DeleteReturnedItem(int prodID, int invoiceID, int quantity)
        {
            int returnedOderId = ReturnedOrder(invoiceID).Id;
            var returnedItem = (from s in Program.context.Purchase_Returned_Cheque_Details
                                where s.Purchase_Returned_Cheque_Id == returnedOderId && s.Product_Id == prodID
                                select s).FirstOrDefault();
            if (returnedItem == null)
                return;
            Program.context.Purchase_Returned_Cheque_Details.Remove(returnedItem);
            Product prod = GetProduct(prodID);
            prod.Quantity += quantity;
            ReturnedOrder(invoiceID).NumOfPriducts -= 1;
            Program.context.SaveChanges();
        }
        public static void UpdateItem(int prodID, int invoiceID, int quantity, string description)
        {
            int returnedOderId = ReturnedOrder(invoiceID).Id;
            int oldQuantity, newQuantity = quantity;
            var returnedItem = (from s in Program.context.Purchase_Returned_Cheque_Details
                                where s.Purchase_Returned_Cheque_Id == returnedOderId && s.Product_Id == prodID
                                select s).FirstOrDefault();
            if (returnedItem == null)
                return;
            oldQuantity = returnedItem.Quantity;
            returnedItem.Quantity = quantity;    
            returnedItem.Description = description;
            Product prod = GetProduct(prodID);
            returnedItem.TotalPrice = quantity*prod.SalePrice;
            prod.Quantity -= (newQuantity - oldQuantity);
            Program.context.SaveChanges();
        }
        public static Purchase_Order POrder(int invoiceID)
        {
            return (from p in Program.context.Purchase_Order
                                 where p.Id == invoiceID
                                 select p).FirstOrDefault();
        }
        public static bool IsEmpty(int invoiceID)
        {
            int returnedOderId = ReturnedOrder(invoiceID).Id;
            var returnedItem = (from s in Program.context.Purchase_Returned_Cheque_Details
                                where s.Purchase_Returned_Cheque_Id == returnedOderId
                                select s).FirstOrDefault();
            if (returnedItem == null)
                return true;
            else
                return false;
        }

        public static void Delete(int invoiceID)
        {
            int returnedOderId = ReturnedOrder(invoiceID).Id;
            Program.context.Delete_Retuned_Purchase_Invoice(returnedOderId);
        }
        public static void UpdateReturnedChequeDate(int invoiceID, DateTime returnDate)
        {
            int returnedOderId = ReturnedOrder(invoiceID).Id;
            var returnedItem = (from s in Program.context.Purchase_Returned_Cheque
                                where s.Id == returnedOderId
                                select s).FirstOrDefault();
            if (returnedItem == null)
                return;
            returnedItem.Date = returnDate;
            Program.context.SaveChanges();
        }

    }
}

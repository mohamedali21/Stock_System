using Stock_System.Bussiness_Layer.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Stock_System.Bussiness_Layer
{
    class ReturnedSalesQ
    {
        

        public static List<InvoiceItemsVM> DisplayInvoice(int id)
        {
            List<InvoiceItemsVM> invoiceItemsList = new List<InvoiceItemsVM>();
            var salesInvoiceItems = (from s in Program.context.Sales_Order_Details
                                    where s.Sales_Order_Id==id 
                                    select s).ToList();
            foreach (var item in salesInvoiceItems)
            {
                InvoiceItemsVM invoiceItemsVM = new InvoiceItemsVM
                {
                    Product_Id = item.Product_Id,
                    ProductName = (from
                                   p in Program.context.Products
                                   where p.Id == item.Product_Id
                                   select p.Name).FirstOrDefault(),
                    Quantity =item.Quantity,
                    Price=(from p in Program.context.Products
                           where p.Id == item.Product_Id
                           select p.SalePrice).FirstOrDefault()
                };
                invoiceItemsList.Add(invoiceItemsVM);
            }
            return invoiceItemsList;
        }
        public static void AddReurnedInvoice(int salesInvoiceId)
        {
            var returnedOrder = (from r in Program.context.Sales_Returned_Cheque
                                   where r.Sales_Order_Id == salesInvoiceId
                                   select r).FirstOrDefault();
            if(returnedOrder ==null)
            {
                Sales_Returned_Cheque returned = new Sales_Returned_Cheque()
                {
                    NumOfProducts = 0,
                    Date = DateTime.Now.Date,
                    Sales_Order_Id = salesInvoiceId
                };
                Program.context.Sales_Returned_Cheque.Add(returned);
                Program.context.SaveChanges();
            }
        }
        private static Product  GetProduct(int prodID)
        {
            return (from p in Program.context.Products
                           where p.Id == prodID
                           select p).FirstOrDefault();
        }
        public static Sales_Returned_Cheque ReturnedOrder(int invoiceID)
        {
            return (from r in Program.context.Sales_Returned_Cheque
                    where r.Sales_Order_Id == invoiceID
                    select r).FirstOrDefault();
        }
        public static void AddReturnedItem(int prodID, int invoiceID, int quantity, double totalPrice, string description)
        {
            int returnedOderId = ReturnedOrder(invoiceID).Id;
            Sales_Returned_Cheque_Details returnedItem = new Sales_Returned_Cheque_Details()
            {
                Product_Id=prodID,
                Sales_Returned_Cheque_Id=returnedOderId,
                Quantity=quantity,
                TotalPrice=totalPrice,
                Description= description
            };
            Program.context.Sales_Returned_Cheque_Details.Add(returnedItem);
            Product prod = GetProduct(prodID);
            ReturnedOrder(invoiceID).NumOfProducts += 1;
            prod.Quantity += quantity;

            Program.context.SaveChanges();
        }
        public static List<ReturnedInvoiceDetails> DisplayAllRetrunedItems(int invoiceID)
        {
            int returnedOderId = ReturnedOrder(invoiceID).Id;
            List<ReturnedInvoiceDetails> returnedItemsList = new List<ReturnedInvoiceDetails>();
            var returnedItems = (from s in Program.context.Sales_Returned_Cheque_Details
                                 where s.Sales_Returned_Cheque_Id == returnedOderId
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
                    TotalPrice=item.Quantity*(from p in Program.context.Products
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
            var returnedItems = (from s in Program.context.Sales_Returned_Cheque_Details
                                 where s.Sales_Returned_Cheque_Id == returnedOderId
                                 select s).ToList();
            foreach (var item in returnedItems)
            {
                totalAmount += item.TotalPrice;
            }
            return totalAmount;
        }
        public static Sales_Returned_Cheque lastReturnedOrder()
        {
             return   (Program.context.Sales_Returned_Cheque
                                .OrderByDescending(o => o.Id)
                                .Select(o => o)
                                .FirstOrDefault());
        }
        public static bool ReturnedItemCheck(int prodID, int invoiceID)
        {
            int returnedOderId = ReturnedOrder(invoiceID).Id;
            var returnedItem = (from s in Program.context.Sales_Returned_Cheque_Details
                                 where s.Sales_Returned_Cheque_Id == returnedOderId && s.Product_Id==prodID
                                 select s).FirstOrDefault();
            if (returnedItem == null)
                return false;
            else
                return true;
        }
        public static void DeleteReturnedItem(int prodID, int invoiceID, int quantity)
        {
            int returnedOderId = ReturnedOrder(invoiceID).Id;
            var returnedItem = (from s in Program.context.Sales_Returned_Cheque_Details
                                where s.Sales_Returned_Cheque_Id == returnedOderId && s.Product_Id == prodID
                                select s).FirstOrDefault();
            if (returnedItem == null)
                return;
            Program.context.Sales_Returned_Cheque_Details.Remove(returnedItem);
            Product prod = GetProduct(prodID);
            prod.Quantity -= quantity;
            ReturnedOrder(invoiceID).NumOfProducts -= 1;
            Program.context.SaveChanges();
        }
        public static void UpdateItem(int prodID, int invoiceID, int quantity, string description)
        {
            int returnedOderId = ReturnedOrder(invoiceID).Id;
            int oldQuantity, newQuantity = quantity;
            var returnedItem = (from s in Program.context.Sales_Returned_Cheque_Details
                                where s.Sales_Returned_Cheque_Id == returnedOderId && s.Product_Id == prodID
                                select s).FirstOrDefault();
            if (returnedItem == null)
                return;
            oldQuantity = returnedItem.Quantity;
            returnedItem.Quantity = quantity;
            returnedItem.Description = description;
            Product prod = GetProduct(prodID);
            returnedItem.TotalPrice = quantity*prod.SalePrice;
            prod.Quantity += (newQuantity-oldQuantity);
            Program.context.SaveChanges();
        }
        public static List<ViewModel.ReturnedOrders> DisplayAllReturnedOrders()
        {
            List<ViewModel.ReturnedOrders> returnedOdersList = new List<ViewModel.ReturnedOrders>();
            var returnedOders = (from r in Program.context.Sales_Returned_Cheque
                                select r).ToList();
            foreach (var item in returnedOders)
            {
                double amount = CalculateTotalAmount(item.Sales_Order_Id);
                ViewModel.ReturnedOrders returnedSales = new ViewModel.ReturnedOrders()
                {
                    Id = item.Id,
                    InvoiceID=item.Sales_Order_Id,
                    ReleaseDate = item.Date,
                    InvoiceDate = (from i in Program.context.Sales_Order
                                   where i.Id == item.Sales_Order_Id
                                   select i.Date).FirstOrDefault(),
                    NumOfProducts = item.NumOfProducts,
                    TotalAmount = amount
                };
                returnedOdersList.Add(returnedSales);
            }
            return returnedOdersList;
        }
        public static Sales_Order SOrder(int invoiceID)
        {
            return (from p in Program.context.Sales_Order
                    where p.Id == invoiceID
                    select p).FirstOrDefault();
        }
        public static bool IsEmpty(int invoiceID)
        {
            int returnedOderId = ReturnedOrder(invoiceID).Id;
            var returnedItem = (from s in Program.context.Sales_Returned_Cheque_Details
                                where s.Sales_Returned_Cheque_Id == returnedOderId 
                                select s).FirstOrDefault();
            if (returnedItem == null)
                return true;
            else
                return false;
        }
        public static void UpdateReturnedChequeDate(int invoiceID,DateTime returnDate)
        {
            int returnedOderId = ReturnedOrder(invoiceID).Id;
            var returnedItem = (from s in Program.context.Sales_Returned_Cheque
                                where s.Id == returnedOderId
                                select s).FirstOrDefault();
            if (returnedItem == null)
                return;
            returnedItem.Date = returnDate;
            Program.context.SaveChanges();
        }
        public static void Delete(int invoiceID)
        {
            int returnedOderId = ReturnedOrder(invoiceID).Id;
            Program.context.Delete_Retuned_Sales_Invoice(returnedOderId);
        }

    }
}

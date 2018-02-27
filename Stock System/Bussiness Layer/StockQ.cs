using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_System.Bussiness_Layer
{
    class StockQ
    {
        public static List<object> DisplayStocks()
        {
            List<object> stocklist = new List<object>();
            var stocks = (from s in Program.context.Stocks
                          select new { s.Id, s.Location, s.phone }).ToList();
            stocklist.AddRange(stocks);
            return stocklist;
        }
        public static void Add(string location,string phoneNum)
        {
            Stock stock = new Stock()
            {
                Location = location,
                phone = phoneNum
            };
            Program.context.Stocks.Add(stock);
            Program.context.SaveChanges();
        }
        public static void Update(int id,string location, string phoneNum)
        {
            var stock = (from s in Program.context.Stocks
                         where s.Id == id
                         select s).FirstOrDefault();
            if (stock == null)
                return;
            stock.Location = location;
            stock.phone = phoneNum;
            Program.context.SaveChanges();
        }
    }
}

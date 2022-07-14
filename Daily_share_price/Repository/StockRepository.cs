using DailySharePrice.Database;
using DailySharePrice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DailySharePrice.Repository
{
    public class StockRepository : IStockRepository
    {
        public StockDetails GetStockByName(string stockName)
        { 
            var stocks = StockDb.stockList.FirstOrDefault(s => s.StockName.ToLower() == stockName.ToLower());
            if(stocks==null)
            {
                return null;
            }
            return stocks;
        }
    }
}

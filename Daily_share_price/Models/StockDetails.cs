using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DailySharePrice.Models
{
    public class StockDetails
    {
        public int StockId { get; set; }
        public string StockName { get; set; }
        public double StockPrice { get; set; }
    }
}

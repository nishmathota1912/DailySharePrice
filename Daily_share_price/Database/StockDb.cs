using DailySharePrice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DailySharePrice.Database
{
    public class StockDb
    {
        public static List<StockDetails> stockList= new List<StockDetails>()
        {
            new StockDetails()
            {
                StockId = 1,
                StockName = "HDFC",
                StockPrice=100
            },
            new StockDetails()
            {
                StockId = 2,
                StockName = "Asian Paints",
                StockPrice = 2000
            },
            new StockDetails()
            {
                StockId = 3,
                StockName = "AXIS",
                StockPrice = 800
            },
            new StockDetails()
            {
                StockId = 4,
                StockName = "Bajaj Automobiles",
                StockPrice = 3000
            },
            new StockDetails()
            {
                StockId = 5,
                StockName = "ICICI",
                StockPrice = 400
            },
            new StockDetails()
            {
                StockId = 6,
                StockName = "INFOSYS",
                StockPrice = 1400
            },
            new StockDetails()
            {
                StockId = 7,
                StockName = "Wipro",
                StockPrice = 450
            },

            new StockDetails()
            {
                StockId = 9,
                StockName = "Lupin",
                StockPrice = 400
            },
            new StockDetails()
            {
                StockId = 10,
                StockName = "ITC",
                StockPrice = 200
            },
            new StockDetails()
            {
                StockId = 11,
                StockName = "BajajFinance",
                StockPrice = 5000
            },
            new StockDetails()
            {
                StockId = 12,
                StockName = "JSWSteel",
                StockPrice = 700
            },
            new StockDetails()
            {
                StockId = 13,
                StockName = "HCL",
                StockPrice = 1000
            },
            new StockDetails()
            {
                StockId = 14,
                StockName = "NestleIndia",
                StockPrice = 20000
            },
            new StockDetails()
            {
                StockId = 15,
                StockName = "SBI",
                StockPrice = 450
            },
            new StockDetails()
            {
                StockId = 16,
                StockName = "Tata Motors",
                StockPrice = 350
            },
            new StockDetails()
            {
                StockId = 17,
                StockName = "HDFC Insurance",
                StockPrice = 650
            }
        };
    }
}

using DailySharePrice.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DailySharePrice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StockPriceController : ControllerBase
    {
        private readonly IStockRepository _stockRepository;
        public StockPriceController(IStockRepository stockrepository)
        {
            _stockRepository = stockrepository;
        }
        // GET: StockPriceController
        [HttpGet("{stockName}")]
        public IActionResult GetDailySharePrice(string stockName)
        {
            if (string.IsNullOrEmpty(stockName))
            {
                return BadRequest();
            }
            var stocks = _stockRepository.GetStockByName(stockName);
            if(stocks==null)
            {
                return NoContent();
            }
            return Ok(stocks);
        }
       
    }
}

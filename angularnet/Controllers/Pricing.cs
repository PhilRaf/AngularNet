using angularnet.Interface;
using Microsoft.AspNetCore.Mvc;

namespace angularnet.Controllers
{
    
    public class Pricing : ControllerBase 
    {

        private readonly IPricing _pricing;
          
        

        public Pricing(IPricing pricing) 
        {
            _pricing = pricing;
        }

        [HttpGet]
        [Route("api/getPrice")]
        public IEnumerable<int> GetPrice(int id)
        {
            var responce = _pricing.FetchPriceAsync(id);
            return Enumerable.Range(0, 100);
        }

        [HttpPost]
        [Route("api/setPrice")]
        public IEnumerable<int> SetPrice()
        {
            var responce = _pricing;

            var price = new Random().Next(1, 100);
            return Enumerable.Range(0, price);
        }


    }
}

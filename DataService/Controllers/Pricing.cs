using DataService.DBcontext;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DataService.Controllers
{
    public class Pricing : ControllerBase
    {
        private readonly MagazzinoDbContext _context;

        public Pricing(MagazzinoDbContext context)
        {
            _context = context;
        }

        public List<object>? PriceData { get; set; }

        public int notFound = 0;

        [HttpGet]
        [Route("api/FetchPrice")]
        public async Task<decimal>? FetchPrice(string id)
        {
            int idprod;
            try
            {
                
                idprod = int.Parse(id);
                if (id == null || _context.Prodotti == null)
                {
                    return 0;
                }

                var priceProdotto = await _context.Prodotti
                    .FirstOrDefaultAsync(m => m.ProdottoID == idprod);



                return priceProdotto.Prezzo;
            }
            catch (Exception ex) 
            {
              Console.WriteLine(ex.ToString());

              return 0;
            }
           
        }
        
    }
}

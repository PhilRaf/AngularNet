namespace DataService.Models
{
    public class Prodotto
    {
        public int ProdottoID { get; set; }
        public string Nome { get; set; }
        public decimal Prezzo { get; set; }
        public int Quantita { get; set; }

        // Relazione uno-a-molti con DettagliOrdini
        public List<DettaglioOrdine> DettagliOrdini { get; set; }
    }
}

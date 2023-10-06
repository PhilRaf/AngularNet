namespace DataService.Models
{
    public class DettaglioOrdine
    {
        public int DettaglioOrdineID { get; set; }
        public int OrdineID { get; set; }
        public int ProdottoID { get; set; }
        public int Quantita { get; set; }
        public decimal PrezzoUnitario { get; set; }
        public decimal Totale { get; set; }

        // Chiavi esterne per Ordine e Prodotto
        public Ordine Ordine { get; set; }
        public Prodotto Prodotto { get; set; }
    }
}

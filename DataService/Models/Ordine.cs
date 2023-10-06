namespace DataService.Models
{
    public class Ordine
    {
        public int OrdineID { get; set; }
        public DateTime DataOrdine { get; set; }

        // Chiave esterna per Fornitore
        public int FornitoreID { get; set; }
        public Fornitore Fornitore { get; set; }

        // Relazione uno-a-molti con DettagliOrdini
        public List<DettaglioOrdine> DettagliOrdini { get; set; }
    }
}

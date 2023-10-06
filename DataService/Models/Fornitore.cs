namespace DataService.Models
{
    public class Fornitore
    {
        public int FornitoreID { get; set; }
        public string Nome { get; set; }
        public string Indirizzo { get; set; }

        // Relazione uno-a-molti con Ordini
        public List<Ordine> Ordini { get; set; }
    }
}

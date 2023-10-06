namespace angularnet.DTO
{
    public class DTOprodotto
    {
        public int ProdottoID { get; set; }
        public string Nome { get; set; }
        public decimal Prezzo { get; set; }

        public int Quantita { get; set; }

        public DTOprodotto(int prodottoID, string nome, decimal prezzo)
        {
            ProdottoID = prodottoID;
            Nome = nome;
            Prezzo = prezzo;
        }
    }

}

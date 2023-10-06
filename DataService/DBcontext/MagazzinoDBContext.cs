using System.Collections.Generic;
using DataService.Models;
using Microsoft.EntityFrameworkCore;


namespace DataService.DBcontext
{

    public class MagazzinoDbContext : DbContext
    {
        public MagazzinoDbContext(DbContextOptions<MagazzinoDbContext> options) : base(options)
        {
        }

        public DbSet<Prodotto> Prodotti { get; set; }
        public DbSet<Fornitore> Fornitori { get; set; }
        public DbSet<Ordine> Ordini { get; set; }
        public DbSet<DettaglioOrdine> DettagliOrdini { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
      => optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Database=AngularNet;Trusted_Connection=True;");
    }

}

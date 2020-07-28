namespace ConsumindoCEP
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class InfoCEPs : DbContext
    {
        public InfoCEPs()
            : base("name=InfoCEPs")
        {
        }

        public virtual DbSet<InfoCEP> InfoCEP { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<InfoCEP>()
                .Property(e => e.Endereco)
                .IsUnicode(false);

            modelBuilder.Entity<InfoCEP>()
                .Property(e => e.Bairro)
                .IsUnicode(false);

            modelBuilder.Entity<InfoCEP>()
                .Property(e => e.Cidade)
                .IsUnicode(false);

            modelBuilder.Entity<InfoCEP>()
                .Property(e => e.UF)
                .IsUnicode(false);

            modelBuilder.Entity<InfoCEP>()
                .Property(e => e.Cep)
                .IsUnicode(false);
        }
    }
}

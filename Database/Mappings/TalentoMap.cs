using Database.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Database.Mappings
{
    public class TalentoMap : IEntityTypeConfiguration<Talento>
    {
        public void Configure(EntityTypeBuilder<Talento> modelBuilder)
        {
            modelBuilder.ToTable("Talento");

            modelBuilder.HasKey(c => c.Id);
            modelBuilder.HasOne(c => c.Banco);
            modelBuilder.HasMany(c => c.Conhecimentos);
            modelBuilder.Property(c => c.Nome).HasMaxLength(100).IsRequired();
            modelBuilder.Property(c => c.Email).HasMaxLength(100).IsRequired();
            modelBuilder.Property(c => c.Skype).HasMaxLength(20).IsRequired();
            modelBuilder.Property(c => c.Telefone).HasMaxLength(20).IsRequired();
            modelBuilder.Property(c => c.Linkedin).HasMaxLength(100);
            modelBuilder.Property(c => c.Cidade).HasMaxLength(100).IsRequired();
            modelBuilder.Property(c => c.Estado).HasMaxLength(2).IsRequired();
            modelBuilder.Property(c => c.Portfolio).HasMaxLength(100);
            modelBuilder.Property(c => c.HorasAteQuatro).IsRequired();
            modelBuilder.Property(c => c.HorasQuatroASeis).IsRequired();
            modelBuilder.Property(c => c.HorasSeisAOito).IsRequired();
            modelBuilder.Property(c => c.HorasAcimaDeOito).IsRequired();
            modelBuilder.Property(c => c.HorasFimDeSemana).IsRequired();
            modelBuilder.Property(c => c.PeriodoManha).IsRequired();
            modelBuilder.Property(c => c.PeriodoTarde).IsRequired();
            modelBuilder.Property(c => c.PeriodoNoite).IsRequired();
            modelBuilder.Property(c => c.PeriodoMadrugada).IsRequired();
            modelBuilder.Property(c => c.PeriodoComercial).IsRequired();
            modelBuilder.Property(c => c.Pretensao).IsRequired();
            modelBuilder.Property(c => c.InformacaoBancaria).IsRequired();
            modelBuilder.Property(c => c.LinkCrud).HasMaxLength(200);

            }
    }
}
using System;
using Database.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Database.Mappings
{
    public class TalentoBancoMap: IEntityTypeConfiguration<TalentoBanco>
    {
            public void Configure(EntityTypeBuilder<TalentoBanco> modelBuilder)
            {
                modelBuilder.ToTable("TalentoBanco");

                modelBuilder.HasKey(c => c.Id);
                // modelBuilder.HasOne(c => c.Talento);
                modelBuilder.Property(c => c.TalentoID);
                modelBuilder.Property(c => c.BancoBeneficiario).HasMaxLength(200);
                modelBuilder.Property(c => c.BancoCpf).HasMaxLength(14);
                modelBuilder.Property(c => c.BancoNome).HasMaxLength(100);
                modelBuilder.Property(c => c.BancoAgencia).HasMaxLength(12);
                modelBuilder.Property(c => c.BancoContaCorrente);
                modelBuilder.Property(c => c.BancoContaPoupanca);
                modelBuilder.Property(c => c.BancoConta).HasMaxLength(20);

            }

    }
}

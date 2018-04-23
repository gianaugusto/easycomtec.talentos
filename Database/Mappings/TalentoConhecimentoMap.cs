using System;
using Database.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Database.Mappings
{
    public class TalentoConhecimentoMap: IEntityTypeConfiguration<TalentoConhecimento>
    {
        public void Configure(EntityTypeBuilder<TalentoConhecimento> modelBuilder)
        {
            modelBuilder.ToTable("TalentoConhecimento");

            modelBuilder.HasKey(c => c.Id);

            modelBuilder.Property(c => c.TalentoID);
            modelBuilder.Property(c => c.ConhecimentoID);

            modelBuilder.HasOne(c => c.Talento);
            modelBuilder.HasOne(c => c.Conhecimento);

            modelBuilder.Property(c => c.Nivel);

        }

    }
}

using System;
using Database.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Database.Mappings
{
    public class ConhecimentoMap: IEntityTypeConfiguration<Conhecimento>
    {
        public void Configure(EntityTypeBuilder<Conhecimento> modelBuilder)
            {
                modelBuilder.ToTable("Conhecimento");

            modelBuilder.HasKey(c => c.Id);

                modelBuilder.Property(c => c.Titulo).HasMaxLength(200);

                modelBuilder.Property(c => c.Status);
            }

    }
}

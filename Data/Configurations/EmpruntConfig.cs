using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Domain.Entities;

namespace Data.Configurations
{
    public class EmpruntConfig : IEntityTypeConfiguration<Emprunt>
    {
        public void Configure(EntityTypeBuilder<Emprunt> builder)
        {
            builder.HasKey(cle => new {cle.DateEmprunt, cle.ClientFk, cle.DocumentFk});
        }
    }
}
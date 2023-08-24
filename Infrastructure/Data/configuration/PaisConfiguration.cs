
using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tienda-NetCore.Core.Entities;

namespace Persistencia.Data.Configuration
{
    public class PaisConfiguration : IEntityTypeConfiguration<Pais>
    {
        public void Configure(EntityTypeBuilder<Pais> builder)
        {
            // Aquí puedes configurar las propiedades de la entidad Marca
            // utilizando el objeto 'builder'.
            builder.ToTable("Pais");

            builder.Property(PaisConfiguration=>p.CodPais)

            builder.HasKey(e => );
            builder.Property(e => );
        }
    }
}
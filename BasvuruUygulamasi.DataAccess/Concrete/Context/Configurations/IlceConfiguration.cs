using BasvuruUygulamasi.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasvuruUygulamasi.DataAccess.Concrete.Context.Configurations
{
    public class IlceConfiguration : IEntityTypeConfiguration<Ilce>
    {
        public void Configure(EntityTypeBuilder<Ilce> builder)
        {
            builder.Property(e => e.Adi)
                .HasMaxLength(100)
                .IsUnicode(false);

            
                

        }
    }
}

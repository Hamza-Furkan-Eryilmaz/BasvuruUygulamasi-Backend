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
    internal class PersonelIsBasvurusuConfiguration : IEntityTypeConfiguration<PersonelIsBasvurusu>
    {
        public void Configure(EntityTypeBuilder<PersonelIsBasvurusu> builder)
        {
            builder.Property(e => e.Aciklama)
                .HasMaxLength(100)
                .IsUnicode(false);

            builder.Property(e => e.IsYeriAdi)
                .HasMaxLength(100)
                .IsUnicode(false);

            builder.Property(e => e.Pozisyon)
                .HasMaxLength(100)
                .IsUnicode(false);

           
               


        }
    }
}

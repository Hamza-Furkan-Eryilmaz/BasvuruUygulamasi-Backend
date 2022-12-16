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
    public class PersonelConfiguration : IEntityTypeConfiguration<Personel>
    {
        public void Configure(EntityTypeBuilder<Personel> builder)
        {
            builder.HasKey(x => x.Id);  

            builder.Property(e => e.Aciklama)
        .HasMaxLength(100)
        .IsUnicode(false);

            builder.Property(e => e.AdiSoyadi)
        .HasMaxLength(50)
        .IsUnicode(false);

            builder.Property(e => e.Cinsiyet)
        .HasMaxLength(50)
        .IsUnicode(false);

            
        

        }
    }
}

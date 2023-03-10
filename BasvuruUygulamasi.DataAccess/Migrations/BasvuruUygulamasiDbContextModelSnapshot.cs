// <auto-generated />
using System;
using BasvuruUygulamasi.DataAccess.Concrete.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BasvuruUygulamasi.DataAccess.Migrations
{
    [DbContext(typeof(BasvuruUygulamasiDbContext))]
    partial class BasvuruUygulamasiDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BasvuruUygulamasi.Entities.Concrete.Ilce", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("Adi")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<long>("SehirId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("SehirId");

                    b.ToTable("Ilceler");
                });

            modelBuilder.Entity("BasvuruUygulamasi.Entities.Concrete.Personel", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("Aciklama")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("AdiSoyadi")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Cinsiyet")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime>("DogumTarihi")
                        .HasColumnType("datetime2");

                    b.Property<long>("IlceId")
                        .HasColumnType("bigint");

                    b.Property<long>("SehirId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("IlceId");

                    b.HasIndex("SehirId");

                    b.ToTable("Personeller");
                });

            modelBuilder.Entity("BasvuruUygulamasi.Entities.Concrete.PersonelIsBasvurusu", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("Aciklama")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<DateTime>("BasvuruTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("IsYeriAdi")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<long>("PersonelId")
                        .HasColumnType("bigint");

                    b.Property<string>("Pozisyon")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<long>("SehirId")
                        .HasColumnType("bigint");

                    b.Property<bool>("SeyahatEngeliYok")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("PersonelId");

                    b.HasIndex("SehirId");

                    b.ToTable("PersonelIsBasvurulari");
                });

            modelBuilder.Entity("BasvuruUygulamasi.Entities.Concrete.Sehir", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("Adi")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Sehirler");
                });

            modelBuilder.Entity("BasvuruUygulamasi.Entities.Concrete.Ilce", b =>
                {
                    b.HasOne("BasvuruUygulamasi.Entities.Concrete.Sehir", "Sehir")
                        .WithMany("Ilceler")
                        .HasForeignKey("SehirId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Sehir");
                });

            modelBuilder.Entity("BasvuruUygulamasi.Entities.Concrete.Personel", b =>
                {
                    b.HasOne("BasvuruUygulamasi.Entities.Concrete.Ilce", "Ilce")
                        .WithMany("Personeller")
                        .HasForeignKey("IlceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BasvuruUygulamasi.Entities.Concrete.Sehir", "Sehir")
                        .WithMany("Personeller")
                        .HasForeignKey("SehirId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ilce");

                    b.Navigation("Sehir");
                });

            modelBuilder.Entity("BasvuruUygulamasi.Entities.Concrete.PersonelIsBasvurusu", b =>
                {
                    b.HasOne("BasvuruUygulamasi.Entities.Concrete.Personel", "Personel")
                        .WithMany("PersonelIsBasvurulari")
                        .HasForeignKey("PersonelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BasvuruUygulamasi.Entities.Concrete.Sehir", "Sehir")
                        .WithMany("PersonelIsBasvurulari")
                        .HasForeignKey("SehirId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Personel");

                    b.Navigation("Sehir");
                });

            modelBuilder.Entity("BasvuruUygulamasi.Entities.Concrete.Ilce", b =>
                {
                    b.Navigation("Personeller");
                });

            modelBuilder.Entity("BasvuruUygulamasi.Entities.Concrete.Personel", b =>
                {
                    b.Navigation("PersonelIsBasvurulari");
                });

            modelBuilder.Entity("BasvuruUygulamasi.Entities.Concrete.Sehir", b =>
                {
                    b.Navigation("Ilceler");

                    b.Navigation("PersonelIsBasvurulari");

                    b.Navigation("Personeller");
                });
#pragma warning restore 612, 618
        }
    }
}

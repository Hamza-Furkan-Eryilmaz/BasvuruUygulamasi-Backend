using System;
using System.Collections.Generic;
using System.Reflection;
using BasvuruUygulamasi.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace BasvuruUygulamasi.DataAccess.Concrete.Context;

public class BasvuruUygulamasiDbContext : DbContext
{

    public BasvuruUygulamasiDbContext(DbContextOptions options): base(options) {}

    public  DbSet<Ilce> Ilceler { get; set; }

    public  DbSet<PersonelIsBasvurusu> PersonelIsBasvurulari { get; set; }

    public  DbSet<Personel> Personeller { get; set; }

    public  DbSet<Sehir> Sehirler { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }


}




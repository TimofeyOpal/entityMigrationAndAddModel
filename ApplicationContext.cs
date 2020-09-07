using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace _11111111111entity
{

        public class ApplicationContext : DbContext
        {
            public DbSet<Product> Products { get; set; }

            public ApplicationContext()
            {
               // Database.EnsureCreated();
            }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=helloappdb;Trusted_Connection=True;");
            }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Country>();
            //Применение Fluent API заключается в вызове метода Ignore(): что бы не использовать модель или можно использовать аннотацию [NotMapped] перед моделью в USER
            //после каждого изменения используем миграции и обновление базы данных

        }
    }

    }


using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using NLayer.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Diagnostics;
using System.Xml.Linq;

namespace NLayer.Repository.Seeds
{
    internal class ProductSeed : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(new Product { Id = 1, CategoryId=1,Price=100,Stock=20,CreatedDate=DateTime.Now,Name = "Rotring Visumax Versatil Uçlu Kalem" },
                new Product { Id = 2, CategoryId = 1, Price = 100, Stock = 20, CreatedDate = DateTime.Now, Name = "Faber-Castell Econ Versatil 0.7" },
                new Product { Id = 3, CategoryId = 2,Price = 100,Stock = 20,CreatedDate = DateTime.Now,Name = "Sınıf Arkadaşım Atatürk" },
                new Product { Id = 4, CategoryId = 2,Price = 100,Stock = 20,CreatedDate = DateTime.Now,Name = "Dar Koridor" }
                );
        }
    }
}
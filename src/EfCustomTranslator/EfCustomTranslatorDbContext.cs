// Copyright (c) Dennis Shevtsov. All rights reserved.
// Licensed under the MIT License.
// See LICENSE in the project root for license information.

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EfCustomTranslator;

public sealed class EfCustomTranslatorDbContext : DbContext
{
  protected override void OnModelCreating(ModelBuilder modelBuilder)
  {
    EntityTypeBuilder<ProductEntity> entityTypeBuilder = modelBuilder.Entity<ProductEntity>();
    entityTypeBuilder.ToTable("product");
    entityTypeBuilder.HasKey(entity => entity.ProductId);

    entityTypeBuilder.Property(entity => entity.ProductId).IsRequired().HasColumnName("product_id");
    entityTypeBuilder.Property(entity => entity.Name     ).IsRequired().HasColumnName("name"      );
    entityTypeBuilder.Property(entity => entity.Price    ).IsRequired().HasColumnName("price"     );
  }
}

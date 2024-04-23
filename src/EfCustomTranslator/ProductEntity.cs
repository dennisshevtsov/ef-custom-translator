// Copyright (c) Dennis Shevtsov. All rights reserved.
// Licensed under the MIT License.
// See LICENSE in the project root for license information.

namespace EfCustomTranslator;

public sealed class ProductEntity
{
  public required Guid ProductId { get; set; }

  public required string Name { get; set; }

  public required Money Price { get; set; }
}

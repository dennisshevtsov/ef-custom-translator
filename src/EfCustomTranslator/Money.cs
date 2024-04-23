// Copyright (c) Dennis Shevtsov. All rights reserved.
// Licensed under the MIT License.
// See LICENSE in the project root for license information.

namespace EfCustomTranslator;

public readonly record struct Money(string Currency, ulong Units, ulong Ratio)
{
  public override string ToString() => $"{Currency}{Units / Ratio}.{Units % Ratio}";
}

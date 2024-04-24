// Copyright (c) Dennis Shevtsov. All rights reserved.
// Licensed under the MIT License.
// See LICENSE in the project root for license information.

namespace EfCustomTranslator;

public readonly record struct Money(string Currency, ulong MinorUnits)
{
  private const int MinorUnitRatio = 100;
  private const int StringLength = 3 + 18 + 1 + 2; // 3 (currency code) + 18 (digits before point) + 1 (point) + 2 (digits after point)

  public override string ToString() => $"{Currency}{MinorUnits / Money.MinorUnitRatio:D18}.{MinorUnits % Money.MinorUnitRatio:D2}"; // 18 + 2 = 20 (how many digits in ulong)

  public static Money Parce(string value)
  {
    ArgumentNullException.ThrowIfNull(value);

    if (value.Length != Money.StringLength)
    {
      throw new InvalidCastException($"Invalid length of string '{value}' to convert to Money");
    }

    string currency = value.Substring(0, 3);

    ulong majorUnits = ulong.Parse(value.Substring(3, 18)); // 20 (all ulong digits) - 2 (digits after point) = 18
    ulong minorUnits = ulong.Parse(value.Substring(22, 2)); // 3 (code length) + 18 (digits before point) + 1 (point) = 22
    ulong totalMinorUnits = majorUnits * Money.MinorUnitRatio + minorUnits;

    return new Money(Currency: currency, MinorUnits: totalMinorUnits);
  }
}

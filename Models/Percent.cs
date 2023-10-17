using System.Globalization;

namespace Artline.Models;

public readonly struct Percent
{
    public Percent(decimal value)
    {
        Value = value;
    }

    public decimal Value { get; }
    public string ValueString
    {
        get { return Value.ToString("P", new NumberFormatInfo() { PercentDecimalDigits = 0 }); }
    }

    public static implicit operator Percent(decimal d) => new(d);
    public static implicit operator decimal(Percent p) => p.Value;
}
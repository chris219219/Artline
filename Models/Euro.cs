using System.Globalization;

namespace Artline.Models;

public readonly struct Euro
{
    public Euro(decimal value)
    {
        Value = value;
    }

    public decimal Value { get; }

    public string ValueString
    {
        get { return Value.ToString("C", new CultureInfo("de-DE").NumberFormat); }
    }

    public static implicit operator Euro(decimal d) => new(d);
    public static implicit operator decimal(Euro e) => e.Value;
}
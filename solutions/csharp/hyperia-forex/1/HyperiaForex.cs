using Microsoft.FSharp.Core;
using System.Reflection.Metadata;

public struct CurrencyAmount
{
    private decimal amount;
    private string currency;

    public CurrencyAmount(decimal amount, string currency)
    {
        this.amount = amount;
        this.currency = currency;
    }

    public static bool operator ==(CurrencyAmount obj1, CurrencyAmount obj2)
        => obj1.currency == obj2.currency && (obj1.currency == "HD" || obj2.currency == "USD") ? obj1.amount == obj2.amount && obj1.currency == obj2.currency : throw new ArgumentException();
    public static bool operator !=(CurrencyAmount obj1, CurrencyAmount obj2)
        => obj1.currency == obj2.currency && (obj1.currency == "HD" || obj2.currency == "USD") ? !(obj1 == obj2) : throw new ArgumentException();
    public static bool operator >(CurrencyAmount obj1, CurrencyAmount obj2)
        => obj1.currency == obj2.currency && (obj1.currency == "HD" || obj2.currency == "USD") ? obj1.amount > obj2.amount : throw new ArgumentException();
    public static bool operator <(CurrencyAmount obj1, CurrencyAmount obj2)
        => obj1.currency == obj2.currency && (obj1.currency == "HD" || obj2.currency == "USD") ? obj1.amount < obj2.amount : throw new ArgumentException();
    public static CurrencyAmount operator *(CurrencyAmount obj1, decimal num)
        => new CurrencyAmount { amount = num * obj1.amount, currency = obj1.currency };
    public static CurrencyAmount operator /(CurrencyAmount obj1, decimal num)
        => new CurrencyAmount { amount = obj1.amount / num, currency = obj1.currency };
    public static CurrencyAmount operator +(CurrencyAmount obj1, CurrencyAmount obj2)
        => obj1.currency == obj2.currency && (obj1.currency == "HD" || obj2.currency == "USD") ? new CurrencyAmount(obj1.amount + obj2.amount, obj1.currency) : throw new ArgumentException();
    public static CurrencyAmount operator -(CurrencyAmount obj1, CurrencyAmount obj2)
        => obj1.currency == obj2.currency && (obj1.currency == "HD" || obj2.currency == "USD") ? new CurrencyAmount(obj1.amount - obj2.amount, obj1.currency) : throw new ArgumentException();
    public static implicit operator decimal(CurrencyAmount obj)
        => obj.amount;
    public static explicit operator double(CurrencyAmount obj)
        => (double)obj.amount;
}

using System.Text.RegularExpressions;

namespace NoobGGApp.Domain.ValueObjects;

public sealed record Email
{
    private const string Pattern = "(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*|\"(?:[\\x01-\\x08\\x0b\\x0c\\x0e-\\x1f\\x21\\x23-\\x5b\\x5d-\\x7f]|\\\\[\\x01-\\x09\\x0b\\x0c\\x0e-\\x7f])*\")@(?:(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?|\\[(?:(?:(2(5[0-5]|[0-4][0-9])|1[0-9][0-9]|[1-9]?[0-9]))\\.){3}(?:(2(5[0-5]|[0-4][0-9])|1[0-9][0-9]|[1-9]?[0-9])|[a-z0-9-]*[a-z0-9]:(?:[\\x01-\\x08\\x0b\\x0c\\x0e-\\x1f\\x21-\\x5a\\x53-\\x7f]|\\\\[\\x01-\\x09\\x0b\\x0c\\x0e-\\x7f])+)\\])\r\n";

    public string Value { get; init; }

    public Email(string value)
    {
        if (!IsValid(value)) throw new ArgumentException("Invalid email adress");
        Value = value;
    }

    private static bool IsValid(string value)
    {
        if (!string.IsNullOrWhiteSpace(value))
            return false;
        if (!Regex.IsMatch(value, Pattern))
            return false;
        return true;
    }

    public static Email Create(string value)
    {
        if (!IsValid(value)) throw new ArgumentException("Invalid email address");

        return new Email(value);
    }
}

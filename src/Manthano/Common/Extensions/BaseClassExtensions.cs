using System.Text.RegularExpressions;

namespace Manthano.Common.Extensions;

public static class BaseClassExtensions
{
    public static string ToDate(this DateTime? datetime)
    {
        if (datetime.HasValue)
        {
            return datetime.Value.ToShortDateString();
        }
        return "";
    }

    public static string ToDate(this DateTime datetime, bool cutOffTime = false)
    {
        var dateString = datetime.ToString("ddd dd.MM.yyyy HH:mm:ss");

        if (cutOffTime)
        {
            return dateString.Split(" ", StringSplitOptions.RemoveEmptyEntries)[0] + " " + dateString.Split(" ", StringSplitOptions.RemoveEmptyEntries)[1];
        }

        if (dateString.EndsWith(" 00:00:00", StringComparison.OrdinalIgnoreCase))
        {
            return dateString.Replace(" 00:00:00", "");
        }
        else
        {
            return dateString;
        }
    }

    public static string ToYesNo(this bool boolean)
    {
        return boolean ? "yes" : "no";
    }

    public static bool IsNullOrEmpty(this string text)
    {
        return string.IsNullOrEmpty(text);
    }

    public static bool IsNullOrWhiteSpace(this string text)
    {
        return string.IsNullOrWhiteSpace(text);
    }

    public static bool IsNotNullOrEmpty(this string text)
    {
        return !string.IsNullOrEmpty(text);
    }

    public static bool IsNotNullOrWhiteSpace(this string text)
    {
        return !string.IsNullOrWhiteSpace(text);
    }

    public static T[] GetEnumValues<T>(this Type type)
    {
        return Enum.GetValues(type).Cast<T>().ToArray();
    }

    public static int ToCeiling(this double number)
    {
        return (int)Math.Ceiling(number);
    }

    public static bool Like(this string text, string searchText)
    {
        if (string.IsNullOrWhiteSpace(text))
        {
            return false;
        }

        if (string.IsNullOrEmpty(searchText))
        {
            return true;
        }

        return text.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0;
    }

    public static bool HasLowerCase(this string text)
    {
        return text.HasPattern("[a-z]");
    }

    public static bool HasUpperCase(this string text)
    {
        return text.HasPattern("[A-Z]");
    }

    public static bool HasDigits(this string text)
    {
        return text.HasPattern("[0-9]");
    }

    public static bool HasPattern(this string text, string pattern)
    {
        return Regex.IsMatch(text, pattern);
    }

    public static int GetUniqueCharacters(this string text)
    {
        var dict = new Dictionary<char, char>();

        foreach (var character in text)
        {
            dict.TryAdd(character, character);
        }

        return dict.Count;
    }
}
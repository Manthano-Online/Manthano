namespace Manthano.Common.Extensions
{
    public static class StringExtensions
    {
        public static bool IsNullOrSpaces(this string text)
        {
            return string.IsNullOrWhiteSpace(text);
        }
    }
}

namespace CaptchaPortal.Core.Models.Enums
{
    [Flags]
    public enum Features : byte
    {
        None = 0,
        ContainsCyrillic = 1 << 0,
        ContainsLatin = 1 << 1,
        ContainsDigits = 1 << 2,
        ContainsSpecialSymbols = 1 << 3,
        IsCaseSensitive = 1 << 4,
    }
}

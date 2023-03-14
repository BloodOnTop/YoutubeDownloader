using System.Text.RegularExpressions;
using YoutubeDownloader.Core.Utils.Extensions;

namespace YoutubeDownloader.Core.Utils;

internal static class Url
{
    public static string? TryExtractFileName(string url) =>
        Regex.Match(url, @".+/([^?]*)").Groups[1].Value.NullIfEmptyOrWhiteSpace();
}
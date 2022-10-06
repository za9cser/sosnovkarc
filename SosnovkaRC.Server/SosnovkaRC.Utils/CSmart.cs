using System.Text.RegularExpressions;
using SmartFormat;
using SmartFormat.Core.Settings;
using SmartFormat.Extensions;

namespace SosnovkaRC.Utils;

/// <summary>
///     Надстройка над SmartFormat, чтобы везде работали дефолтные настройки
/// </summary>
public class CSmart
{
    private static readonly SmartFormatter _formatter = CreateCustomFormatter();

    private static SmartFormatter CreateCustomFormatter()
    {
        var formatter = Smart.CreateDefaultSmartFormat(new SmartSettings
        {
            Formatter = new FormatterSettings { ErrorAction = FormatErrorAction.Ignore },
            Parser = new ParserSettings { ErrorAction = ParseErrorAction.Ignore }
        });

        formatter.AddExtensions(new IsMatchFormatter { RegexOptions = RegexOptions.CultureInvariant | RegexOptions.IgnoreCase });
        return formatter;
    }

    public static string Format(string format, params object?[] args) => _formatter.Format(format, args);
}
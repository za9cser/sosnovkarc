using Newtonsoft.Json;
using System.Diagnostics;

namespace SosnovkaRC.Utils;

public static class JsonUtils
{
    public static JsonSerializerSettings DefaultSerializerSettings = new() { Formatting = Formatting.Indented, ReferenceLoopHandling = ReferenceLoopHandling.Ignore };

    public static bool TryDeserialize<T>(this string value, out T? result)
    {
        try
        {
            result = JsonConvert.DeserializeObject<T>(value);
            return true;
        }
        catch (Exception e)
        {
            Debug.WriteLine(e);
            result = default;
            return false;
        }
    }

    public static string Serialize<T>(this T item) => JsonConvert.SerializeObject(item, DefaultSerializerSettings);
}
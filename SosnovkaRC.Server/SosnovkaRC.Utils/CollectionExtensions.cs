namespace SosnovkaRC.Utils;

public static class CollectionExtensions
{
    public static void ForEach<T>(this T[] items, Action<T> action)
    {
        foreach (var item in items)
        {
            action(item);
        }
    }
}
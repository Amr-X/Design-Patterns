using System.Text.Json;

namespace Prototype;

public static class Extensions
{
    public static T DeepCopyJson<T>(this T obj)
    {
        var json = JsonSerializer.Serialize(obj);
        return JsonSerializer.Deserialize<T>(json)!;
    }
}
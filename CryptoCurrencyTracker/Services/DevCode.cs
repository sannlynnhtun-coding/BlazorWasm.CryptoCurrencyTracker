using System.Text.Json;

namespace CryptoCurrencyTracker.Services
{
    public static class DevCode
    {
        public static string ToJson(this object obj)
        {
            return JsonSerializer.Serialize(obj);
        }
    }
}

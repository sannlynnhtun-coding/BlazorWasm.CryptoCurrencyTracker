namespace CryptoCurrencyTracker.Services
{
    public class ApiUrl
    {
        public static string CoinList(string currency) => $"https://api.coingecko.com/api/v3/coins/markets?vs_currency={currency}&order=market_cap_desc&per_page=100&page=1&sparkline=false";

        public static string SingleCoin(string id) => $"https://api.coingecko.com/api/v3/coins/{id}";

        public static string HistoricalChart(string id, int days = 365, string currency = "USD") => $"https://api.coingecko.com/api/v3/coins/{id}/market_chart?vs_currency={currency}&days={days}";

        public static string TrendingCoins(string currency) => $"https://api.coingecko.com/api/v3/coins/markets?vs_currency={currency}&order=gecko_desc&per_page=10&page=1&sparkline=false&price_change_percentage=24h";

        public static string TrendingCoinsV2(string currency) => $"https://api.coingecko.com/api/v3/coins/markets?vs_currency={currency}&order=market_cap_desc&per_page=100&page=1&sparkline=false";
    }
}

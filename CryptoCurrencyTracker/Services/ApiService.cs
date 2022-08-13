using CryptoCurrencyTracker.Models;
using System.Net.Http.Json;
using static System.Net.WebRequestMethods;

namespace CryptoCurrencyTracker.Services
{
    public interface IApiService
    {
        Task<TrendingCoinsModel[]> GetTrendingCoinsV2Async(string currency);
        Task<CoinListModel[]> GetCoinListAsync(string currency);
        Task<HistoricalChartModel> GetHistoricalChartAsync(string coinId, int days);
        Task<SingleCoinModel> GetSingleCoinAsync(string coinId);
    }

    public class ApiService : IApiService
    {
        private readonly HttpClient _Http;
        public ApiService(HttpClient Http)
        {
            _Http = Http;
        }

        public async Task<TrendingCoinsModel[]> GetTrendingCoinsV2Async(string currency)
        {
            TrendingCoinsModel[] model = new TrendingCoinsModel[0];
            var res = await _Http.GetFromJsonAsync<TrendingCoinsModel[]>(ApiUrl.TrendingCoinsV2("USD"));
            if (res != null)
            {
                model = res;
            }
            return model;
        }

        public async Task<CoinListModel[]> GetCoinListAsync(string currency)
        {
            CoinListModel[] model = new CoinListModel[0];
            var res = await _Http.GetFromJsonAsync<CoinListModel[]>(ApiUrl.CoinList(currency));
            if (res != null)
            {
                model = res;
            }
            return model;
        }

        public async Task<HistoricalChartModel> GetHistoricalChartAsync(string coinId, int days)
        {
            HistoricalChartModel model = new HistoricalChartModel();
            var res = await _Http.GetFromJsonAsync<HistoricalChartModel>(ApiUrl.HistoricalChart(coinId, days));
            if (res != null)
            {
                model = res;
            }
            return model;
        }

        public async Task<SingleCoinModel> GetSingleCoinAsync(string coinId)
        {
            SingleCoinModel model = new SingleCoinModel();
            var res = await _Http.GetFromJsonAsync<SingleCoinModel>(ApiUrl.SingleCoin(coinId));
            if (res != null)
            {
                model = res;
            }
            return model;
        }
    }
}

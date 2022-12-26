namespace CryptoCurrencyTracker.Models
{
    public class HistoricalChartModel
    {
        public bool is_success { get; set; }
        public List<List<double>> prices { get; set; }
        public List<List<double>> market_caps { get; set; }
        public List<List<double>> total_volumes { get; set; }
    }
}

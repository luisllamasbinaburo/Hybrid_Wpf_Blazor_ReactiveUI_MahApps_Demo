using System.Net.Http;
using System.Net.Http.Json;
using System.Reactive;
using System.Threading.Tasks;
using WpfBlazor.Data;
using ReactiveUI;
using System;
using ReactiveUI.Fody.Helpers;
using System.Collections.ObjectModel;
using DynamicData;

namespace WpfBlazor.ViewModels
{
    public class FetchDataViewModel : ReactiveObject
    {
        private readonly WeatherForecastService _weatherForecastService;

        public ObservableCollection<WeatherForecast> Forecasts { get; set; } = new ObservableCollection<WeatherForecast>();

        public FetchDataViewModel(WeatherForecastService weatherForecastService)
        {
            _weatherForecastService = weatherForecastService;    
        }

        public async Task LoadWeatherForecastsAsync()
        {
            Forecasts.Clear();
            Forecasts.AddRange(await _weatherForecastService.GetForecastAsync(DateTime.Now));          
        }       
    }
}

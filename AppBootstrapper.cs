using Microsoft.Extensions.DependencyInjection;
using MudBlazor.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WpfBlazor.ViewModels;

namespace WpfBlazor
{
    public class AppBootstrapper
    {
        public ServiceCollection Services { get; set; } = new ServiceCollection();

        public AppBootstrapper()
        {
            Build();
        }

        public void Build()
        {
            Services.AddWpfBlazorWebView();
#if DEBUG
            Services.AddBlazorWebViewDeveloperTools();
#endif
            Services.AddMudServices();

            InitViewModels();
            InitServices();
        }

        private void InitViewModels()
        {
            Services.AddSingleton<FetchDataViewModel>();
            Services.AddSingleton<CounterViewModel>();
            Services.AddSingleton<GreetingViewModel>();
        }

        private void InitServices()
        {
            Services.AddSingleton<Data.WeatherForecastService>();
        }
    }
}

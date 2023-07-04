using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.Extensions.DependencyInjection;

namespace WpfBlazor
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class MainApp : Application
    {
        public static AppBootstrapper AppBootstrapper;

        public MainApp()
        {
            AppBootstrapper = new AppBootstrapper();            

            InitializeComponent();
            Resources.Add("services", AppBootstrapper.Services.BuildServiceProvider());         

            StartupUri = new Uri("MainWindow.xaml", UriKind.Relative);           
        }

        protected override void OnStartup(StartupEventArgs e)
        {
        }
    }
}

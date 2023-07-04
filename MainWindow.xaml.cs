using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Extensions.DependencyInjection;
using WpfBlazor.ViewModels;
using Microsoft.Extensions.Logging;
using MahApps.Metro.Controls;

namespace WpfBlazor;

public partial class MainWindow : MetroWindow
{
    public MainWindow()
    {
        InitializeComponent();        
    }
}
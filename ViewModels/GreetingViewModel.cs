using System;
using System.Reactive;
using System.Reactive.Linq;
using System.Windows.Input;
using System.Xml.Linq;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;

namespace WpfBlazor.ViewModels
{
    public class GreetingViewModel : ReactiveObject
    {
        public string Name { get; set; }
        public bool CanClear => !string.IsNullOrEmpty(Name);
        public string Greeting => string.IsNullOrWhiteSpace(Name) ? string.Empty : $"Hello, {Name}!";

        public GreetingViewModel()
        {
        }

        public void Clear()
        {
            Name = string.Empty;
        }
    }
}

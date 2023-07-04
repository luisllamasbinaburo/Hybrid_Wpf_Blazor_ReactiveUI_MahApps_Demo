using System;
using System.Reactive;
using System.Threading.Tasks;
using System.Windows.Input;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;

namespace WpfBlazor.ViewModels
{
    public class CounterViewModel : ReactiveObject
    {
        public int CurrentCount {get; set; }

        public CounterViewModel()
        {           
        }
       
        public void IncrementCount()
        {
            CurrentCount++;            
        }
    }
}

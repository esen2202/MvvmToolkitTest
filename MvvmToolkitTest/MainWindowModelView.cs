using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvvmToolkitTest
{
    // [INotifyPropertyChanged]
    public partial class MainWindowModelView : ObservableObject
    {
        [ObservableProperty]
        [AlsoNotifyChangeFor(nameof(Fullname))]
        private string name;

        [ObservableProperty]
        [AlsoNotifyChangeFor(nameof(Fullname))]
        private string surname;


        public string Fullname => $"{Fullname} {Surname}";
      
        [ICommand]
        public void Submit()
        {
            Console.WriteLine("Submit Clicked");
        }

    } 
}

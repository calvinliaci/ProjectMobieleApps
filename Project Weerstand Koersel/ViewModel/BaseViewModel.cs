using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Weerstand_Koersel.ViewModel
{
    public abstract partial class BaseViewModel : ObservableObject
    {
        [ObservableProperty]
        public string title;

        [ObservableProperty]
        public string homeImage;

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(IsNotBusy))]
        public bool isBusy;

        public bool IsNotBusy => !IsBusy;
    }
}

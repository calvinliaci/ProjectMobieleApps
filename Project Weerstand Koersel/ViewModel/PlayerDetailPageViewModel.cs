using CommunityToolkit.Mvvm.ComponentModel;
using Project_Weerstand_Koersel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Weerstand_Koersel.ViewModel
{
    [QueryProperty(nameof(Speler), "Speler")]
    public partial class PlayerDetailPageViewModel : BaseViewModel
    {
        [ObservableProperty]
        Speler speler;
    }
}

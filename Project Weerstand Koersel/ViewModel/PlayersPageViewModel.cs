using CommunityToolkit.Mvvm.Input;
using Microsoft.Maui.Networking;
using Project_Weerstand_Koersel.Model;
using Project_Weerstand_Koersel.Service;
using Project_Weerstand_Koersel.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Project_Weerstand_Koersel.ViewModel
{
    public partial class PlayersPageViewModel : BaseViewModel
    {
        ISpelerService spelerService;
        IConnectivity connectivity;

        public ObservableCollection<Speler> Spelers { get; } = new();


        public PlayersPageViewModel(ISpelerService spelerService, IConnectivity connectivity)
        {
            this.spelerService = spelerService;
            this.connectivity = connectivity;

            Title = "Spelers";
        }

        [RelayCommand]

        async Task GetSpelersAsync()
        {
            if (IsBusy)
                return;

            try
            {
                if (connectivity.NetworkAccess != NetworkAccess.Internet)
                {
                    await Shell.Current.DisplayAlert("No connectivity!",
                        $"Please check internet and try again.", "OK");
                    return;
                }
                IsBusy = true;
                var spelers = await spelerService.GetAllSpelers();

                if (Spelers.Count != 0)
                        Spelers.Clear();

                foreach (var speler in spelers)
                    Spelers.Add(speler);

            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Unable to get players: {ex.Message}");
                await Shell.Current.DisplayAlert("Error!", ex.Message, "OK");
            }
            finally
            {
                IsBusy = false;
            }
        }

        [RelayCommand]
        async Task GoToDetails(Speler speler)
        {
            if (speler == null)
                return;

            await Shell.Current.GoToAsync(nameof(PlayerDetailPage), true, new Dictionary<string, object>
                {
                    {"Speler", speler}
                });
        }
    }


}

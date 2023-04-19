using Project_Weerstand_Koersel.Model;
using Project_Weerstand_Koersel.Service;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Weerstand_Koersel.ViewModel
{
    public class PlayersPageViewModel : BaseViewModel
    {
        ISpelerService spelerService;

        public ObservableCollection<Speler> Spelers { get; } = new();


        public PlayersPageViewModel(ISpelerService spelerService)
        {
            this.spelerService = spelerService;

            Title = "Player Page";
        }
        async Task GetSpelersAsync()
        {
            var spelers = await spelerService.GetAllSpelers();

            if (Spelers.Count != 0)
                Spelers.Clear();

            foreach (var speler in spelers)
                Spelers.Add(speler);
        }
    }


}

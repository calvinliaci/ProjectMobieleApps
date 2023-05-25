using Firebase.Storage;
using Microsoft.Maui.Networking;
using Project_Weerstand_Koersel.Model;
using Project_Weerstand_Koersel.Service;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Project_Weerstand_Koersel.ViewModel
{
    public class MatchesPageViewModel : BaseViewModel
    {

        IMatchService matchService;
        public ObservableCollection<Match> Matches 
        { 
            get;
        }

        public MatchesPageViewModel(IMatchService matchService)
        {
            this.matchService = matchService;

            Title = "Wedstrijden";

            Matches = new ObservableCollection<Match>();

            GetMatches();
        }

        public void GetMatches()
        {
            Task.Run(async () =>
            {
                var matches = await matchService.GetAllMatches();

                foreach (Match match in matches)
                {
                    Matches.Add(match);
                }
            });
        }
    }
}

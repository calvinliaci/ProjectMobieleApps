using Firebase.Database;
using Firebase.Storage;
using Project_Weerstand_Koersel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Project_Weerstand_Koersel.Service
{
    internal class MatchService : IMatchService
    {
        FirebaseClient firebaseClient = new FirebaseClient(baseUrl: "https://project-weerstand-koersel-default-rtdb.europe-west1.firebasedatabase.app/");

        public async Task<List<Match>> GetAllMatches()
        {
            return (await firebaseClient.Child("Matches").OnceAsync<Match>()).Select(item => new Match
            {
                HomeTeam=item.Object.HomeTeam,
                HomeTeamImage=item.Object.HomeTeamImage, 
                AwayTeam=item.Object.AwayTeam,
                AwayTeamImage=item.Object.AwayTeamImage,
                ScoreSheet=item.Object.ScoreSheet,
                Date=item.Object.Date,

            }).ToList();
        }
    }
}

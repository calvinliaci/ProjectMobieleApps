using Firebase.Database;
using Firebase.Database.Streaming;
using Project_Weerstand_Koersel.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Weerstand_Koersel.Service
{
    public class SpelerService : ISpelerService
    {
        FirebaseClient firebaseClient = new FirebaseClient(baseUrl: "https://project-weerstand-koersel-default-rtdb.europe-west1.firebasedatabase.app/");

        public List<Speler> spelersList { get; set; } = new();

        public async Task<List<Speler>> GetAllSpelers()
        {
            return (await firebaseClient.Child("Spelers").OnceAsync<Speler>()).Select(item => new Speler
            {
                FirstName=item.Object.FirstName,
                LastName=item.Object.LastName,
                Age=item.Object.Age,
                Position=item.Object.Position,
                TotalAssists=item.Object.TotalAssists,
                TotalGoals=item.Object.TotalGoals,
                TotalGames=item.Object.TotalGames,

            }).ToList();
        }
    }
}

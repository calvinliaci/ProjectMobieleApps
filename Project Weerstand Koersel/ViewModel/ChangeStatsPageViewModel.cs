using CommunityToolkit.Mvvm.Input;
using Firebase.Database;
using Firebase.Database.Query;
using Plugin.Media;
using Plugin.Media.Abstractions;
using Project_Weerstand_Koersel.Model;
using Project_Weerstand_Koersel.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Weerstand_Koersel.ViewModel
{
     public partial class ChangeStatsPageViewModel : BaseViewModel
     {
        public string FullName { get; set; }
        public string Age { get; set; }
        public string Image { get; set; }
        public string Position { get; set; }
        public string PositionSmall { get; set; }
        public string TotalGames { get; set; }
        public string TotalGoals { get; set; }
        public string TotalAssists { get; set; }
        public string JerseyNumber { get; set; }

        public ChangeStatsPageViewModel()
        {
            Title = "Speler toevoegen";
            Image = "https://firebasestorage.googleapis.com/v0/b/project-weerstand-koersel.appspot.com/o/players%2FBelien%20Dries.jpg?alt=media&token=b2e714ff-e343-4433-9202-273b9ff72d2a";
        }

        [RelayCommand]
        private void SendPlayerToDatabase() 
        {
            FirebaseClient firebaseClient = new FirebaseClient(baseUrl: "https://project-weerstand-koersel-default-rtdb.europe-west1.firebasedatabase.app/");

            firebaseClient.Child("Spelers").PostAsync(new Speler()
            {
                Name = FullName,
                Age = "Leeftijd: " + Age,
                Position = "Positie: " + Position,
                PositionSmall = Position,
                JerseyNumber = "Positie: " + JerseyNumber,
                TotalGames = "Wedstrijden: " + TotalGames,
                TotalGoals = "Goals: " + TotalGoals,
                TotalAssists = "Assists: " + TotalAssists,
                Image = Image,
            });

            Shell.Current.GoToAsync(nameof(PlayersPage));
        }
     }
}

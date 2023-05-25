using CommunityToolkit.Mvvm.Input;
using Firebase.Database;
using Firebase.Database.Query;
using Project_Weerstand_Koersel.Model;
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

        public ChangeStatsPageViewModel()
        {
            Title = "Speler toevoegen";
        }

        [RelayCommand]
        private void SendPlayerToDatabase() 
        {
            FirebaseClient firebaseClient = new FirebaseClient(baseUrl: "https://project-weerstand-koersel-default-rtdb.europe-west1.firebasedatabase.app/");

            firebaseClient.Child("Spelers").PostAsync(new Speler()
            {
                Name = FullName,
                Age = "Leeftijd: " + Age,
                Position = "fef"
            });
        }
     }
}

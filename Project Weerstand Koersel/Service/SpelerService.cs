using Firebase.Database;
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

        public ObservableCollection<Speler> spelersList { get; set; } = new();


    }
}

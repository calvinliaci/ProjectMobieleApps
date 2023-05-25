using Firebase.Database;
using Project_Weerstand_Koersel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Weerstand_Koersel.Service
{
    public class SponsorService : ISponsorService
    {
        FirebaseClient firebaseClient = new FirebaseClient(baseUrl: "https://project-weerstand-koersel-default-rtdb.europe-west1.firebasedatabase.app/");

        public async Task<List<Sponsor>> GetAllSponsorImages()
        {
            return (await firebaseClient.Child("Sponsor").OnceAsync<Sponsor>()).Select(item => new Sponsor
            {
                SponsorImage = item.Object.SponsorImage,

            }).ToList();
        }
    }
}

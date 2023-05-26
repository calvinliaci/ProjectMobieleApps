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
        FirebaseClient firebaseClient = new FirebaseClient(baseUrl: "https://project-weerstand-koersel-default-rtdb.europe-west1.firebasedatabase.app");

        public async Task<List<Sponsor>> GetAllSponsorImages()
        {
            return (await firebaseClient.Child("Sponsor").OnceAsync<Sponsor>()).Select(item => new Sponsor
            {
                SponsorImage1 = item.Object.SponsorImage1,
                SponsorImage2 = item.Object.SponsorImage2,
                SponsorImage3 = item.Object.SponsorImage3,
                SponsorImage4 = item.Object.SponsorImage4,
                SponsorImage5 = item.Object.SponsorImage5,
                SponsorImage6 = item.Object.SponsorImage6,
                SponsorImage7 = item.Object.SponsorImage7,
                SponsorImage8 = item.Object.SponsorImage8,
                SponsorImage9 = item.Object.SponsorImage9,
                SponsorImage10 = item.Object.SponsorImage10,
                SponsorImage11 = item.Object.SponsorImage11,
                SponsorImage12 = item.Object.SponsorImage12,
                SponsorImage13 = item.Object.SponsorImage13,
                HomeImage = item.Object.HomeImage,

            }).ToList();
        }
    }
}

using Project_Weerstand_Koersel.Model;
using Project_Weerstand_Koersel.Service;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace Project_Weerstand_Koersel.ViewModel
{
    public partial class MainPageViewModel : BaseViewModel
    {
        ISponsorService sponsorService;
        public ObservableCollection<Sponsor> Sponsors
        {
            get;
        }

        public MainPageViewModel(ISponsorService sponsorService)
        {
            this.sponsorService = sponsorService;

            Title = "Startpagina";

            Sponsors = new ObservableCollection<Sponsor>();

            GetSponsorImages();
        }

        public void GetSponsorImages()
        {
            Task.Run(async () =>
            {
                var sponsors = await sponsorService.GetAllSponsorImages();

                foreach (Sponsor sponsor in sponsors)
                {
                    Sponsors.Add(sponsor);
                }
            });
        }


        //public string Sponsor1 { get; set; }
        //public string Sponsor2 { get; set; }
        //public string Sponsor3 { get; set; }
        //public string Sponsor4 { get; set; }
        //public string Sponsor5 { get; set; }
        //public string Sponsor6 { get; set; }
        //public string Sponsor7 { get; set; }
        //public string Sponsor8 { get; set; }
        //public string Sponsor9 { get; set; }
        //public string Sponsor10 { get; set; }
        //public string Sponsor11 { get; set; }
        //public string Sponsor12 { get; set; }
        //public string Sponsor13 { get; set; }
        //public MainPageViewModel()
        //{
        //    Title = "K.V.V. Weerstand Koersel";
        //    HomeImage = "https://firebasestorage.googleapis.com/v0/b/project-weerstand-koersel.appspot.com/o/teams%2Flogo.png?alt=media&token=a46a79ee-a629-4dd4-b26f-1470105ddf38";
        //    Sponsor1 = "https://firebasestorage.googleapis.com/v0/b/project-weerstand-koersel.appspot.com/o/sponsors%2Feli.png?alt=media&token=d998b20f-3013-4fdb-8a89-46bea388c5c4";
        //    Sponsor2 = "https://firebasestorage.googleapis.com/v0/b/project-weerstand-koersel.appspot.com/o/sponsors%2Fmultiline.png?alt=media&token=39bbaae8-89a0-4b38-9ce3-ba2b97e6c016";
        //    Sponsor3 = "https://firebasestorage.googleapis.com/v0/b/project-weerstand-koersel.appspot.com/o/sponsors%2Ftemur.png?alt=media&token=276ccef7-cba9-4ea6-bf93-0d67a62d23db";
        //    Sponsor4 = "https://firebasestorage.googleapis.com/v0/b/project-weerstand-koersel.appspot.com/o/sponsors%2FRR.png?alt=media&token=935f225f-752c-49e0-a59a-e547720ef988";
        //    Sponsor5 = "https://firebasestorage.googleapis.com/v0/b/project-weerstand-koersel.appspot.com/o/sponsors%2FBZTHIJS.jpg?alt=media&token=a20eac70-31bf-444e-8fe0-da5ef2aac808";
        //    Sponsor6 = "https://firebasestorage.googleapis.com/v0/b/project-weerstand-koersel.appspot.com/o/sponsors%2FLWB.jpg?alt=media&token=ed56e690-78fa-4a44-bfcd-59f7cf8bf92c";
        //    Sponsor7 = "https://firebasestorage.googleapis.com/v0/b/project-weerstand-koersel.appspot.com/o/sponsors%2Flimsolar.jpg?alt=media&token=b34806fd-f0d6-4ea3-9158-9821e6c3cd76";
        //    Sponsor8 = "https://firebasestorage.googleapis.com/v0/b/project-weerstand-koersel.appspot.com/o/sponsors%2Fabfk.png?alt=media&token=97cfb83b-62cc-4a7e-8159-985798703024";
        //    Sponsor9 = "https://firebasestorage.googleapis.com/v0/b/project-weerstand-koersel.appspot.com/o/sponsors%2Fphonebase.png?alt=media&token=917c51c2-2a1d-42fb-8a0b-b23a8f8dc1f3";
        //    Sponsor10 = "https://firebasestorage.googleapis.com/v0/b/project-weerstand-koersel.appspot.com/o/sponsors%2Fwebgrafic.png?alt=media&token=5f73f22c-a515-4c15-a803-c9e228852e2d";
        //    Sponsor11 = "https://firebasestorage.googleapis.com/v0/b/project-weerstand-koersel.appspot.com/o/sponsors%2Fvossen.jpg?alt=media&token=a7fe2874-5309-4f9c-a42c-04ba8d6c7423";
        //    Sponsor12 = "https://firebasestorage.googleapis.com/v0/b/project-weerstand-koersel.appspot.com/o/sponsors%2FFINFuture.jpg?alt=media&token=5036a4f8-7419-4f04-aad4-ebf1fbc21a7b";
        //    Sponsor13 = "https://firebasestorage.googleapis.com/v0/b/project-weerstand-koersel.appspot.com/o/sponsors%2Fwallsystems.jpg?alt=media&token=0267e959-cc77-4651-bbad-fc6c942ef18f";
        //}
    }
}

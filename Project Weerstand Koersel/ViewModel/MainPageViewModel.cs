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
    }
}

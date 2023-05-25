using Project_Weerstand_Koersel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Weerstand_Koersel.Service
{
    public interface ISponsorService
    {
        Task<List<Sponsor>> GetAllSponsorImages();
    }
}

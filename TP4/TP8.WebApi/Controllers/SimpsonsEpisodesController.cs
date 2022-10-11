using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using TP8.WebApi.Models;

namespace TP8.WebApi.Controllers
{
    public class SimpsonsEpisodesController : Controller
    {
        // GET: SimpsonsEpisodes
        public async Task<ActionResult> Index()
        {
            var httpClient = new HttpClient();
            var json = await httpClient.GetStringAsync("https://api.sampleapis.com/simpsons/episodes");
            var deserializedList = JsonConvert.DeserializeObject<List<SimpsonsEpisodesView>>(json);

            List<SimpsonsEpisodesView> simpsonsEpisodesList = deserializedList.Select(s => new SimpsonsEpisodesView 
            {
                Season=s.Season,
                Episode=s.Episode,
                Name=s.Name,
            }).ToList();

            return View(simpsonsEpisodesList);
        }
    }
}
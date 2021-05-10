using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FlyUpCore5.Data;
using FlyUpCore5.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FlyUpCore5.Controllers
{
    public class VideosController : Controller
    {
        private VideosRepository _videosRepository = null;

        public VideosController()
        {
            _videosRepository = new VideosRepository();
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            IList<Video> videos = _videosRepository.GetList();
            return View(videos);
        }
    }
}

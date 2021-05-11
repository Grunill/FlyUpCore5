using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FlyUpCore5.Data;
using FlyUpCore5.Models;
using FlyUpCore5.ViewModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FlyUpCore5.Controllers
{
    public class VideosController : Controller
    {
        private VideosRepository _videosRepository = null;
        private ActivitiesRepository _activitiesRepository = null;

        public VideosController()
        {
            _videosRepository = new VideosRepository();
            _activitiesRepository = new ActivitiesRepository();
        }

        public IActionResult Index_ReturnModelExample()
        {
            IList<Video> videos = _videosRepository.GetList();
            return View(videos);
        }

        public IActionResult Index(string mysearch)
        {
            //mysearch will be null when page first called from menu
            if (mysearch == null)
            {
                mysearch = "1";
            }

            var viewModel = new VideosIndexViewModel(mysearch, _videosRepository, _activitiesRepository);
            return View(viewModel);
        }
    }
}

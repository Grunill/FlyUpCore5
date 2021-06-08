using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FlyUpCore5.Data;
using FlyUpCore5.Models;
using FlyUpCore5.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FlyUpCore5.Controllers
{
    public class VideosController : Controller
    {
        private readonly MyContext _context;

        public VideosController(MyContext context)
        {
            _context = context;
        }

        public IActionResult Index(string mysearch)
        {
            //mysearch will be null when page first called from menu
            if (mysearch == null)
            {
                mysearch = "1";
            }

            //var viewModel = new VideosIndexViewModel(mysearch, _videosRepository, _activitiesRepository);
            var viewModel = new VideosIndexViewModel(mysearch, _context);
            return View(viewModel);
        }

        public ActionResult Detail(int? id)
        {
            Video video = _context.Video.Include(v => v.Activity).FirstOrDefault(v => v.Id == id);

            //var video = _videosRepository.Get((int)id);
            return View(video);
        }

        public ActionResult Edit(int? id)
        {
            Video video = _context.Video.Include(v => v.Activity).FirstOrDefault(v => v.Id == id);

            var viewModel = new VideosEditViewModel(_context)
            {
                Video = video
            };

            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Edit(VideosEditViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                var video = viewModel.Video;
                _context.Update(video);
                _context.SaveChanges();

                return RedirectToAction("Detail", new { id = video.Id });
            }

            return View(viewModel);
        }


    }
}

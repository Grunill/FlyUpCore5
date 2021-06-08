using System;
using System.Linq;
using FlyUpCore5.Data;
using FlyUpCore5.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FlyUpCore5.ViewModels
{
    public class VideosCreateViewModel
    {
        public Video Video { get; set; } = new Video();
        public SelectList activitiesSL { get; set; }
        public int Id
        {
            get { return Video.Id; }
            set { Video.Id = value; }
        }

        public VideosCreateViewModel()
        {

        }

        public VideosCreateViewModel(MyContext _context)
        {
            activitiesSL = new SelectList(_context.Activity.ToList(), "Id", "Title");
        }
    }
}



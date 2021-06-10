using System;
using System.Collections.Generic;
using System.Linq;
using FlyUpCore5.Data;
using FlyUpCore5.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace FlyUpCore5.ViewModels
{
    public class VideosIndexViewModel
    {
        public IList<Video> videos = null;
        public IList<Activity> activities = null;
        public SelectList activitiesSL { get; set; }

        public VideosIndexViewModel(string mysearch, MyContext _context)
        {
            //ViewModel includes list of videos to display and list of activitiesSL for the drop down select list

            //"1" = "All"
            if (mysearch != "1")
            {
                videos = _context.Video
                .Where(videos => videos.ActivityId == Convert.ToInt32(mysearch))
                .OrderByDescending(videos => videos.ViewCount)
                .Include(videos => videos.Activity)                
                .ToList();
            }
            else
            {
                videos = _context.Video
                .OrderByDescending(videos => videos.ViewCount)
                .Include(videos => videos.Activity)
                .ToList();
            }

            activitiesSL = new SelectList(_context.Activity.ToList(),"Id", "Title");
        }

    }
}

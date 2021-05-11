using System;
using System.Collections.Generic;
using FlyUpCore5.Data;
using FlyUpCore5.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FlyUpCore5.ViewModels
{
    public class VideosIndexViewModel
    {
        public IList<Video> videos = null;
        public IList<Activity> activities = null;
        public SelectList activitiesSL { get; set; }

        public VideosIndexViewModel()
        {
        }

        public VideosIndexViewModel(string mysearch, VideosRepository _videosRepository, ActivitiesRepository _activitiesRepository)
        {
            videos = _videosRepository.GetListSearch(mysearch);

            activitiesSL = new SelectList(
                _activitiesRepository.GetList(),
                "Id", "Title");
        }
    }
}

using System;
using System.Collections.Generic;
using FlyUpCore5.Models;

namespace FlyUpCore5.Data
{
    public class ActivitiesRepository
    {
        public ActivitiesRepository()
        {
        }

        public IList<Activity> GetList()
        {
            var _activities = SeedActivities();
            return _activities;
        }

        private IList<Activity> SeedActivities()
        {

            var seedActivities = new List<Activity>();

            var activityAll = new Activity() { Id = 1, Title = "All", Description = "All Description" };
            var activityKitesurf = new Activity() { Id = 2, Title = "Kitesurf", Description = "Kitesurf Description" };
            var activityParaglide = new Activity() { Id = 3, Title = "Paraglide", Description = "Paraglide Description" };
            var activityParamotor = new Activity() { Id = 4, Title = "Paramotor", Description = "Paramotor Description" };
            var activityPlane = new Activity() { Id = 5, Title = "Plane", Description = "Plane Description" };
            var activitySkydive = new Activity() { Id = 6, Title = "Skydive", Description = "Skydive Description" };
            var activitySnowboard = new Activity() { Id = 7, Title = "Snowboard", Description = "Snowboard Description" };
            var activityWakeboard = new Activity() { Id = 8, Title = "Wakeboard", Description = "Wakeboard Description" };
            var activityLandboarding = new Activity() { Id = 9, Title = "Landboarding", Description = "Landboarding Description" };
            var activitySailing = new Activity() { Id = 10, Title = "Sailing", Description = "Sailing Description" };

            seedActivities.Add(activityAll);
            seedActivities.Add(activityKitesurf);
            seedActivities.Add(activityParaglide);
            seedActivities.Add(activityParamotor);
            seedActivities.Add(activityPlane);
            seedActivities.Add(activitySkydive);
            seedActivities.Add(activitySnowboard);
            seedActivities.Add(activityWakeboard);
            seedActivities.Add(activityLandboarding);
            seedActivities.Add(activitySailing);

            return seedActivities;
        }
    }
}

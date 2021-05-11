using System;
using System.Collections.Generic;
using FlyUpCore5.Models;
using System.Linq;

namespace FlyUpCore5.Data
{
    public class VideosRepository
    {
        public VideosRepository()
        {
        }

        public IList<Video> GetList()
        {
            var _videos = SeedVideos();
            return _videos;
        }

        public IList<Video> GetListSearch(string mysearch)
        {
            var _videos = SeedVideos().AsQueryable();

            //"1" = "All"
            if (mysearch != "1")
            {
                _videos = _videos
                    .Where(v => v.Activity.Id.ToString() == mysearch);
            }
            //_videos = _videos.Where(v => v.Activity.Title == "Kitesurf");

            return _videos.ToList();
        }

        private IList<Video> SeedVideos()
        {
            var seedVideos = new List<Video>();

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

            var video1 = new Video()
            {
                Id = 1,
                Title = "Abersoch",
                Description = "21-02-2018 - Black Rock Sands to Abersoch. (Camera and Edit Jason Grunill)",
                //Url = "https://youtu.be/yZ4Vm3iT-go",
                Url = "yZ4Vm3iT-go",
                Activity = activityParamotor,
                ViewCount = 72,
            };

            var video2 = new Video()
            {
                Id = 2,
                Title = "Alton Towers",
                Description = "24-08-2019 - School Reunion tribute to Ian Barnes. (Camera and Edit Jason Grunill)",
                //Url = "https://youtu.be/4sY4PLUxyDE",
                Url = "4sY4PLUxyDE",
                Activity = activityParamotor,
                ViewCount = 54,
            };

            var video3 = new Video()
            {
                Id = 3,
                Title = "Balterley",
                Description = "30-03-2019 - Mission Balterley. (Camera and Edit Jason Grunill)",
                //Url = "https://youtu.be/zuUJBipJOgo",
                Url = "zuUJBipJOgo",
                Activity = activityParamotor,
                ViewCount = 71,
            };

            var video4 = new Video()
            {
                Id = 4,
                Title = "Chase A",
                Description = "25-11-2018 - Chase flight. (Camera and Edit Jason Grunill)",
                //Url = "https://youtu.be/Qiwn9Cq-gws",
                Url = "Qiwn9Cq-gws",
                Activity = activityParamotor,
                ViewCount = 48,
            };

            var video5 = new Video()
            {
                Id = 5,
                Title = "Cloud A",
                Description = "26-01-2018 - Cloud flight. (Camera and Edit Jason Grunill)",
                //Url = "https://youtu.be/EjU8qW25Qao",
                Url = "EjU8qW25Qao",
                Activity = activityParamotor,
                ViewCount = 58,
            };

            var video6 = new Video()
            {
                Id = 6,
                Title = "Cloud B",
                Description = "17-02-2018 - Cloud flight. (Camera and Edit Jason Grunill)",
                //Url = "https://youtu.be/cpW1-Old-SY",
                Url = "cpW1-Old-SY",
                Activity = activityParamotor,
                ViewCount = 56,
            };

            var video7 = new Video()
            {
                Id = 7,
                Title = "Devon",
                Description = "04-08-2018 - Devon flyin. (Combined camera footage from Jason Grunill, JPD and CD)",
                //Url = "https://youtu.be/n8KNdJSHCw8",
                Url = "n8KNdJSHCw8",
                Activity = activityParamotor,
                ViewCount = 31,
            };

            var video8 = new Video()
            {
                Id = 8,
                Title = "Legend",
                Description = "2018 - Tribute to JS a true legend. (Camera and Edit Jason Grunill)",
                //Url = "https://youtu.be/R4DA1uIRals",
                Url = "R4DA1uIRals",
                Activity = activityParamotor,
                ViewCount = 206,
            };

            var video9 = new Video()
            {
                Id = 9,
                Title = "Llandudno",
                Description = "06-10-2015 - Beach flight. (Camera and Edit Jason Grunill)",
                //Url = "https://youtu.be/JmlPlmjE9ss",
                Url = "JmlPlmjE9ss",
                Activity = activityParamotor,
                ViewCount = 280,
            };

            var video10 = new Video()
            {
                Id = 10,
                Title = "Parafest 2018",
                Description = "2018 - Parafest annual flying festival held this year at Llanbedr. (Camera and Edit Jason Grunill)",
                //Url = "https://youtu.be/DlsQpSk6Who",
                Url = "DlsQpSk6Who",
                Activity = activityParamotor,
                ViewCount = 98,
            };

            var video11 = new Video()
            {
                Id = 11,
                Title = "Snowdon",
                Description = "21-02-2018 - Black Rock Sands to Snowdon. Just short of the summit due to cloud cover. (Camera and Edit Jason Grunill)",
                //Url = "https://youtu.be/3UnE10D8cFI",
                Url = "3UnE10D8cFI",
                Activity = activityParamotor,
                ViewCount = 39,
            };

            var video12 = new Video()
            {
                Id = 12,
                Title = "Stafford Castle",
                Description = "23-03-2019 - Barlaston to Stafford Castle. (Camera and Edit Jason Grunill)",
                //Url = "https://youtu.be/EsuXYr16ieY",
                Url = "EsuXYr16ieY",
                Activity = activityParamotor,
                ViewCount = 34,
            };

            var video13 = new Video()
            {
                Id = 13,
                Title = "The Wild Boys",
                Description = "05-05-2019 - Quarry flight. (Camera and Edit Jason Grunill)",
                //Url = "https://youtu.be/LjvnaeTtIRU",
                Url = "LjvnaeTtIRU",
                Activity = activityParamotor,
                ViewCount = 24,
            };

            var video14 = new Video()
            {
                Id = 14,
                Title = "The Wild Geese",
                Description = "08-09-2019 - Amazing flight. I was joined by a flock of geese as I flew along the canal. (Camera and Edit Jason Grunill)",
                //Url = "https://youtu.be/cOb7jvDIJaI",
                Url = "cOb7jvDIJaI",
                Activity = activityParamotor,
                ViewCount = 23,
            };

            var video15 = new Video()
            {
                Id = 15,
                Title = "Trike",
                Description = "10-11-2019 - JG and KG first trike flights on KG trike. (Camera and Edit Jason Grunill, thanks to KG for extra footage)",
                //Url = "https://youtu.be/d2-1bN1-N9s",
                Url = "d2-1bN1-N9s",
                Activity = activityParamotor,
                ViewCount = 53,
            };

            var video16 = new Video()
            {
                Id = 16,
                Title = "Yellow",
                Description = "19-05-2018 - Footdragging rapeseed fields. Flyby at the model flyers weekend. Landed out in a field full of cows because of heavy rain on the way back. Rescued by JS. (Camera and Edit Jason Grunill)",
                //Url = "https://youtu.be/OSsSV2dmysY",
                Url = "OSsSV2dmysY",
                Activity = activityParamotor,
                ViewCount = 56,
            };

            var video17 = new Video()
            {
                Id = 17,
                Title = "Edge Top",
                Description = "04-01-2015 - Edge Top. (Camera and Edit Jason Grunill)",
                //Url = "https://youtu.be/557xLuPDkNw",
                Url = "557xLuPDkNw",
                Activity = activityParaglide,
                ViewCount = 215,
            };

            var video18 = new Video()
            {
                Id = 18,
                Title = "Treak Cliff",
                Description = "01-05-2015 - Birthday flight thermals to 3000ft and 06-02-2015 Snow flight. (Camera and Edit Jason Grunill)",
                //Url = "https://youtu.be/CzPn4VFYPcQ",
                Url = "CzPn4VFYPcQ",
                Activity = activityParaglide,
                ViewCount = 23,
            };

            var video19 = new Video()
            {
                Id = 19,
                Title = "Betton Pool",
                Description = "18-11-2018 - Wakeboard session",
                //Url = "https://youtu.be/nGq_pVExarg",
                Url = "nGq_pVExarg",
                Activity = activityWakeboard,
                ViewCount = 24,
            };

            var video20 = new Video()
            {
                Id = 20,
                Title = "Raley",
                Description = "27-03-2011 - Wakeboard session at Blackpool Wake Park",
                //Url = "https://youtu.be/7U0MNCZSXqw",
                Url = "7U0MNCZSXqw",
                Activity = activityWakeboard,
                ViewCount = 21,
            };

            var video21 = new Video()
            {
                Id = 21,
                Title = "Blackpool",
                Description = "13-09-2018 - Kitesurf session. (Camera and Edit Jason Grunill)",
                //Url = "https://youtu.be/wxrsrKFM6nU",
                Url = "wxrsrKFM6nU",
                Activity = activityKitesurf,
                ViewCount = 59,
            };

            var video22 = new Video()
            {
                Id = 22,
                Title = "La Mata",
                Description = "12-06-2019 - Kitesurf session. (Camera Rebecca, Edit Jason Grunill)",
                //Url = "https://youtu.be/MhutHIObN3c",
                Url = "MhutHIObN3c",
                Activity = activityKitesurf,
                ViewCount = 49,
            };

            var video23 = new Video()
            {
                Id = 23,
                Title = "Snow In June",
                Description = "June-2018 - JG Snowboarding and JE Skiing at Chill Factor",
                //Url = "https://youtu.be/pVg-LlASjJU",
                Url = "pVg-LlASjJU",
                Activity = activitySnowboard,
                ViewCount = 35,
            };

            var video24 = new Video()
            {
                Id = 24,
                Title = "Piper Archer",
                Description = "July-2018 - JD takes JG and KM on a flight over Snowdon. KM takes over controls on flight out, JG takes over controls on flight home. (Camera and Edit Jason Grunill)",
                //Url = "https://youtu.be/uyFLhvaAOlw",
                Url = "uyFLhvaAOlw",
                Activity = activityPlane,
                ViewCount = 51,
            };

            var video25 = new Video()
            {
                Id = 25,
                Title = "Skydive",
                Description = "January-2000 - JG and DG tandem Skydive, Langar airfield.",
                //Url = "https://youtu.be/FpSbgRd5Lfw",
                Url = "FpSbgRd5Lfw",
                Activity = activitySkydive,
                ViewCount = 19,
            };

            var video26 = new Video()
            {
                Id = 26,
                Title = "Stafford Castle 2",
                Description = "25-05-2020 Barlaston to Stafford Castle JG, CS, KG, AF. (Camera and Edit Jason Grunill)",
                //Url = "https://youtu.be/lEca8eG18hQ",
                Url = "lEca8eG18hQ",
                Activity = activityParamotor,
                ViewCount = 26,
            };

            var video27 = new Video()
            {
                Id = 27,
                Title = "The Return",
                Description = "16-05-2020 Return to Barlaston. (Camera and Edit Jason Grunill)",
                //Url = "https://youtu.be/wDhjB02C4MQ",
                Url = "wDhjB02C4MQ",
                Activity = activityParamotor,
                ViewCount = 32,
            };

            var video28 = new Video()
            {
                Id = 28,
                Title = "Angel",
                Description = "19-05-2020 Barlaston. (Camera and Edit Jason Grunill)",
                //Url = "https://youtu.be/RA08xzVucXk",
                Url = "RA08xzVucXk",
                Activity = activityParamotor,
                ViewCount = 23,
            };

            var video29 = new Video()
            {
                Id = 29,
                Title = "Beeston Castle",
                Description = "27-05-2020 Beeston Castle and Peckforton Castle. (Camera and Edit Jason Grunill)",
                //Url = "https://youtu.be/F2IldKuoYWQ",
                Url = "F2IldKuoYWQ",
                Activity = activityParamotor,
                ViewCount = 24,
            };

            var video30 = new Video()
            {
                Id = 30,
                Title = "Freeride 19M",
                Description = "First flight on Jon's Ozone Freeride 19M. (Camera and Edit Jason Grunill)",
                //Url = "https://youtu.be/a7qxT6N-WUE",
                Url = "a7qxT6N-WUE",
                Activity = activityParamotor,
                ViewCount = 29,
            };

            var video31 = new Video()
            {
                Id = 31,
                Title = "Landboarding",
                Description = "Landboarding Age 18",
                //Url = "https://youtu.be/xe0wClCPP50",
                Url = "xe0wClCPP50",
                Activity = activityLandboarding,
                ViewCount = 23,
            };

            var video32 = new Video()
            {
                Id = 32,
                Title = "St Annes",
                Description = "22n29-09-2018 - Kitesurf session. (Camera and Edit Jason Grunill)",
                //Url = "https://youtu.be/meRg557HaDA",
                Url = "meRg557HaDA",
                Activity = activityKitesurf,
                ViewCount = 20,
            };

            var video33 = new Video()
            {
                Id = 33,
                Title = "Vision Ascent",
                Description = "02-07-2020 Vision Part 1 - Cloud flight ascent to 8500ft. (Camera and Edit Jason Grunill)",
                //Url = "https://youtu.be/ILpaSPLwbDw",
                Url = "ILpaSPLwbDw",
                Activity = activityParamotor,
                ViewCount = 85,
            };

            var video34 = new Video()
            {
                Id = 34,
                Title = "Vision Descent",
                Description = "02-07-2020 Vision Part 2 - Cloud flight descent from 8500ft. (Camera and Edit Jason Grunill)",
                //Url = "https://youtu.be/T1QKAtq6Sas",
                Url = "T1QKAtq6Sas",
                Activity = activityParamotor,
                ViewCount = 79,
            };

            var video35 = new Video()
            {
                Id = 35,
                Title = "Legend 2",
                Description = "Whiston and Barlaston Flypast tribute to JS. (Camera and Edit Jason Grunill)",
                //Url = "https://youtu.be/njdAHL_LNHQ",
                Url = "njdAHL_LNHQ",
                Activity = activityParamotor,
                ViewCount = 38,
            };

            var video36 = new Video()
            {
                Id = 36,
                Title = "Rock The Boat",
                Description = "22-07-2018 Sailing the RS Venture at Rhos-on-Sea. (Camera and Edit Jason Grunill)",
                //Url = "https://youtu.be/pVs48-OJaFY",
                Url = "pVs48-OJaFY",
                Activity = activitySailing,
                ViewCount = 15,
            };

            var video37 = new Video()
            {
                Id = 37,
                Title = "Kite School",
                Description = "02-08-2020 Jase and Tom St Annes. Tom's Kitesurfing Lessons - Day 1. (Camera and Edit Jason Grunill)",
                //Url = "https://youtu.be/ls9m_1JbIYU",
                Url = "ls9m_1JbIYU",
                Activity = activityKitesurf,
                ViewCount = 42,
            };

            var video38 = new Video()
            {
                Id = 38,
                Title = "Engine Out Practice",
                Description = "30-07-2020 Engine out practice (1000ft, 1000ft and 4000ft) with an XC to Sandon Hall Drive-In. (Camera and Edit Jason Grunill)",
                //Url = "https://youtu.be/g4vhfkqnEGQ",
                Url = "g4vhfkqnEGQ",
                Activity = activityParamotor,
                ViewCount = 18,
            };

            var video39 = new Video()
            {
                Id = 39,
                Title = "Kite School 2",
                Description = "05-09-2020 Jase and Tom St Annes. Tom's Kitesurfing Lessons - Day 2",
                //Url = "https://youtu.be/--Ugr7XHjdE",
                Url = "--Ugr7XHjdE",
                Activity = activityKitesurf,
                ViewCount = 23,
            };

            var video40 = new Video()
            {
                Id = 40,
                Title = "Touch And Go",
                Description = "08-03-2021 JG, JB and AF Touch and Go practice plus bonus JG new years eve snow flight over home. (Camera and Edit Jason Grunill)",
                //Url = "https://youtu.be/WkujXRObVeM",
                Url = "WkujXRObVeM",
                Activity = activityParamotor,
                ViewCount = 8,
            };

            var video41 = new Video()
            {
                Id = 41,
                Title = "Caravan",
                Description = "The Chosen Few evening flight. Big thanks to our hosts Rob and Dan. (Camera and Edit Jason Grunill, thanks to Rob for ground footage)",
                //Url = "https://youtu.be/FArl1GFprQs",
                Url = "FArl1GFprQs",
                Activity = activityParamotor,
                ViewCount = 5,
            };

            seedVideos.Add(video1);
            seedVideos.Add(video2);
            seedVideos.Add(video3);
            seedVideos.Add(video4);
            seedVideos.Add(video5);
            seedVideos.Add(video6);
            seedVideos.Add(video7);
            seedVideos.Add(video8);
            seedVideos.Add(video9);
            seedVideos.Add(video10);
            seedVideos.Add(video11);
            seedVideos.Add(video12);
            seedVideos.Add(video13);
            seedVideos.Add(video14);
            seedVideos.Add(video15);
            seedVideos.Add(video16);
            seedVideos.Add(video17);
            seedVideos.Add(video18);
            seedVideos.Add(video19);
            seedVideos.Add(video20);
            seedVideos.Add(video21);
            seedVideos.Add(video22);
            seedVideos.Add(video23);
            seedVideos.Add(video24);
            seedVideos.Add(video25);
            seedVideos.Add(video26);
            seedVideos.Add(video27);
            seedVideos.Add(video28);
            seedVideos.Add(video29);
            seedVideos.Add(video30);
            seedVideos.Add(video31);
            seedVideos.Add(video32);
            seedVideos.Add(video33);
            seedVideos.Add(video34);
            seedVideos.Add(video35);
            seedVideos.Add(video36);
            seedVideos.Add(video37);
            seedVideos.Add(video38);
            seedVideos.Add(video39);
            seedVideos.Add(video40);
            seedVideos.Add(video41);

            return seedVideos;
        }
    }
}

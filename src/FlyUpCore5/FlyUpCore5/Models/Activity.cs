using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FlyUpCore5.Models
{
    public class Activity
    {
        public Activity()
        {
            Videos = new List<Video>();
        }
        public int Id { get; set; }
        [Required, StringLength(200)]
        public string Title { get; set; }
        public string Description { get; set; }

        public ICollection<Video> Videos { get; set; }
    }
}

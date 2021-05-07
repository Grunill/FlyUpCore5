using System;
using System.ComponentModel.DataAnnotations;

namespace FlyUpCore5.Models
{
    public class Video
    {
        public int Id { get; set; }

        [Display(Name = "Activity")]
        public int ActivityId { get; set; }

        [Required, StringLength(20)]
        public string Title { get; set; }

        [Required, StringLength(200)]
        public string Description { get; set; }

        [Required]
        public string Url { get; set; }

        public int ViewCount { get; set; }

        public Activity Activity { get; set; }

        public string CoverImageFileName
        {
            get
            {
                return Title.Replace(" ", "-") + ".jpg";
            }
        }
    }
}

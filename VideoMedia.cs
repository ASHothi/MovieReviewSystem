using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaReviewSystem
{
    public abstract class VideoMedia
    {
        public string? Title { get; set; }
        public string? Genre { get; set; }
        public DateOnly ReleaseDate { get; set; }

        public List<Director>? Directors { get; set; }
        public List<Actor>? Actors { get; set; }
        public List<Writer>? Writers { get; set; }

        public VideoMedia()
        {

        }





    }
}

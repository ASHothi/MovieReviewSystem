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
        public string? synopsis { get; set; }

        public int AgeRating { get; set; }

        public List<Director>? Directors { get; private set; }
        public List<Actor>? Actors { get; private set; }
        public List<Writer>? Writers { get; private set; }

        public VideoMedia(string title)
        {
            if (title == null)
            {
                Title = "EMPTY";
            }
            else
            {
                Title = title;
            }
        }

        public int Test(int num) { return num; }
    }
}

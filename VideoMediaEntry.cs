using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaReviewSystem
{
    public class VideoMediaEntry
    {
        public Movie Movie { get; private set; }

        public VideoMediaEntry(Movie movie)
        {
            this.Movie = movie;
        }

    }
}

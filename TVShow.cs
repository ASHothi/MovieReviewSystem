using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaReviewSystem
{
    public class TVShow : VideoMedia
    {
        public int numOfEpisodes { get; set; }
        public int numOfSeasons { get; set; }

        public TVShow(string title) : base(title)
        {
        }
    }
}

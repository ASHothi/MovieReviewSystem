using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaReviewSystem
{
    public class VideoMediaEntry
    {
        public VideoMedia Video { get; private set; }
        public List<VideoMediaReview> reviews;

        public VideoMediaEntry(VideoMedia video)
        {
            Video = video;
            reviews = new List<VideoMediaReview>();
        }

        public void AddReviewToList(VideoMediaReview review)
        {
            reviews.Add(review);
        }
    }
}

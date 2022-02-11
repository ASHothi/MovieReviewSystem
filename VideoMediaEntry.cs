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
        public double AverageRating { get; private set; }
        public List<VideoMediaReview> Reviews { get; private set; }

        public VideoMediaEntry(VideoMedia video)
        {
            Video = video;
            Reviews = new List<VideoMediaReview>();
        }

        public void AddReviewToReviewsList(VideoMediaReview review)
        {
            Reviews.Add(review);

            foreach(VideoMediaReview aver in Reviews)
            {
                AverageRating = aver.GetRating();
            }

            AverageRating /= Reviews.Count;
        }
    }
}

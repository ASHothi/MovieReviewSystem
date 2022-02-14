using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaReviewSystem
{
    public class VideoMediaReview
    {
        private int Rating;
        public string WritenReview { get; set; }

        public VideoMediaReview(int rating, string writtenReview)
        {
            Rating = rating;
            WritenReview = writtenReview;
        }

        public VideoMediaReview(int rating) : this(rating, "EMPTY")
        {
        }

        public void SetRating(int rating)
        {
            if (rating < 0)
            {
                Rating = 0;
                return;
            }
            else if (rating > 10)
            {
                Rating = 10;
                return;
            }

            Rating = rating;
        }

        public int GetRating()
        {
            return Rating;
        }

        public override string ToString()
        {
            string str =
                "Rating: " + Rating + "/10\n" +
                "Written review:\n" + WritenReview;

            return str;
        }
    }
}
